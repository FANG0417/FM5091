#BSM
import math
import numpy as np
from scipy.stats import norm

#Basic Functions
d1 = lambda S, K, T, r, sigma: (np.log(S / K) + (r + 0.5 * sigma**2) * T) / (sigma * np.sqrt(T))

d2 = lambda S, K, T, r, sigma: d1(S, K, T, r, sigma) - (sigma * np.sqrt(T))

# BSM Valuation

BSM_call_price = lambda S,K,T,r,sigma: (S * norm.cdf(d1(S, K, T, r, sigma), 0, 1) - K * np.exp(-r * T) * norm.cdf(d2(S, K, T, r, sigma), 0, 1))

BSM_put_price = lambda S,K,T,r,sigma: K * np.exp(-r * T) * norm.cdf(-d2(S, K, T, r, sigma), 0, 1) - S * norm.cdf(-d1(S, K, T, r, sigma), 0, 1)


size = 10
S = 42 * np.ones(size)
K = 40 * np.ones(size)
r = 0.1 * np.ones(size)
T = 0.5 * np.ones(size)
sigma = 0.2 * np.ones(size)

print(BSM_call_price(S,K,T,r,sigma))