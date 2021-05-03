using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class New_InterestRate : Form
    {
        public New_InterestRate()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Model1Container db = new Model1Container();
            double t = Convert.ToDouble(textBox_Tenor.Text);
            if (textBox_Tenor.Text == String.Empty || textBox_Rate.Text == String.Empty)
                MessageBox.Show("You don't input all values");
            else
            {
                if ((from i in db.InterestRateSet where i.Tenor ==  t select i).Count() != 0)
                    MessageBox.Show("This type have existed");
                else
                {
                    db.InterestRateSet.Add(new InterestRate() 
                    {
                        Tenor = Convert.ToDouble(textBox_Tenor.Text),
                        Rate = Convert.ToDouble(textBox_Rate.Text) / 100
                    });
                    MessageBox.Show("Add interest rate successfully!");
                }
                db.SaveChanges();
                
            }
                        
        }
    }
}
