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
def Bise_imsigma(S,K,r,T,opt_price,call_or_put,size):

    #Basic set
    sigma_floor = 0 * np.ones(size)
    sigma_top = 10 * np.ones(size)
    torrence = 0.0001
    count = np.ones(size)
    p = np.zeros(size)

    #Basic Calculation
    im_sigma = (sigma_floor+sigma_top)/2
    p[call_or_put == 0] = BSM_call_price(S[call_or_put == 0],K[call_or_put == 0],T[call_or_put == 0],r[call_or_put == 0],im_sigma[call_or_put == 0])
    p[call_or_put >0] = BSM_put_price(S[call_or_put >0],K[call_or_put >0],T[call_or_put >0],r[call_or_put >0],im_sigma[call_or_put >0])
    dif = p - opt_price

    #Bisection Method
    while (abs(dif)>torrence).all():

        sigma_floor[(dif<0)&(abs(dif)>torrence)] = im_sigma[(dif<0)&(abs(dif)>torrence)]
        im_sigma[(dif<0)&(abs(dif)>torrence)] = (im_sigma[(dif<0)&(abs(dif)>torrence)]+sigma_top[(dif<0)&(abs(dif)>torrence)])/2
        sigma_top[(dif>0)&(abs(dif)>torrence)] = im_sigma[(dif>0)&(abs(dif)>torrence)]
        im_sigma[(dif>0)&(abs(dif)>torrence)] = (im_sigma[(dif>0)&(abs(dif)>torrence)]+sigma_floor[(dif>0)&(abs(dif)>torrence)])/2
        count[(abs(dif)>torrence)] = count[(abs(dif)>torrence)] + np.ones(len(im_sigma[abs(dif)>torrence]))

        p[call_or_put == 0] = BSM_call_price(S[call_or_put == 0],K[call_or_put == 0],T[call_or_put == 0],r[call_or_put == 0],im_sigma[call_or_put == 0])
        p[call_or_put >0] = BSM_put_price(S[call_or_put >0],K[call_or_put >0],T[call_or_put >0],r[call_or_put >0],im_sigma[call_or_put >0])

        dif = p - opt_price

    return im_sigma,count



#Newton Method
def Newt_imsigma(S,K,r,T,opt_price,call_or_put,size):
    #Basic set
    torrence = 0.0001
    count = np.zeros(size)
    im_sigma = 0.5 * np.ones(size)#guess first
    p = np.zeros(size)
    delta_sigma = np.zeros(size)

    #Basic Calculation
    p[call_or_put == 0] = BSM_call_price(S[call_or_put == 0],K[call_or_put == 0],T[call_or_put == 0],r[call_or_put == 0],im_sigma[call_or_put == 0])
    p[call_or_put >0] = BSM_put_price(S[call_or_put >0],K[call_or_put >0],T[call_or_put >0],r[call_or_put >0],im_sigma[call_or_put >0])
    dif = p - opt_price

    while (abs(dif)>torrence).all():

        delta_sigma[abs(dif)>torrence] = (-p[abs(dif)>torrence]+opt_price)/BSM_vega(S,K,T,r,im_sigma)
        im_sigma[abs(dif)>torrence] = im_sigma[abs(dif)>torrence] + delta_sigma[abs(dif)>torrence]

        count[abs(dif)>torrence] = count[abs(dif)>torrence] + np.ones(len(im_sigma[abs(dif)>torrence]))

        p[call_or_put == 0] = BSM_call_price(S[call_or_put == 0],K[call_or_put == 0],T[call_or_put == 0],r[call_or_put == 0],im_sigma[call_or_put == 0])
        p[call_or_put >0] = BSM_put_price(S[call_or_put >0],K[call_or_put >0],T[call_or_put >0],r[call_or_put >0],im_sigma[call_or_put >0])
        dif = p - opt_price

    return im_sigma,count



#Simulation

size = 5
S = 42 * np.ones(size)
K = 40 * np.ones(size) 
r = 0.1 * np.ones(size) 
T = 0.5 * np.ones(size) 
opt_price = 4.759 * np.ones(size) #opt_price must be in the range which have values
call_or_put = np.zeros(size) # 0 means call, 1 means put

# Bisection Method
iv1 = Bise_imsigma(S,K,r,T,opt_price,call_or_put,size)
print(iv1)

#Newton Method
iv2 = Newt_imsigma(S,K,r,T,opt_price,call_or_put,size)
print(iv2)
