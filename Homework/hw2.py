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



#catalogy the option（preparation)

Euro_or_Amer = int(input("European : press 0  Amercan: press 1 : "))

call_or_put = int(input("call : press 0  put: press 1 : "))
 


# European call option price

def option_price(S, K, T, r, sigma, N, q):

    global tree

    tree = np.zeros((N+1,N+1))

    if call_or_put == 0:

        tree[N,:] = np.maximum(last_stock_price(S, T, sigma, N)[:] - K, 0)
        
        for i in range(N-1,-1,-1):

            if Euro_or_Amer == 0:
                #European call option
                tree[i,0:i+1] = np.exp(-r * T/N) * (p(T, r, sigma, N, q) * tree[i+1,1:i+2] + (1-p(T, r, sigma, N, q)) * tree[i+1,0:i+1])
                
            else:
                #American call option
                tree[i,0:i+1] = np.exp(-r * T/N) * (p(T, r, sigma, N, q) * tree[i+1,1:i+2] + (1-p(T, r, sigma, N, q)) * tree[i+1,0:i+1])

                tree[i,0:i+1] = np.maximum(tree[i,0:i+1], S * u(T, sigma, N)**np.arange(i+1) * (1/u(T, sigma, N))**np.arange(i,-1,-1) - K)

            
    else:

        tree[N,:] = np.maximum(- last_stock_price(S, T, sigma, N)[:] + K, 0)

        for i in range(N-1,-1,-1):

            if Euro_or_Amer == 0:
                #European put option
                tree[i,0:i+1] = np.exp(-r * T/N) * (p(T, r, sigma, N, q) * tree[i+1,1:i+2] + (1-p(T, r, sigma, N, q)) * tree[i+1,0:i+1])
        
            else:
                #American put option
                tree[i,0:i+1] = np.exp(-r * T/N) * (p(T, r, sigma, N, q) * tree[i+1,1:i+2] + (1-p(T, r, sigma, N, q)) * tree[i+1,0:i+1])

                tree[i,0:i+1] = np.maximum(tree[i,0:i+1], - S * u(T, sigma, N)**np.arange(i+1) * (1/u(T, sigma, N))**np.arange(i,-1,-1) + K)


    return tree[0,0]


#calculate the Greeks

def Greeks(S, K, T, r, sigma, N, q):

    delta = (tree[1,1] - tree[1,0])/(S * u(T, sigma, N) - S/u(T, sigma, N))

    gamma = (((tree[2,2] - tree[2,1])/(S * u(T, sigma, N)**2 - S)) - ((tree[2,1] - tree[2,0])/(S  - S / u(T, sigma, N)**2))) / (0.5 * (S * u(T, sigma, N)**2 - S / u(T, sigma, N)**2))

    vega = (option_price(S, K, T, r, sigma+0.01, N, q) - option_price(S, K, T, r, sigma-0.01, N, q))/(2 * 0.01)

    theta = (tree[2,0] - tree[0,0])/(2 * T/N)

    rho = (option_price(S, K, T, r+0.0001, sigma, N, q) - option_price(S, K, T, r-0.0001, sigma, N, q))/(2 * 0.0001)

    print("delta is", delta)
    print("gamma is", gamma)
    print("vega is", vega)
    print("theta is", theta)
    print("rho is ", rho)


#simulation

# this is American put option

S = 50
K = 50
T = 0.4164
r = 0.1
sigma = 0.4
N = 5
q = 0.1


print("option price is", option_price(S, K, T, r, sigma, N, q))
print(Greeks(S, K, T, r, sigma, N, q))
