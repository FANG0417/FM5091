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

        private void button1_Click(object sender, EventArgs e)
        {
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

            textBoxPrice.Text = Convert.ToString(Option.PandStd(S0, K, sigma, r, T, steps, N, type, R)[0]);
            textBoxStd.Text = Convert.ToString(Option.PandStd(S0, K, sigma, r, T, steps, N, type, R)[1]);
            textBoxDelta.Text = Convert.ToString(Greeks.Delta(S0, K, sigma, r, T, steps, N, type, R));
            textBoxGamma.Text = Convert.ToString(Greeks.Gamma(S0, K, sigma, r, T, steps, N, type, R));
            textBoxVega.Text = Convert.ToString(Greeks.Vega(S0, K, sigma, r, T, steps, N, type, R));
            textBoxTheta.Text = Convert.ToString(Greeks.Theta(S0, K, sigma, r, T, steps, N, type, R));
            textBoxRho.Text = Convert.ToString(Greeks.Rho(S0, K, sigma, r, T, steps, N, type, R));


        }

       
    }
}
