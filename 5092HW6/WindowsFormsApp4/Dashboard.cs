using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace WindowsFormsApp4
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.Load += new EventHandler(Dashboard_Load);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //First load: add colunm when open form
            listView_Totals.Columns.Add("Total P&L", 90);
            listView_Totals.Columns.Add("Total Delta", 100);
            listView_Totals.Columns.Add("Total Gamma", 100);
            listView_Totals.Columns.Add("Total Vega", 100);
            listView_Totals.Columns.Add("Total Theta", 100);
            listView_Totals.Columns.Add("Total Rho", 100);

            listView_AllTrades.Columns.Add("ID", 40);
            listView_AllTrades.Columns.Add("Diection", 80);
            listView_AllTrades.Columns.Add("Quantity", 80);
            listView_AllTrades.Columns.Add("Instrument", 100);
            listView_AllTrades.Columns.Add("Inst type", 90);
            listView_AllTrades.Columns.Add("Trade price", 100);
            listView_AllTrades.Columns.Add("Market price", 110);
            listView_AllTrades.Columns.Add("P&L", 50);
            listView_AllTrades.Columns.Add("Delta", 60);
            listView_AllTrades.Columns.Add("Gamma", 60);
            listView_AllTrades.Columns.Add("Vega", 60);
            listView_AllTrades.Columns.Add("Theta", 70);
            listView_AllTrades.Columns.Add("Rho", 60);
        }


        // basic settings
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_PriceVol_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView_Totals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void instrumenttypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_InstType new_InstType = new New_InstType();
            new_InstType.ShowDialog();
        }

        private void instrumentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            New_Inst new_Inst = new New_Inst();
            new_Inst.ShowDialog();
        }

        private void tradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Trade new_Trade = new New_Trade();
            new_Trade.ShowDialog();
        }

        private void interestRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_InterestRate new_InterestRate = new New_InterestRate();
            new_InterestRate.ShowDialog();
        }

        private void historicalPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_HisPrice new_HisPrice = new New_HisPrice();
            new_HisPrice.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void historicalPriceAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HisPriceAnalysis hisPriceAnalysis = new HisPriceAnalysis();
            hisPriceAnalysis.ShowDialog();
        }

        private void interestRateAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterestRateAnalysis interestRateAnalysis = new InterestRateAnalysis();
            interestRateAnalysis.ShowDialog();
        }

        private void generateDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateData generateData = new GenerateData();
            generateData.ShowDialog();
        }

        private void listView_AllTrades_SelectedIndexChanged(object sender, EventArgs e)
        {       
            //make trade data shown in totals

            //collect data
            double PL = 0, Delta = 0, Gamma = 0, Vega = 0, Theta = 0, Rho = 0;
            foreach (ListViewItem i in listView_AllTrades.SelectedItems)
            {
                if (i.SubItems.Count > 7)
                {
                    PL = PL + Convert.ToDouble(i.SubItems[7].Text);
                    Delta = Delta + Convert.ToDouble(i.SubItems[8].Text);
                    Gamma = Gamma + Convert.ToDouble(i.SubItems[9].Text);
                    Vega = Vega + Convert.ToDouble(i.SubItems[10].Text);
                    Theta = Theta + Convert.ToDouble(i.SubItems[11].Text);
                    Rho = Rho + Convert.ToDouble(i.SubItems[12].Text);
                }
            }

            //shown in listview_Totals
            ListViewItem listViewItem = new ListViewItem(Convert.ToString(PL));
            listViewItem.SubItems.Add(Convert.ToString(Delta));
            listViewItem.SubItems.Add(Convert.ToString(Gamma));
            listViewItem.SubItems.Add(Convert.ToString(Vega));
            listViewItem.SubItems.Add(Convert.ToString(Theta));
            listViewItem.SubItems.Add(Convert.ToString(Rho));
            listView_Totals.BeginUpdate();
            listView_Totals.Items.Clear();
            listView_Totals.Items.Add(listViewItem);
            listView_Totals.EndUpdate();
        }
        private void refreshTradesFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //make data shown in all_trades
            Model1Container db = new Model1Container();
            listView_AllTrades.Items.Clear();
            ListViewItem listViewItem;
            foreach (Trade i in db.TradeSet)
            {
                //id
                listViewItem = new ListViewItem(Convert.ToString(i.Id));               
                //direction
                if (i.IsBuy)
                    listViewItem.SubItems.Add("BUY");
                else
                    listViewItem.SubItems.Add("SELL");
                //quantity
                listViewItem.SubItems.Add(Convert.ToString(i.Quantity));
                //instrument
                listViewItem.SubItems.Add(i.Instrument.Ticker);
                //intrument type
                listViewItem.SubItems.Add(i.Instrument.InstType.TypeName);
                //trade price
                listViewItem.SubItems.Add(Convert.ToString(i.Price));
                listView_AllTrades.Items.Add(listViewItem);
            }
        }

        private void priceBookFromSimulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model1Container db = new Model1Container();
            
            //refresh listview
            listView_AllTrades.BeginUpdate();

            foreach (ListViewItem listView in listView_AllTrades.Items)
            {
                //According selected id in listview to find trade
                int id = Convert.ToInt32(listView.SubItems[0].Text);
                Trade trade = db.TradeSet.SingleOrDefault(x => x.Id == id);

                //Get values in this trade
                double direction;
                if (trade.IsBuy == true)
                    direction = 1;
                else
                    direction = -1;
                double quantity = trade.Quantity;
                double marketprice = trade.Price;

                //Price product

                //Stock
                if (trade.Instrument.InstType.TypeName == "Stock")
                {
                    //Market Price
                    double s = trade.Instrument.Price.OrderByDescending(x => x.Date).First().ClosingPrice;
                    listView.SubItems.Add(Convert.ToString(s));
                    //P&L
                    listView.SubItems.Add(((s - marketprice) * direction * quantity).ToString());
                    //Delta
                    listView.SubItems.Add(Convert.ToString(direction * quantity));
                    //Gamma
                    listView.SubItems.Add(Convert.ToString(0));
                    //Vega
                    listView.SubItems.Add(Convert.ToString(0));
                    //Rho
                    listView.SubItems.Add(Convert.ToString(0));
                    //Theta
                    listView.SubItems.Add(Convert.ToString(0));
                }
                else
                {
                    //Option

                    Value value = new Value(); //Basic values about Options
                    value = GetValue(trade);

                    //European Option
                    if (trade.Instrument.InstType.TypeName == "EuropeanOption")
                    {
                        WindowsFormsApp3.European european = new WindowsFormsApp3.European();
                        //Market Price                   
                        listView.SubItems.Add(Convert.ToString(european.OptionPrice(value)[0]));
                        //P&L
                        listView.SubItems.Add(((european.OptionPrice(value)[0] - marketprice) * direction * quantity).ToString());
                        //Delta
                        listView.SubItems.Add(Convert.ToString(direction * quantity * european.Delta(value)));
                        //Gamma
                        listView.SubItems.Add(Convert.ToString(direction * quantity * european.Gamma(value)));
                        //Vega
                        listView.SubItems.Add(Convert.ToString(direction * quantity * european.Vega(value)));
                        //Rho
                        listView.SubItems.Add(Convert.ToString(direction * quantity * european.Rho(value)));
                        //Theta
                        listView.SubItems.Add(Convert.ToString(direction * quantity * european.Theta(value)));
                    }
                    

                    //Asian Option
                    if (trade.Instrument.InstType.TypeName == "AsianOption")
                    {
                        WindowsFormsApp3.Asian asian = new WindowsFormsApp3.Asian();
                        //Market Price                   
                        listView.SubItems.Add(Convert.ToString(asian.OptionPrice(value)[0]));
                        //P&L
                        listView.SubItems.Add(((asian.OptionPrice(value)[0] - marketprice) * direction * quantity).ToString());
                        //Delta
                        listView.SubItems.Add(Convert.ToString(direction * quantity * asian.Delta(value)));
                        //Gamma
                        listView.SubItems.Add(Convert.ToString(direction * quantity * asian.Gamma(value)));
                        //Vega
                        listView.SubItems.Add(Convert.ToString(direction * quantity * asian.Vega(value)));
                        //Rho
                        listView.SubItems.Add(Convert.ToString(direction * quantity * asian.Rho(value)));
                        //Theta
                        listView.SubItems.Add(Convert.ToString(direction * quantity * asian.Theta(value)));
                    }

                    //Lookback Option
                    if (trade.Instrument.InstType.TypeName == "LookbackOption")
                    {
                        WindowsFormsApp3.Lookback lookback = new WindowsFormsApp3.Lookback();
                        //Market Price                   
                        listView.SubItems.Add(Convert.ToString(lookback.OptionPrice(value)[0]));
                        //P&L
                        listView.SubItems.Add(((lookback.OptionPrice(value)[0] - marketprice) * direction * quantity).ToString());
                        //Delta
                        listView.SubItems.Add(Convert.ToString(direction * quantity * lookback.Delta(value)));
                        //Gamma
                        listView.SubItems.Add(Convert.ToString(direction * quantity * lookback.Gamma(value)));
                        //Vega
                        listView.SubItems.Add(Convert.ToString(direction * quantity * lookback.Vega(value)));
                        //Rho
                        listView.SubItems.Add(Convert.ToString(direction * quantity * lookback.Rho(value)));
                        //Theta
                        listView.SubItems.Add(Convert.ToString(direction * quantity * lookback.Theta(value)));
                    }

                    //Digital Option
                    if (trade.Instrument.InstType.TypeName == "DigitalOption")
                    {
                        WindowsFormsApp3.Digital digital = new WindowsFormsApp3.Digital();
                        //Market Price                   
                        listView.SubItems.Add(Convert.ToString(digital.OptionPrice(value)[0]));
                        //P&L
                        listView.SubItems.Add(((digital.OptionPrice(value)[0] - marketprice) * direction * quantity).ToString());
                        //Delta
                        listView.SubItems.Add(Convert.ToString(direction * quantity * digital.Delta(value)));
                        //Gamma
                        listView.SubItems.Add(Convert.ToString(direction * quantity * digital.Gamma(value)));
                        //Vega
                        listView.SubItems.Add(Convert.ToString(direction * quantity * digital.Vega(value)));
                        //Rho
                        listView.SubItems.Add(Convert.ToString(direction * quantity * digital.Rho(value)));
                        //Theta
                        listView.SubItems.Add(Convert.ToString(direction * quantity * digital.Theta(value)));
                    }

                    //Range Option
                    if (trade.Instrument.InstType.TypeName == "RangeOption")
                    {
                        WindowsFormsApp3.Range range = new WindowsFormsApp3.Range();
                        //Market Price                   
                        listView.SubItems.Add(Convert.ToString(range.OptionPrice(value)[0]));
                        //P&L
                        listView.SubItems.Add(((range.OptionPrice(value)[0] - marketprice) * direction * quantity).ToString());
                        //Delta
                        listView.SubItems.Add(Convert.ToString(direction * quantity * range.Delta(value)));
                        //Gamma
                        listView.SubItems.Add(Convert.ToString(direction * quantity * range.Gamma(value)));
                        //Vega
                        listView.SubItems.Add(Convert.ToString(direction * quantity * range.Vega(value)));
                        //Rho
                        listView.SubItems.Add(Convert.ToString(direction * quantity * range.Rho(value)));
                        //Theta
                        listView.SubItems.Add(Convert.ToString(direction * quantity * range.Theta(value)));
                    }

                    //Barrier Option
                    if (trade.Instrument.InstType.TypeName == "BarrierOption")
                    {
                        WindowsFormsApp3.Barrier barrier = new WindowsFormsApp3.Barrier();
                        //Market Price                   
                        listView.SubItems.Add(Convert.ToString(barrier.OptionPrice(value)[0]));
                        //P&L
                        listView.SubItems.Add(((barrier.OptionPrice(value)[0] - marketprice) * direction * quantity).ToString());
                        //Delta
                        listView.SubItems.Add(Convert.ToString(direction * quantity * barrier.Delta(value)));
                        //Gamma
                        listView.SubItems.Add(Convert.ToString(direction * quantity * barrier.Gamma(value)));
                        //Vega
                        listView.SubItems.Add(Convert.ToString(direction * quantity * barrier.Vega(value)));
                        //Rho
                        listView.SubItems.Add(Convert.ToString(direction * quantity * barrier.Rho(value)));
                        //Theta
                        listView.SubItems.Add(Convert.ToString(direction * quantity * barrier.Theta(value)));
                    }
                }                               
            }

            listView_AllTrades.EndUpdate();
            MessageBox.Show("Price succussfully");


        }
        
        public Value GetValue(Trade trade)
        {
            Model1Container db = new Model1Container();
            Value value = new Value();

            //S            
            value.S = db.InstrumentSet.SingleOrDefault(x => x.Ticker == trade.Instrument.Underlying).Price.OrderByDescending(x => x.Date).First().ClosingPrice;

            //K
            value.K = Convert.ToDouble(trade.Instrument.Strike);

            //R
            value.R = db.InterestRateSet.SingleOrDefault(x => x.Tenor == trade.Instrument.Tenor).Rate;

            //Sigma
            value.Sigma = Convert.ToDouble(textBox_PriceVol.Text) / 100;

            //T  
            value.T = Convert.ToDouble(trade.Instrument.Tenor);

            //Trials
            value.Trials = 10000;

            //Steps
            value.N = 100;

            //Type(call or put)
            if (trade.Instrument.IsCall == true)
                value.Type = true;
            else
                value.Type = false;

            //RandomNumber
            RandomNumber randomnumber = new RandomNumber();
            double[,] Rn = randomnumber.Rand(value.Trials, value.N, value.MT);
            value.Rn = Rn;

            //An
            value.An = false;

            //CV
            value.CV = false;

            //MT
            value.MT = false;

            //Rebate
            if (Convert.ToString(trade.Instrument.Rebate) == "NULL")
                value.Rb = 0;
            else
                value.Rb = Convert.ToDouble(trade.Instrument.Rebate);

            //Barrier
            if (Convert.ToString(trade.Instrument.BarrierType) == "NULL")
                value.Br = 0;
            else
                value.Br = Convert.ToDouble(trade.Instrument.Barrier);

            //Barrier Type
            if (trade.Instrument.BarrierType == "NULL")
                value.Bt = 0;
            if (trade.Instrument.BarrierType == "Down and out")
                value.Bt = 1;
            if (trade.Instrument.BarrierType == "Up and out")
                value.Bt = 2;
            if (trade.Instrument.BarrierType == "Down and in")
                value.Bt = 3;
            if (trade.Instrument.BarrierType == "Up and in")
                value.Bt = 4;

            return value;            
        }

        private void menuStrip1_ItemClicked(object sender, EventArgs e)
        {
                        
        }

        private void selectedTradeDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //delete button
            Model1Container db = new Model1Container();

            foreach (ListViewItem i in listView_AllTrades.SelectedItems)
            {
                listView_AllTrades.Items.Remove(i);
                db.TradeSet.Remove((from j in db.TradeSet where j.Id.ToString() == i.Text select j).FirstOrDefault());
                db.SaveChanges();
            }
        }
    }
}
