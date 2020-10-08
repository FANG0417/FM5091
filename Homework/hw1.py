#BSM
import math
import numpy as np
from scipy.stats import norm

#Basic Functions
d1 = lambda S, K, T, r, sigma: (math.log(S / K) + (r + 0.5 * sigma**2) * T) / (sigma * math.sqrt(T))

d2 = lambda S, K, T, r, sigma: d1(S, K, T, r, sigma) - (sigma * math.sqrt(T))

# BSM Valuation

BSM_call_price = lambda S,K,T,r,sigma: (S * norm.cdf(d1(S, K, T, r, sigma), 0, 1) - K * math.exp(-r * T) * norm.cdf(d2(S, K, T, r, sigma), 0, 1))

BSM_put_price = lambda S,K,T,r,sigma: K * math.exp(-r * T) * norm.cdf(-d2(S, K, T, r, sigma), 0, 1) - S * norm.cdf(-d1(S, K, T, r, sigma), 0, 1)

# Greeks Valuation

#Delta

BSM_call_delta = lambda S,K,T,r,sigma: norm.cdf(d1(S, K, T, r, sigma), 0, 1)
 
BSM_put_delta = lambda S,K,T,r,sigma: norm.cdf(d1(S, K, T, r, sigma), 0, 1) - 1

#Theta

BSM_call_theta = lambda S,K,T,r,sigma: -S * norm.pdf(d1(S, K, T, r, sigma), 0, 1)* sigma / (2 * math.sqrt(T)) - r * K * math.exp(-r * T) * norm.cdf(d2(S, K, T, r, sigma),0,1)

BSM_put_theta = lambda S,K,T,r,sigma: -S * norm.pdf(d1(S, K, T, r, sigma), 0, 1) * sigma / (2 * math.sqrt(T)) + r * K * math.exp(-r * T) * norm.cdf(-d2(S, K, T, r, sigma), 0, 1)

#Gamma

BSM_gamma = lambda S,K,T,r,sigma: norm.pdf(d1(S, K, T, r, sigma), 0, 1)/(S * sigma * math.sqrt(T))

#vega

BSM_vega = lambda S,K,T,r,sigma:  S * math.sqrt(T) * norm.pdf(d1(S, K, T, r, sigma), 0, 1)

#Rho

BSM_call_rho = lambda S,K,T,r,sigma: K * T * math.exp(-r * T) * norm.cdf(d2(S, K, T, r, sigma), 0, 1)

BSM_put_rho = lambda S,K,T,r,sigma: - K * T * math.exp(-r * T) * norm.cdf(-d2(S, K, T, r, sigma), 0, 1)
    

#similation

#From Hull's Book Example15-6, we can know: S =42, K=40, T=0.5, r=0.1, sigma=0.2
S1 = 42 
K1 = 40  
T1 = 0.5  
r1 = 0.1 
sigma1 = 0.2
a = BSM_call_price(S1, K1, T1, r1, sigma1)
b = BSM_put_price(S1, K1, T1, r1, sigma1)
print(a,b,"the answer is right")

#From Hull's Book Chapter19, we can know: call option S =49, K=50, T=0.3846, r=0.05, sigma=0.2
S2 = 49  
K2 = 50  
T2 = 0.3846  
r2 = 0.05  
sigma2 = 0.2
c = BSM_call_delta(S2, K2, T2, r2, sigma2)
d = BSM_call_theta(S2, K2, T2, r2, sigma2)
e = BSM_gamma(S2, K2, T2, r2, sigma2)
f = BSM_vega(S2, K2, T2, r2, sigma2)
g = BSM_call_rho(S2, K2, T2, r2, sigma2)
print(c,d,e,f,g,"the answer is right")

#From Hull's Book Chapter19, we can know: put option S =49, K=50, T=0.3846, r=0.05, sigma=0.2
S2 = 49  
K2 = 50  
T2 = 0.3846  
r2 = 0.05  
sigma2 = 0.2
h = BSM_put_delta(S2, K2, T2, r2, sigma2)
i = BSM_put_theta(S2, K2, T2, r2, sigma2)
j = BSM_gamma(S2, K2, T2, r2, sigma2)
k = BSM_vega(S2, K2, T2, r2, sigma2)
l = BSM_put_rho(S2, K2, T2, r2, sigma2)
print(h,i,j,k,l,"the answer is right")