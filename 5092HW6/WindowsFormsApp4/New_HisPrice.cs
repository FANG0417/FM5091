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
    public partial class New_HisPrice : Form
    {
        public New_HisPrice()
        {
            InitializeComponent();
            this.Load += new EventHandler(New_HisPrice_Load);
        }
        private void New_HisPrice_Load(object sender, EventArgs e)
        {
            //load ticker first
            Model1Container db = new Model1Container();
            foreach (var query in (from i in db.InstrumentSet select i))
                comboBox_Product.Items.Add(query.Ticker);
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            //add historical price
            Model1Container db = new Model1Container();
            if (comboBox_Product.Text == String.Empty || textBox_ClosingPrice.Text == String.Empty)
                MessageBox.Show("You don't input all values");
            else
            {
                db.PriceSet.Add(new Price()
                {
                    ClosingPrice = Convert.ToDouble(textBox_ClosingPrice.Text),
                    Date = DateTime.Now,
                    Instrument = db.InstrumentSet.FirstOrDefault(x => x.Ticker == comboBox_Product.Text)
                });
                db.SaveChanges();
                MessageBox.Show("Add historical price successfully!");
            }
        }
    }
}
