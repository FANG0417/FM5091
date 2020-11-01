#BSM
import numpy as np
from scipy.stats import norm
import time

#Basic Functions
d1 = lambda S, K, T, r, sigma: (np.log(S / K) + (r + 0.5 * sigma**2) * T) / (sigma * np.sqrt(T))

d2 = lambda S, K, T, r, sigma: d1(S, K, T, r, sigma) - (sigma * np.sqrt(T))

# BSM Valuation

BSM_call_price = lambda S,K,T,r,sigma: (S * norm.cdf(d1(S, K, T, r, sigma), 0, 1) - K * np.exp(-r * T) * norm.cdf(d2(S, K, T, r, sigma), 0, 1))

BSM_put_price = lambda S,K,T,r,sigma: K * np.exp(-r * T) * norm.cdf(-d2(S, K, T, r, sigma), 0, 1) - S * norm.cdf(-d1(S, K, T, r, sigma), 0, 1)

def insigma(S,K,r,T,callprice,call_or_put,size):
    size = 2
    sigma_floor = 0 * np.ones(size) 
    sigma_top = 10 * np.ones(size)
    insigma = (sigma_floor+sigma_top)/2

    count = np.zeros(size)
    p = np.zeros(size)
    iv = p - callprice


    while (abs(iv) > 0.0001).all():
        p = BSM_call_price(S,K,T,r,insigma)
        print(p)
        iv = p - callprice
        print("iv1",iv)
        sigma_floor[(iv<0)&(abs(iv)>0.0001)] = insigma[(iv<0)&(abs(iv)>0.0001)]
        insigma[(iv<0)&(abs(iv)>0.0001)] = (insigma[(iv<0)&(abs(iv)>0.0001)]+sigma_top[(iv<0)&(abs(iv)>0.0001)])/2
        sigma_top[(iv>0)&(abs(iv)>0.0001)] = insigma[(iv>0)&(abs(iv)>0.0001)]
        insigma[(iv)>0&(abs(iv)>0.0001)] = (insigma[(iv>0)&(abs(iv)>0.0001)]+sigma_floor[(iv>0)&(abs(iv)>0.0001)])/2
        count[(abs(iv)>0.0001)] = count[(abs(iv)>0.0001)] + np.ones(1)
        print("iv2",iv)
        print(count)
        print(insigma)
        print('nmsl')
    return insigma,count

T1 = time.time()
size = 1000000
S = 42 * np.ones(size)
K = 40 * np.ones(size)
r = 0.1 * np.ones(size)
T = 0.5 * np.ones(size)
callprice = 4.759 * np.ones(size)
T2 = time.time()
# print(insigma(S,K,r,T,callprice))
print('程序运行时间:%s毫秒' % ((T2 - T1)*1000))

