import numpy as np
import pyodbc
import pandas as pd
import matplotlib.pyplot as plt


#calculate return function
def yield_return(ticker):
    conn = pyodbc.connect ('Driver={SQL Server};''Server=DESKTOP-SDBL0O9;''Database=FM;''Trusted_Connection = yes;')
    cp = pd.read_sql("select ClosePrice from [FM].[FM].[Price],[FM].[FM].[Instrument] \
        where Price.InstID = Instrument.ID and Instrument.StockTicker ='" + ticker + "'",con=conn)
    df = pd.DataFrame(cp)
    returns = pd.DataFrame()
    for i in df:
        returns[i] = np.log(df[i][1:].values/df[i][:-1].values)
    return returns

#prepare
#calculate returns of 7 companies(original data)
return1_1 = np.array(yield_return("GOOG")['ClosePrice'])
return1_2 = np.array(yield_return("MSFT")['ClosePrice'])
return1_3 = np.array(yield_return("AAPL")['ClosePrice'])
return1_4 = np.array(yield_return("AMZN")['ClosePrice'])
return2_1 = np.array(yield_return("GE")['ClosePrice'])
return3_1 = np.array(yield_return("KO")['ClosePrice'])
return4_1 = np.array(yield_return("VLO")['ClosePrice'])

#normalize the original data
Areturn1_1 = return1_1 - np.mean(return1_1)
Areturn1_2 = return1_2 - np.mean(return1_2)
Areturn1_3 = return1_3 - np.mean(return1_3)
Areturn1_4 = return1_4 - np.mean(return1_4)
Areturn2_1 = return2_1 - np.mean(return2_1)
Areturn3_1 = return3_1 - np.mean(return3_1)
Areturn4_1 = return4_1 - np.mean(return4_1)

#same sector
#step 1 : find data set
ss_mean = np.array([np.mean(return1_1),np.mean(return1_2),np.mean(return1_3),np.mean(return1_4)])
ss_orireturn = np.transpose([return1_1,return1_2,return1_3,return1_4])
ss_return = np.transpose([Areturn1_1,Areturn1_2,Areturn1_3,Areturn1_4])

#step 2 : build a covariance matrix
ss_cov = np.cov(ss_return,rowvar = False)

#step 3 : perform eigendecomposition
ss_eigenvalues, ss_eigenvectors = np.linalg.eig(ss_cov)
ss_prop = np.zeros([4,1])
for i in range(4):
    ss_prop[i] = ss_eigenvalues[i] / np.sum(ss_eigenvalues)

#step 4 : reduce dimensionality

ssd_eigenvaluesid = np.argsort(ss_eigenvalues) #sort
ssd_eigenvaluesid = ssd_eigenvaluesid[1:4]   #reduce one dimension
ssd_eigenvectors = ss_eigenvectors[:,ssd_eigenvaluesid] #eigenvectors after reduction
biggest_ss_prop = ss_prop[ssd_eigenvaluesid[2]]   #biggest proportion     
ssd_lowreturn = np.dot(ss_return,ssd_eigenvectors)   #normalized data in low dimension space
ssd_newreturn = np.dot(ssd_lowreturn,ssd_eigenvectors.T) #normalized data in original space

#step 5 : reconstruct original data
ss_reconreturn = ssd_newreturn + ss_mean 


#outcome 
print('ss_eigenvalues',ss_eigenvalues)
print('ss_eigenvectors',ss_eigenvectors)
print('order choosen',ssd_eigenvaluesid)
print('biggest_ss_prop',biggest_ss_prop)



#plot
fig1 = plt.figure(3)
plt.subplot(311)
plt.plot(ss_orireturn,'o')
plt.title('Original Data')

plt.subplot(312)
plt.plot(ssd_lowreturn,'o')
plt.title('Reduce Dimensionality Data')

plt.subplot(313)
plt.plot(ss_reconreturn,'o')
plt.title('Reconstruct Original Data')
plt.show()


#different sector
#step 1 : find data set
ds_mean = np.array([np.mean(return1_1),np.mean(return2_1),np.mean(return3_1),np.mean(return4_1)])
ds_orireturn = np.transpose([return1_1,return2_1,return3_1,return4_1])
ds_return = np.transpose([Areturn1_1,Areturn2_1,Areturn3_1,Areturn4_1])

#step 2 : build a covariance matrix
ds_cov = np.cov(ds_return,rowvar = False)

#step 3 : perform eigendecomposition
ds_eigenvalues, ds_eigenvectors = np.linalg.eig(ds_cov)
ds_prop = np.zeros([4,1])
for i in range(4):
    ds_prop[i] = ds_eigenvalues[i] / np.sum(ds_eigenvalues)

#step 4 : reduce dimensionality

dsd_eigenvaluesid = np.argsort(ds_eigenvalues) #sort
dsd_eigenvaluesid = dsd_eigenvaluesid[1:4]   #reduce one dimension
dsd_eigenvectors = ds_eigenvectors[:,dsd_eigenvaluesid] #eigenvectors after reduction
biggest_ds_prop = ds_prop[dsd_eigenvaluesid[2]]   #biggest proportion     
dsd_lowreturn = np.dot(ds_return,dsd_eigenvectors)   #normalized data in low dimension space
dsd_newreturn = np.dot(dsd_lowreturn,dsd_eigenvectors.T) #normalized data in original space

#step 5 : reconstruct original data
ds_reconreturn = dsd_newreturn + ds_mean 


#outcome 
print('ds_eigenvalues',ds_eigenvalues)
print('ds_eigenvectors',ds_eigenvectors)
print('order choosen',dsd_eigenvaluesid)
print('biggest_ds_prop',biggest_ds_prop)



#plot
fig2 = plt.figure(3)
plt.subplot(311)
plt.plot(ds_orireturn,'o')
plt.title('Original Data')

plt.subplot(312)
plt.plot(dsd_lowreturn,'o')
plt.title('Reduce Dimensionality Data')

plt.subplot(313)
plt.plot(ds_reconreturn,'o')
plt.title('Reconstruct Original Data')
plt.show()

print(dsd_lowreturn)