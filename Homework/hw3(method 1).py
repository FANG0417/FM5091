#Implied Volatility
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



# Bisection Method 
def Bise_imsigma(S,K,r,T,opt_price,call_or_put):

    #Basic set
    sigma_floor = 0.0001
    sigma_top = 50 
    torrence = 0.0001
    count = 1

    #Basic Calculation
    im_sigma = (sigma_floor+sigma_top)/2
    if call_or_put == 0:
            p = BSM_call_price(S,K,T,r,im_sigma)
    else:
            p = BSM_put_price(S,K,T,r,im_sigma)
    dif = p - opt_price

    #Bisection Method
    while abs(dif)>torrence:

        count += 1

        if dif<0:
            sigma_floor = im_sigma
            im_sigma = (im_sigma+sigma_top)/2
        else:
            sigma_top = im_sigma
            im_sigma = (im_sigma+sigma_floor)/2

        if call_or_put == 0:
            p = BSM_call_price(S,K,T,r,im_sigma)
        else:
            p = BSM_put_price(S,K,T,r,im_sigma)

        dif = p - opt_price
    return im_sigma,count
#Vectorized
Bise_imsigma_v = np.vectorize(Bise_imsigma)


#Newton Method
def Newt_imsigma(S,K,r,T,opt_price,call_or_put):
    #Basic set
    torrence = 0.0001
    count = 0
    im_sigma = 0.5 #guess first

    #Basic Calculation
    if call_or_put == 0:
            p = BSM_call_price(S,K,T,r,im_sigma)
    else:
            p = BSM_put_price(S,K,T,r,im_sigma)
    dif = p - opt_price

    while abs(dif)>torrence:

        delta_sigma = (-p+opt_price)/BSM_vega(S,K,T,r,im_sigma)
        im_sigma = im_sigma + delta_sigma

        count += 1

        if call_or_put == 0:
            p = BSM_call_price(S,K,T,r,im_sigma)
        else:
            p = BSM_put_price(S,K,T,r,im_sigma)
        dif = p - opt_price
        print(im_sigma,count)
    return im_sigma,count
#Vectorized
Newt_imsigma_v = np.vectorize(Newt_imsigma)


#Simulation

size = 1
S = 42 * np.ones(size)
K = 40 * np.ones(size) 
r = 0.1 * np.ones(size) 
T = 0.5 * np.ones(size) 
opt_price = 4.759 * np.ones(size) #opt_price must be in the range which have values
call_or_put = np.zeros(size) # 0 means call, 1 means put

# Bisection Method
iv1 = Bise_imsigma_v(S,K,r,T,opt_price,call_or_put)
print(iv1)

#Newton Method
iv2 = Newt_imsigma_v(S,K,r,T,opt_price,call_or_put)
print(iv2)
