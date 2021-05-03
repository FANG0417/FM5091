using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class New_Trade : Form
    {
        public New_Trade()
        {
            InitializeComponent();
            this.Load += new EventHandler(New_Trade_Load);
        }
        private void New_Trade_Load(object sender, EventArgs e)
        {
            //load ticker first
            Model1Container db = new Model1Container();
            foreach (var query in (from i in db.InstrumentSet select i))
                comboBox_Instrument.Items.Add(query.Ticker);
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            //add trade
            Model1Container db = new Model1Container();
            if (textBox_Quantity.Text == String.Empty || textBox_Price.Text == String.Empty || comboBox_Instrument.Text == String.Empty)
                MessageBox.Show("You don't input all values");
            else
            {                
                db.TradeSet.Add(new Trade()
                {
                    IsBuy = radioButton_Buy.Checked,
                    Quantity = Convert.ToDouble(textBox_Quantity.Text),
                    Price = Convert.ToDouble(textBox_Price.Text),
                    Timestamp = DateTime.Now,
                    Instrument = db.InstrumentSet.FirstOrDefault(x => x.Ticker == comboBox_Instrument.Text)
                });
                db.SaveChanges();
                MessageBox.Show("Add trade successfully!");
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
