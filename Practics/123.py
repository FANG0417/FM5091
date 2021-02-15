import numpy as np
import sympy as sp
import matplotlib.pyplot as plt
from scipy.optimize import fsolve
from scipy.special import perm,comb
import seaborn as sns
from scipy.stats import uniform
from scipy.stats import norm
from bisect import bisect_left 

Trials = 10000000
number = np.zeros(Trials)
n = np.array([1,2,3,4,5,6])
p1 = np.array([1,1,1,1,1,1])/6

a = np.random.choice(n,size = Trials, replace = True,p = p1)
b = np.random.binomial(3,1/2,size = Trials)
number = a + b

mean = np.mean(number)
var = np.var(number)

print(mean,var)