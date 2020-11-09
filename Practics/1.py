#BSM
import numpy as np
from scipy.stats import norm
import time
from scipy.special import perm, comb
import matplotlib.pyplot as plt



a = np.arange(4*4).reshape(4,4)
b = np.ones(4*4).reshape(4,4)
c = a[0:2]
d = b[:,c]
print(a,b)