#BSM
import math
import numpy as np
from scipy.stats import norm

#Basic Function

def N(d):
    return norm.cdf(d, 0, 1)

def d1_f(S, K, T, r, sigma):
    d1 = (math.log(S / K) + (r + 0.5 * sigma**2) * T) / (sigma * math.sqrt(T))
    return d1

def N_de(d):
    return norm.pdf(d, 0, 1)
    
# BSM Valuation

def BSM_call_price(S, K, T, r, sigma):
    d1 = d1_f(S, K, T, r, sigma)
    d2 = d1 - sigma * math.sqrt(T)
    call_price = S * N(d1) - K * math.exp(-r * T) * N(d2)
    return call_price
 
def BSM_put_price(S, K, T, r, sigma):
    d1 = d1_f(S, K, T, r, sigma)
    d2 = d1 - sigma * math.sqrt(T)
    put_price = K * math.exp(-r * T) * N(-d2) - S * N(-d1)
    return put_price

# Greeks Valuation

#Delta

def BSM_call_delta(S, K, T, r, sigma):
    d1 = d1_f(S, K, T, r, sigma)
    call_delta = N(d1)
    return call_delta

def BSM_put_delta(S, K, T, r, sigma):
    d1 = d1_f(S, K, T, r, sigma)
    put_delta = N(d1) - 1
    return put_delta

#Theta

def BSM_call_theta(S, K, T, r, sigma):
    d1 = d1_f(S, K, T, r, sigma)
    d2 = d1 - sigma * math.sqrt(T)
    call_theta = -S * N_de(d1) * sigma / (2 * math.sqrt(T)) - r * K * math.exp(-r * T) * N(d2)
    return call_theta

def BSM_put_theta(S, K, T, r, sigma):
    d1 = d1_f(S, K, T, r, sigma)
    d2 = d1 - sigma * math.sqrt(T)
    put_theta = -S * N_de(d1) * sigma / (2 * math.sqrt(T)) + r * K * math.exp(-r * T) * N(-d2)
    return put_theta

#Gamma

def BSM_gamma(S, K, T, r, sigma):
    d1 = d1_f(S, K, T, r, sigma)
    gamma = N_de(d1)/(S * sigma * math.sqrt(T))
    return gamma

#vega
def BSM_vega(S, K, T, r, sigma):
    d1 = d1_f(S, K, T, r, sigma)
    vega = S * math.sqrt(T) * N_de(d1)
    return vega

#Rho
def BSM_call_rho(S, K, T, r, sigma):
    d1 = d1_f(S, K, T, r, sigma)
    d2 = d1 - sigma * math.sqrt(T)
    call_rho = K * T * math.exp(-r*T) * N(d2)
    return call_rho

def BSM_put_rho(S, K, T, r, sigma):
    d1 = d1_f(S, K, T, r, sigma)
    d2 = d1 - sigma * math.sqrt(T)
    put_rho = -K * T * math.exp(-r * T) * N(-d2)
    return put_rho