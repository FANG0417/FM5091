import quandl
import pyodbc
import pandas as pd
import os


def get_name_id(ticker):
    conn = pyodbc.connect('Driver={SQL Server};' 'Server=DESKTOP-SDBL0O9;' 'Database=FM;' 'Trusted_Connection=yes;')
    cursor = conn.cursor()


    cursor.execute("select ID from [FM].[FM].[Instrument] where StockTicker='" + ticker + "'")
    return cursor.fetchone()[0]

def add_timeseries_from_csv(ticker,filepath):
    tickerid = get_name_id(ticker)
    conn = pyodbc.connect('Driver={SQL Server};' 'Server=DESKTOP-SDBL0O9;' 'Database=FM;' 'Trusted_Connection=yes;')
    cursor = conn.cursor()
    # df = getdata(ticker)
    df = pd.read_csv(filepath)
    for i in range(len(df)):
        cursor.execute("insert into [FM].[FM].[Price] values ('"+ str(tickerid) +"',CONVERT(DATETIME,'"+ str(df.iloc[i]['Date'])+"',102),'"+ str(df.iloc[i]['Open']) +"','" +str(df.iloc[i]['High']) +"','" + str(df.iloc[i]['Low']) + "','" + str(df.iloc[i]['Close']) +"','" + str(int(df.iloc[i]['Volume'])) + "')")
        conn.commit()


add_timeseries_from_csv('GOOG',"C:/Users/54571/Desktop/fmcs/hw4/GOOG.csv")
add_timeseries_from_csv('MSFT',"C:/Users/54571/Desktop/fmcs/hw4/MSFT.csv")
add_timeseries_from_csv('AAPL',"C:/Users/54571/Desktop/fmcs/hw4/AAPL.csv")
add_timeseries_from_csv('AMZN',"C:/Users/54571/Desktop/fmcs/hw4/AMZN.csv")
add_timeseries_from_csv('GE',"C:/Users/54571/Desktop/fmcs/hw4/GE.csv")
add_timeseries_from_csv('KO',"C:/Users/54571/Desktop/fmcs/hw4/KO.csv")
add_timeseries_from_csv('VLO',"C:/Users/54571/Desktop/fmcs/hw4/VLO.csv")