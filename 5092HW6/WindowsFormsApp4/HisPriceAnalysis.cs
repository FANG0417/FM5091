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
    public partial class HisPriceAnalysis : Form
    {
        public HisPriceAnalysis()
        {
            InitializeComponent();
            this.Load += new EventHandler(HisPriceAnalysis_Load);
        }                   

        private void HisPriceAnalysis_Load(object sender, EventArgs e)
        {
            //load ticker first
            Model1Container db = new Model1Container();
            foreach (var query in (from i in db.InstrumentSet select i))
                comboBox_Instrument.Items.Add(query.Ticker);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load listview
            dataGridView1.Rows.Clear();
            Model1Container db = new Model1Container();
            var query = from i in db.PriceSet where i.Instrument.Ticker == comboBox_Instrument.Text select i;
            foreach (Price price in query)
                dataGridView1.Rows.Add(price.Date.ToShortDateString(), price.ClosingPrice);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
