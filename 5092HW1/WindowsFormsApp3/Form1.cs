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
            //Define the inputs
            double S0 = Convert.ToDouble(textBoxS0.Text);
            double K = Convert.ToDouble(textBoxK.Text);
            double T = Convert.ToDouble(textBoxT.Text);
            double r = Convert.ToDouble(textBoxr.Text);
            double sigma = Convert.ToDouble(textBoxsigma.Text);
            int N = Convert.ToInt32(textBoxN.Text);
            int steps = Convert.ToInt32(textBoxsteps.Text);
            bool type;
            if (textBoxtype.Text == "true")
                type = true;
            else
                type = false;
            double[,] R = RandomNumber.RandCreator.Rand(N, steps);

            //Outputs
            textBoxPrice.Text = Convert.ToString(Option.PandStd(S0, K, sigma, r, T, steps, N, type, R)[0]);
            textBoxStd.Text = Convert.ToString(Option.PandStd(S0, K, sigma, r, T, steps, N, type, R)[1]);
            textBoxDelta.Text = Convert.ToString(Greeks.Delta(S0, K, sigma, r, T, steps, N, type, R));
            textBoxGamma.Text = Convert.ToString(Greeks.Gamma(S0, K, sigma, r, T, steps, N, type, R));
            textBoxVega.Text = Convert.ToString(Greeks.Vega(S0, K, sigma, r, T, steps, N, type, R));
            textBoxTheta.Text = Convert.ToString(Greeks.Theta(S0, K, sigma, r, T, steps, N, type, R));
            textBoxRho.Text = Convert.ToString(Greeks.Rho(S0, K, sigma, r, T, steps, N, type, R));


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
    }
}
