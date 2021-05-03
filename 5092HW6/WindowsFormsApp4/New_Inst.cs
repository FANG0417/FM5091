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
    public partial class New_Inst : Form
    {
        public New_Inst()
        {
            InitializeComponent();
            this.Load += new EventHandler(New_Inst_Load);
        }
        private void New_Inst_Load(object sender, EventArgs e)
        {
            //load underlying first
            Model1Container db = new Model1Container();
            foreach (var query in (from i in db.InstrumentSet where i.InstType.TypeName == "Stock" select i))
                comboBox_Underlying.Items.Add(query.Ticker);
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            //add instrument
            Model1Container db = new Model1Container();
            if (textBox_CompanyName.Text == String.Empty || textBox_Ticker.Text == String.Empty || textBox_Exchange.Text == String.Empty)
                MessageBox.Show("You don't input all values");
            else
            {
                //add stock
                if (comboBox_InstType.Text == "Stock")
                {
                    db.InstrumentSet.Add(new Instrument()
                    {
                        CompanyName = textBox_CompanyName.Text,
                        Ticker = textBox_Ticker.Text,
                        Exchange = textBox_Exchange.Text,
                        InstType = db.InstTypeSet.FirstOrDefault(x => x.TypeName == "Stock")
                    });
                    MessageBox.Show("Add Stock successfully!");
                }
                //add digital option
                else if (comboBox_InstType.Text == "DigitalOption")
                {
                    db.InstrumentSet.Add(new Instrument()
                    {
                        CompanyName = textBox_CompanyName.Text,
                        Ticker = textBox_Ticker.Text,
                        Exchange = textBox_Exchange.Text,
                        Underlying = comboBox_Underlying.Text,
                        Strike = Convert.ToDouble(textBox_Strike.Text),
                        Tenor = Convert.ToDouble(textBox_Tenor.Text),
                        IsCall = radioButton_Call.Checked,
                        Rebate = Convert.ToDouble(textBox_Rebate.Text),
                        InstType = db.InstTypeSet.FirstOrDefault(x => x.TypeName == "DigitalOption")
                    });
                    MessageBox.Show("Add DigitalOption successfully!");
                }
                //add barrier option
                else if (comboBox_InstType.Text == "BarrierOption")
                {
                    db.InstrumentSet.Add(new Instrument()
                    {
                        CompanyName = textBox_CompanyName.Text,
                        Ticker = textBox_Ticker.Text,
                        Exchange = textBox_Exchange.Text,
                        Underlying = comboBox_Underlying.Text,
                        Strike = Convert.ToDouble(textBox_Strike.Text),
                        Tenor = Convert.ToDouble(textBox_Tenor.Text),
                        IsCall = radioButton_Call.Checked,
                        Barrier = Convert.ToDouble(textBox_Barrier.Text),
                        BarrierType = comboBox_BarrierType.Text,
                        InstType = db.InstTypeSet.FirstOrDefault(x => x.TypeName == "BarrierOption")
                    });
                    MessageBox.Show("Add BarrierOption successfully!");
                }
                //add other option
                else
                {
                    db.InstrumentSet.Add(new Instrument()
                    {
                        CompanyName = textBox_CompanyName.Text,
                        Ticker = textBox_Ticker.Text,
                        Exchange = textBox_Exchange.Text,
                        Underlying = comboBox_Underlying.Text,
                        Strike = Convert.ToDouble(textBox_Strike.Text),
                        Tenor = Convert.ToDouble(textBox_Tenor.Text),
                        IsCall = radioButton_Call.Checked,
                        InstType = db.InstTypeSet.FirstOrDefault(x => x.TypeName == comboBox_Underlying.Text)
                    });
                    MessageBox.Show("Add Option successfully!");
                }
            }            

            db.SaveChanges();
        }

        private void comboBox_Underlying_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
