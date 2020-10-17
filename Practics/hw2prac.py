import numpy as np
from scipy.stats import norm

s = 50.0
n = 5
a = 0.9917
p = 0.5073
u = 1.1224
d = 0.8909
k = 50.0

strike_price = np.zeros(n+1)
f = np.zeros((n+1,n+1), dtype = np.float)

# for i in range(n+1):
#     strike_price[i] = s * u**i * d**(n-i)

strike_price[0:n+1] = s * u**np.arange(n+1) * d**(np.arange(n,-1,-1))

# for i in range(n+1):
#     f[n,i] = max(k - strike_price[i], 0)
f[n,:] = np.maximum(k - strike_price[:], 0)

# z = n+1
# for i in range(n-1,-1,-1): #n-1  0
#     z -= 1
#     for j in range(z):
#         f[i,j] = a * (p * f[i+1,j+1] + (1-p) * f[i+1,j])
#         f[i,j] = max(f[i,j], k - s * u**j * d**(i-j))

for i in range(n-1,-1,-1):
    b = k - s * u**np.arange(i+1) * d**(np.arange(i,-1,-1))
    f[i,0:i+1] = np.maximum(a * (p * f[i+1,1:i+2] + (1-p) * f[i+1,0:i+1]), b)

    

print(f[0,0])