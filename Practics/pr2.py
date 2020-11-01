#BSM
import numpy as np
from scipy.stats import norm

#Basic Functions
d1 = lambda S, K, T, r, sigma: (np.log(S / K) + (r + 0.5 * sigma**2) * T) / (sigma * np.sqrt(T))

d2 = lambda S, K, T, r, sigma: d1(S, K, T, r, sigma) - (sigma * np.sqrt(T))

# BSM Valuation

BSM_call_price = lambda S,K,T,r,sigma: (S * norm.cdf(d1(S, K, T, r, sigma), 0, 1) - K * np.exp(-r * T) * norm.cdf(d2(S, K, T, r, sigma), 0, 1))

BSM_put_price = lambda S,K,T,r,sigma: K * np.exp(-r * T) * norm.cdf(-d2(S, K, T, r, sigma), 0, 1) - S * norm.cdf(-d1(S, K, T, r, sigma), 0, 1)

#vega

BSM_vega = lambda S,K,T,r,sigma:  S * np.sqrt(T) * norm.pdf(d1(S, K, T, r, sigma), 0, 1)

S = 42 
K = 40 
r = 0.1 
T = 0.5 
callprice = 4.759   
in_sigma = 0.5

#calculator
count = 0
p = 0
while abs(p - callprice)>0.0001:
    count += 1
    p = BSM_call_price(S,K,T,r,in_sigma)
    delta_sigma = (-p+callprice)/BSM_vega(S,K,T,r,in_sigma)
    in_sigma = in_sigma + delta_sigma


print(in_sigma,count)
