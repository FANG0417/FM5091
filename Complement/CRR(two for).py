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

    for i in range(N+1):

        stock_pricen[i] = S * u(T, sigma, N)**i * (1/u(T, sigma, N))**(N-i)

    return stock_pricen

#catalogy the option
Euro_or_Amer = input("European : press 0  Amercan: press 1 : ")

call_or_put = input("call : press 0  put: press 1 : ")


# European call option price
def Euro_call(S, K, T, r, sigma, N, q):

    global tree
    tree = np.zeros((N+1,N+1))
    
    if Euro_or_Amer == 0:

        if call_or_put == 0:
            for i in range(N+1):
                tree[N,i] = max(last_stock_price(S, T, sigma, N)[i] - K, 0)
            for i in range(N-1,-1,-1):
                for j in range(i+1):
                    tree[i,j] = np.exp(-r * T/N) * (p(T, r, sigma, N, q) * tree[i+1,j+1] + (1-p(T, r, sigma, N, q)) * tree[i+1,j])
                    tree[i,j] = max(tree[i,j], 0)

        else:
            for i in range(N+1):
                tree[N,i] = max(-last_stock_price(S, T, sigma, N)[i] + K, 0)
            for i in range(N-1,-1,-1):
                for j in range(i+1):
                    tree[i,j] = np.exp(-r * T/N) * (p(T, r, sigma, N, q) * tree[i+1,j+1] + (1-p(T, r, sigma, N, q)) * tree[i+1,j])
                    tree[i,j] = max(tree[i,j], 0)

    else:

        if call_or_put == 0:
            for i in range(N+1):
                tree[N,i] = max(last_stock_price(S, T, sigma, N)[i] - K, 0)
            for i in range(N-1,-1,-1):
                for j in range(i+1):
                    tree[i,j] = np.exp(-r * T/N) * (p(T, r, sigma, N, q) * tree[i+1,j+1] + (1-p(T, r, sigma, N, q)) * tree[i+1,j])
                    tree[i,j] = max(tree[i,j], S * u(T, sigma, N)**j * (1/u(T, sigma, N))**(i-j) - K)
        
        else:
            for i in range(N+1):
                tree[N,i] = max(-last_stock_price(S, T, sigma, N)[i] + K, 0)
            for i in range(N-1,-1,-1):
                for j in range(i+1):
                    tree[i,j] = np.exp(-r * T/N) * (p(T, r, sigma, N, q) * tree[i+1,j+1] + (1-p(T, r, sigma, N, q)) * tree[i+1,j])
                    tree[i,j] = max(tree[i,j], K - S * u(T, sigma, N)**j * (1/u(T, sigma, N))**(i-j))

    return tree[0,0]

def Greeks(S, K, T, r, sigma, N, q):

    delta = (tree[1,1] - tree[1,0])/(S * u(T, sigma, N) - S/u(T, sigma, N)) 

    gamma = (((tree[2,2] - tree[2,1])/(S * u(T, sigma, N)**2 - S)) - ((tree[2,1] - tree[2,0])/(S  - S / u(T, sigma, N)**2))) / (0.5 * (S * u(T, sigma, N)**2 - S / u(T, sigma, N)**2)) 

    vega = (Euro_call(S, K, T, r, sigma+0.01, N, q) - Euro_call(S, K, T, r, sigma-0.01, N, q))/(2 * 0.01)

    theta = (tree[2,1] - tree[0,0])/(2 * T/N)

    rho = (Euro_call(S, K, T, r+0.001, sigma, N, q) - Euro_call(S, K, T, r-0.001, sigma, N, q))/(2 * 0.001)

    print("delta is", delta)
    print("gamma is", gamma)
    print("vega is", vega)
    print("theta is", theta)
    print("rho is ", rho)


#simulation

# S = 50
# K = 50
# T = 0.4164
# r = 0.1
# sigma = 0.4
# N = 50
# q = 0

# S = 100
# K = 100
# T = 1
# r = 0.05
# sigma = 0.1
# N = 50
# q = 0.1

S = 810
K = 800
T = 0.5
r = 0.05
sigma = 0.2
N = 6
q = 0.02

print(Euro_call(S, K, T, r, sigma, N, q))
print(Greeks(S, K, T, r, sigma, N, q))


    