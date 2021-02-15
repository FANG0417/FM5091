from scipy.integrate import quad, dblquad
import numpy as np
import sympy as sp

x,y = sp.symbols('x y')
f = 1/sp.log(2)*sp.E**(-x*y-y)
ux = sp.integrate(x*f,[x,0,1],[y,0,float("inf")])
print("1",ux)
uy = sp.integrate(y*f,[x,0,1],[y,0,float("inf")])
print(uy)
varx = sp.integrate((x-ux)**2*f,[x,0,1],[y,0,float("inf")])
print("2",varx)
vary = sp.integrate((y-uy)**2*f,[x,0,1],[y,0,float("inf")])
print(vary)
covxy = sp.integrate(x*y*f,[x,0,1],[y,0,float("inf")])-ux*uy
print(covxy)