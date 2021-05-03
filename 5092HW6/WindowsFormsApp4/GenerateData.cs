using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class GenerateData : Form
    {
        public GenerateData()
        {
            InitializeComponent();
            MessageBox.Show("Please add stock first and then add option");
        }

        private void button_Go_Click(object sender, EventArgs e)
        {
            Model1Container db = new Model1Container();

            //InstTypeSet
            db.InstTypeSet.Add(new InstType()
            {
                TypeName = "Stock"
            });
            db.InstTypeSet.Add(new InstType()
            {
                TypeName = "EuropeanOption"
            });
            db.InstTypeSet.Add(new InstType()
            {
                TypeName = "AsianOption"
            });
            db.InstTypeSet.Add(new InstType()
            {
                TypeName = "LookbackOption"
            });
            db.InstTypeSet.Add(new InstType()
            {
                TypeName = "DigitalOption"
            });
            db.InstTypeSet.Add(new InstType()
            {
                TypeName = "RangeOption"
            });
            db.InstTypeSet.Add(new InstType()
            {
                TypeName = "BarrierOption"
            });

            //Interest Rate
            db.InterestRateSet.Add(new InterestRate()
            {
                Tenor = 0.5,
                Rate = 0.04
            });
            db.InterestRateSet.Add(new InterestRate()
            {
                Tenor = 1,
                Rate = 0.05
            });
            db.InterestRateSet.Add(new InterestRate()
            {
                Tenor = 1.5,
                Rate = 0.06
            });
            db.InterestRateSet.Add(new InterestRate()
            {
                Tenor = 2,
                Rate = 0.07
            });
            db.InterestRateSet.Add(new InterestRate()
            {
                Tenor = 2.5,
                Rate = 0.08
            });
            db.InterestRateSet.Add(new InterestRate()
            {
                Tenor = 3,
                Rate = 0.09
            });

            //Instrument
            db.InstrumentSet.Add(new Instrument()
            {
                CompanyName = "OPM Company",
                Ticker = "OPMSK",
                Exchange = "NASDAQ",
                InstTypeId = 1
            });

            //Trade
            db.TradeSet.Add(new Trade()
            {
                IsBuy = true,
                Quantity = 100,
                Price = 50,
                Timestamp = System.DateTime.Now,
                InstrumentId = 1
            });

            //Historical Price
            db.PriceSet.Add(new Price()
            {
                Date = System.DateTime.Today,
                ClosingPrice = 50,
                InstrumentId = 1
            });

            db.SaveChanges();

            MessageBox.Show("Add stock data to SQL successfully!");
        }

        private void button_GoOption_Click(object sender, EventArgs e)
        {
            Model1Container db = new Model1Container();

            //European Option
            //Instrument
            db.InstrumentSet.Add(new Instrument()
            {
                CompanyName = "OPM Company",
                Ticker = "OPMEO",
                Exchange = "NASDAQ",
                Underlying = "OPMSK",
                Strike = 50,
                Tenor = 1,
                IsCall = true,
                InstTypeId = 2
            });

            //Trade
            db.TradeSet.Add(new Trade()
            {
                IsBuy = true,
                Quantity = 100,
                Price = 12,
                Timestamp = System.DateTime.Now,
                InstrumentId = 2
            });


            //Asian Option
            //Instrument
            db.InstrumentSet.Add(new Instrument()
            {
                CompanyName = "OPM Company",
                Ticker = "OPMAO",
                Exchange = "NASDAQ",
                Underlying = "OPMSK",
                Strike = 50,
                Tenor = 1,
                IsCall = true,
                InstTypeId = 3
            });

            //Trade
            db.TradeSet.Add(new Trade()
            {
                IsBuy = true,
                Quantity = 100,
                Price = 6,
                Timestamp = System.DateTime.Now,
                InstrumentId = 3
            });


            //Lookback Option
            //Instrument
            db.InstrumentSet.Add(new Instrument()
            {
                CompanyName = "OPM Company",
                Ticker = "OPMLO",
                Exchange = "NASDAQ",
                Underlying = "OPMSK",
                Strike = 50,
                Tenor = 1,
                IsCall = true,
                InstTypeId = 4
            });

            //Trade
            db.TradeSet.Add(new Trade()
            {
                IsBuy = true,
                Quantity = 100,
                Price = 21,
                Timestamp = System.DateTime.Now,
                InstrumentId = 4
            });

            //Digital Option
            //Instrument
            db.InstrumentSet.Add(new Instrument()
            {
                CompanyName = "OPM Company",
                Ticker = "OPMDO",
                Exchange = "NASDAQ",
                Underlying = "OPMSK",
                Strike = 50,
                Tenor = 1,
                IsCall = true,
                Rebate = 5,
                InstTypeId = 5
            });

            //Trade
            db.TradeSet.Add(new Trade()
            {
                IsBuy = true,
                Quantity = 100,
                Price = 3,
                Timestamp = System.DateTime.Now,
                InstrumentId = 5
            });


            //Range Option
            //Instrument
            db.InstrumentSet.Add(new Instrument()
            {
                CompanyName = "OPM Company",
                Ticker = "OPMRO",
                Exchange = "NASDAQ",
                Underlying = "OPMSK",
                Strike = 50,
                Tenor = 1,
                IsCall = true,
                InstTypeId = 6
            });

            //Trade
            db.TradeSet.Add(new Trade()
            {
                IsBuy = true,
                Quantity = 100,
                Price = 35,
                Timestamp = System.DateTime.Now,
                InstrumentId = 6
            });

            //Barrier Option
            //Instrument
            db.InstrumentSet.Add(new Instrument()
            {
                CompanyName = "OPM Company",
                Ticker = "OPMBO",
                Exchange = "NASDAQ",
                Underlying = "OPMSK",
                Strike = 50,
                Tenor = 1,
                IsCall = true,
                Barrier = 40,
                BarrierType = "Down and out",
                InstTypeId = 7
            });

            //Trade
            db.TradeSet.Add(new Trade()
            {
                IsBuy = true,
                Quantity = 100,
                Price = 9,
                Timestamp = System.DateTime.Now,
                InstrumentId = 7
            });

            db.SaveChanges();

            MessageBox.Show("Add option data to SQL successfully!");
        }
    }
}    
    
