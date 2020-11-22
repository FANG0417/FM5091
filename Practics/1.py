import numpy as np
import matplotlib.pyplot as plt

d1=np.exp(-0.04)
d2=np.exp(-0.07)
d3=np.exp(-0.09)
d4=np.exp(-0.1)

coupon = 35*(d1+d2+d3+d4)

price = 1000*d4

pv=coupon+price

print(pv)
