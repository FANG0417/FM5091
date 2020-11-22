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

print(np.shape(return1_1))