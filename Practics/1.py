import numpy as np
import sympy as sp
import matplotlib.pyplot as plt
from scipy.optimize import fsolve
from scipy.integrate import quad

x = sp.symbols('x')
t = sp.symbols('t')

wx = (sp.E-1)/(sp.E*x**2+(sp.E+1)*x+1)
Wx = sp.log((1+sp.E*x)/(1+x))

mean = sp.integrate(x*wx, [x,0, 1000])
print("the mean is: ",mean.evalf())

median = sp.solve(sp.Eq(Wx,.5))[0]
print("the median is :", median)

print("the mod doesn't exist")

mad = sp.integrate(wx*sp.Abs(x-mean), [x,0, 1000])
print("the mad is :", mad.evalf())

var = sp.integrate(wx*(x-mean)**2, [x,0, 1000])
print("the var is :", var.evalf())

sd = (var)**(1/2)
print("the SD is ", sd.evalf())

Q1 = sp.solve(sp.Eq(Wx,.25))[0]
Q3 = sp.solve(sp.Eq(Wx,.75))[0]
print("The IQR is ", Q3 - Q1)

p = Wx.subs({t:(mean-sd)})+(1-Wx.subs({t:(mean+sd)}))
print("p is:",p)