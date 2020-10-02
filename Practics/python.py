import numpy as np

# def isPrime(x): 
#     i = np.arange(x - 1, 1, -1) # vector of numbers to divide by
#     print(i) 
#     xx = np.ones(len(i)) * x # vector of number being tested 
#     print(xx)
#     g = np.mod(xx,i) # perform mod to test for prime-ness 
#     m = np.zeros(len(i)) # if anything = 0, then not prime 
#     return (sum(g == m) <= 0) # return result of test

# isPrime(6)

# from functools import reduce
# g = [1,2,3,4,5]
# m = list(map(lambda x: x ** 2, g)) 
# print(m)
# r = reduce(lambda x, y: x + y, g) 
# print(r)

# def map(setvector, target): 
#     setvector[target] = setvector[target] * 10
#     if target < len(setvector) - 1: 
#         return map(setvector, target + 1) 
#     else: 
#         return setvector
# print(map(g,4))

from sympy import *

# x = symbols('x')
# expr = limit(sin(x)/x,x,0)
# b = expr.doit()
# print(expr,b)

Matrix([[1,2,3],[4,5,6],[7,8,0]]).rref()

