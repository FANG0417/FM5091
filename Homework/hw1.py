#BSM
import math
import numpy as np
from scipy.stats import norm

# BSM Valuation

BSM_call_price = lambda S,K,T,r,sigma: (S * norm.cdf((math.log(S / K) + (r + 0.5 * sigma**2)* T) / (sigma * math.sqrt(T)), 0, 1) - K * math.exp(-r * T) * norm.cdf((math.log(S / K) + ( r + 0.5 * sigma**2) * T ) / ( sigma *math.sqrt(T))- sigma * math.sqrt(T), 0, 1))

BSM_put_price = lambda S,K,T,r,sigma: K * math.exp(-r * T) * norm.cdf(sigma * math.sqrt(T) - (math.log(S / K) + (r + 0.5 * sigma**2) * T) / (sigma * math.sqrt(T)), 0, 1) - S * norm.cdf(-(math.log(S / K) + (r + 0.5 * sigma**2) * T) / (sigma * math.sqrt(T)), 0, 1)

# Greeks Valuation

#Delta

BSM_call_delta = lambda S,K,T,r,sigma: norm.cdf((math.log(S / K) + (r + 0.5 * sigma**2) * T) / (sigma * math.sqrt(T)), 0, 1)
 
BSM_put_delta = lambda S,K,T,r,sigma: norm.cdf((math.log(S / K) + (r + 0.5 * sigma**2) * T) / (sigma * math.sqrt(T)), 0, 1) - 1

#Theta

BSM_call_theta = lambda S,K,T,r,sigma: -S * norm.pdf((math.log(S / K) + (r + 0.5 * sigma**2) * T) / (sigma * math.sqrt(T)), 0, 1)* sigma / (2 * math.sqrt(T)) - r * K * math.exp(-r * T) * norm.cdf((math.log(S/K) + (r + 0.5 * sigma**2) * T) / (sigma*math.sqrt(T)) - sigma * math.sqrt(T),0,1)

BSM_put_theta = lambda S,K,T,r,sigma: -S * norm.pdf((math.log(S / K) + (r + 0.5 * sigma**2) * T) / (sigma * math.sqrt(T)), 0, 1) * sigma / (2 * math.sqrt(T)) + r * K * math.exp(-r * T) * norm.cdf(sigma * math.sqrt(T) - (math.log(S / K) + (r + 0.5 * sigma**2) * T) / (sigma * math.sqrt(T)), 0, 1)

#Gamma

BSM_gamma = lambda S,K,T,r,sigma: norm.pdf((math.log(S / K) + (r + 0.5 * sigma**2) * T)/(sigma * math.sqrt(T)), 0, 1)/(S * sigma * math.sqrt(T))

#vega

BSM_vega = lambda S,K,T,r,sigma:  S * math.sqrt(T) * norm.pdf((math.log(S / K) + (r + 0.5 * sigma**2) * T) / (sigma * math.sqrt(T)), 0, 1)

#Rho

BSM_call_rho = lambda S,K,T,r,sigma: K * T * math.exp(-r * T) * norm.cdf((math.log(S / K) + (r + 0.5 * sigma**2) * T) / (sigma * math.sqrt(T)) - sigma * math.sqrt(T), 0, 1)

BSM_put_rho = lambda S,K,T,r,sigma: K * T * math.exp(-r * T) * norm.cdf(-(math.log(S / K) + (r + 0.5 * sigma**2) * T)/(sigma * math.sqrt(T)) + sigma*math.sqrt(T), 0, 1)
    

#similation
#From Hull's Book Example15-6, we can know: S =42, K=40, T=0.5, r=0.1, sigma=0.2
a = BSM_call_price(42,40,0.5,0.1,0.2)
b = BSM_put_price(42,40,0.5,0.1,0.2)
print(a,b,"the answer is right")

#From Hull's Book Chapter19, we can know: call option S =49, K=50, T=0.3846, r=0.05, sigma=0.2
c = BSM_call_delta(49,50,0.3846,0.05,0.2)
d = BSM_call_theta(49,50,0.3846,0.05,0.2)
e = BSM_gamma(49,50,0.3846,0.05,0.2)
f = BSM_vega(49,50,0.3846,0.05,0.2)
g = BSM_call_rho(49,50,0.3846,0.05,0.2)
print(c,d,e,f,g,"the answer is right")

#From Hull's Book Chapter19, we can know: put option S =49, K=50, T=0.3846, r=0.05, sigma=0.2
h = BSM_put_delta(49,50,0.3846,0.05,0.2)
i = BSM_put_theta(49,50,0.3846,0.05,0.2)
j = BSM_gamma(49,50,0.3846,0.05,0.2)
k = BSM_vega(49,50,0.3846,0.05,0.2)
l = BSM_put_rho(49,50,0.3846,0.05,0.2)
print(h,i,j,k,l,"the answer is right")