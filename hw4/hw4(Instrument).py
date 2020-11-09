import pyodbc

def add_name(company, ticker, market, sector): 
    conn = pyodbc.connect('Driver={SQL Server};' 'Server=DESKTOP-SDBL0O9;' 'Database=FM;' 'Trusted_Connection=yes;')
    cursor = conn.cursor()
    cursor.execute("insert into [FM].[FM].[Instrument] values ('" + company + "','" + ticker + "','" + market + "','" + sector + "')") 
    conn.commit()

add_name('Alphabet','GOOG','NASDAQ','Technology')
add_name('Microsoft','MSFT','NASDAQ','Technology')
add_name('Apple','AAPL','NASDAQ','Technology')
add_name('Amazon','AMZN ','NASDAQ','Technology')
add_name('General Electric','GE','NYSE','Industrial Goods')
add_name('Coca-Cola','KO','NYSE','Consumer Goods')
add_name('Valero Energy','VLO','NYSE','Basic Materials')