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
    public partial class InterestRateAnalysis : Form
    {
        public InterestRateAnalysis()
        {
            InitializeComponent();
            this.Load += new EventHandler(InterestRateAnalysis_Load);
        }
        private void InterestRateAnalysis_Load(object sender, EventArgs e)
        {
            //load interest rate
            dataGridView1.Rows.Clear();
            Model1Container db = new Model1Container();
            var query = from i in db.InterestRateSet select i;
            foreach (InterestRate rate in query)
                dataGridView1.Rows.Add(rate.Tenor, rate.Rate * 100);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
