# CRR method
import numpy as np


#Basic value
def u(T, sigma, N):
    u = np.exp(sigma * np.sqrt(T/N))
    return u

def p(T, r, sigma, N, q):
    p = (np.exp((r-q) * T/N) - 1/u(T, sigma, N))/(u(T, sigma, N) - 1/u(T, sigma, N))
    return p 



#stock prices binomial trees without inner portion of lattice

def last_stock_price(S, T, sigma, N):

    stock_pricen = np.zeros(N+1)

    stock_pricen[0:N+1] = S * u(T, sigma, N)**np.arange(N+1) * (1/u(T, sigma, N))**np.arange(N,-1,-1)

    return stock_pricen




# European call option price

def option_price(S, K, T, r, sigma, N, q):

    global tree
    tree = np.zeros((N+1,N+1))
    
    tree[N,:] = np.maximum(last_stock_price(S, T, sigma, N)[:] - K, 0)

    for i in range(N-1,-1,-1):

        tree[i,0:i+1] = np.exp(-r * T/N) * (p(T, r, sigma, N, q) * tree[i+1,1:i+2] + (1-p(T, r, sigma, N, q)) * tree[i+1,0:i+1])

    return tree[0,0]


S = 810
K = 800
T = 0.5
r = 0.05
sigma = 0.2
N = 2
q = 0.02

print("option price is", option_price(S, K, T, r, sigma, N, q))
