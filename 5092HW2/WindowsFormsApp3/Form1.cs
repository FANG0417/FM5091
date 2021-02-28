using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The main body
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime beforDT = System.DateTime.Now;  //开始监视代码运行时间

            //create objects
            RandomNumber randomnumber = new RandomNumber();
            Value value = new Value();
            Price price = new Price();
            Greeks greeks = new Greeks();

            //Define the inputs
            value.S = Convert.ToDouble(textBoxS0.Text);
            value.K = Convert.ToDouble(textBoxK.Text);
            value.T = Convert.ToDouble(textBoxT.Text);
            value.R = Convert.ToDouble(textBoxr.Text);
            value.Sigma = Convert.ToDouble(textBoxsigma.Text);
            value.Trials = Convert.ToInt32(textBoxN.Text);
            value.N = Convert.ToInt32(textBoxsteps.Text);

            if (call.Checked)
            {
                value.Type = true;
            }                
            else if (put.Checked)
            {
                value.Type = false;
            }
            else
            {
                MessageBox.Show("Please select either call or put");
                return;
            }

            if (normal.Checked)
            {
                value.An = false;
            }
            else if (antithetic.Checked)
            {
                value.An = true;
            }
            else
            {
                MessageBox.Show("Please select method");
                return;
            }

            double[,] Rn = randomnumber.Rand(value.Trials, value.N);
            value.Rn = Rn;

            //Outputs
            textBoxPrice.Text = Convert.ToString(price.Oprice(value)[0]);
            textBoxStd.Text = Convert.ToString(price.Oprice(value)[1]);
            textBoxDelta.Text = Convert.ToString(greeks.Delta(value));
            textBoxGamma.Text = Convert.ToString(greeks.Gamma(value));
            textBoxVega.Text = Convert.ToString(greeks.Vega(value));
            textBoxTheta.Text = Convert.ToString(greeks.Theta(value));
            textBoxRho.Text = Convert.ToString(greeks.Rho(value));

            DateTime afterDT = System.DateTime.Now;  //停止监视
            //从afterDT中减去beforDT的时间
            TimeSpan ts = afterDT.Subtract(beforDT);
            textBoxTime.Text = Convert.ToString(ts);

        }

        private void textBoxS0_TextChanged(object sender, EventArgs e)
        {
            double o;
            if (!double.TryParse(textBoxS0.Text, out o))
            {
                textBoxS0.BackColor = Color.Pink;
                button1.Enabled = false;
            }
            else
            {
                textBoxS0.BackColor = Color.White;
                button1.Enabled = true;
            }
        }
        //Some error settings
        private void textBoxK_TextChanged(object sender, EventArgs e)
        {
            double o;
            if (!double.TryParse(textBoxK.Text, out o))
            {
                textBoxK.BackColor = Color.Pink;
                button1.Enabled = false;
            }
            else
            {
                textBoxK.BackColor = Color.White;
                button1.Enabled = true;
            }
        }

        private void textBoxT_TextChanged(object sender, EventArgs e)
        {
            double o;
            if (!double.TryParse(textBoxT.Text, out o))
            {
                textBoxT.BackColor = Color.Pink;
                button1.Enabled = false;
            }
            else
            {
                textBoxT.BackColor = Color.White;
                button1.Enabled = true;
            }
        }

        private void textBoxr_TextChanged(object sender, EventArgs e)
        {
            double o;
            if (!double.TryParse(textBoxr.Text, out o))
            {
                textBoxr.BackColor = Color.Pink;
                button1.Enabled = false;
            }
            else
            {
                textBoxr.BackColor = Color.White;
                button1.Enabled = true;
            }
        }

        private void textBoxsigma_TextChanged(object sender, EventArgs e)
        {
            double o;
            if (!double.TryParse(textBoxsigma.Text, out o))
            {
                textBoxsigma.BackColor = Color.Pink;
                button1.Enabled = false;
            }
            else
            {
                textBoxsigma.BackColor = Color.White;
                button1.Enabled = true;
            }
        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {
            int o;
            if (!int.TryParse(textBoxN.Text, out o))
            {
                textBoxN.BackColor = Color.Pink;
                button1.Enabled = false;
            }
            else
            {
                textBoxN.BackColor = Color.White;
                button1.Enabled = true;
            }
        }

        private void textBoxsteps_TextChanged(object sender, EventArgs e)
        {
            int o;
            if (!int.TryParse(textBoxsteps.Text, out o))
            {
                textBoxsteps.BackColor = Color.Pink;
                button1.Enabled = false;
            }
            else
            {
                textBoxsteps.BackColor = Color.White;
                button1.Enabled = true;
            }
        }

        private void textBoxTheta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRho_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void call_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void put_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void normal_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
