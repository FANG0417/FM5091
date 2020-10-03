#BSM
import math
import numpy as np
from scipy.stats import norm

# BSM Valuation

d1 = lambda S, K, T, r, sigma: (math.log(S / K) + (r + 0.5 * sigma**2) * T) / (sigma * math.sqrt(T))
d2 = lambda S, K, T, r, sigma: d1(S, K, T, r, sigma) - (sigma * math.sqrt(T))

BSM_call_price = lambda S,K,T,r,sigma: S * norm.cdf(d1(S, K, T, r, sigma), 0, 1) - K * math.exp(-r * T) * norm.cdf(d2(S,K,T,r,sigma), 0, 1)

#From Hull's Book Example15-6, we can know: S =42, K=40, T=0.5, r=0.1, sigma=0.2
S1 = 42 
K1 = 40  
T1 = 0.5  
r1 = 0.1 
sigma1 = 0.2
a = BSM_call_price(S1, K1, T1, r1, sigma1)
print(a)