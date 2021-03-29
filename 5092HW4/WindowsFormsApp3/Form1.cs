using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            label_pro.Text = "Input";

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

            if (CV.Checked)
            {
                value.CV = true;
            }
            else
            {
                value.CV = false;
            }
            if (CVNO.Checked)
            {
                value.CV = false;
            }
            else
            {
                value.CV = true;
            }

            if (MT.Checked)
            {
                value.MT = true;
            }
            else
            {
                value.MT = false;
            }

            if (Nouse.Checked)
            {
                value.MT = false;
            }
            else
            {
                value.MT = true;
            }

            label_pro.Text = "Reading Your Data";
            inprogress(10);

            double[,] Rn = randomnumber.Rand(value.Trials, value.N, value.MT);
            value.Rn = Rn;

            label_pro.Text = "Creating Random Number Array";
            inprogress(20);

            //Outputs
            textBoxPrice.Text = Convert.ToString(price.Oprice(value)[0]);
            label_pro.Text = "Calculate Price";
            inprogress(30);

            textBoxStd.Text = Convert.ToString(price.Oprice(value)[1]);
            label_pro.Text = "Calculate Std";
            inprogress(40);

            textBoxDelta.Text = Convert.ToString(greeks.Delta(value));
            label_pro.Text = "Calculate Delta";
            inprogress(50);

            textBoxGamma.Text = Convert.ToString(greeks.Gamma(value));
            label_pro.Text = "Calculate Gamma";
            inprogress(60);

            textBoxVega.Text = Convert.ToString(greeks.Vega(value));
            label_pro.Text = "Calculate Vega";
            inprogress(70);

            textBoxTheta.Text = Convert.ToString(greeks.Theta(value));
            label_pro.Text = "Calculate Theta";
            inprogress(80);

            textBoxRho.Text = Convert.ToString(greeks.Rho(value));
            label_pro.Text = "Calculate Rho";
            inprogress(90);

            DateTime afterDT = System.DateTime.Now;  //停止监视
            //从afterDT中减去beforDT的时间
            TimeSpan ts = afterDT.Subtract(beforDT);
            textBoxTime.Text = Convert.ToString(ts);
            label_pro.Text = "Calculate Time";
            inprogress(100);

            int core_num;
            if (value.MT == true)
            {
                core_num = System.Environment.ProcessorCount;
            }
            else
            {
                core_num = 1;
            }
            TextBoxCore.Text = Convert.ToString(core_num);

        }

        public void inprogress(int i)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action<int>(inprogress), new object[] { i });
                return;
            }
            progressBar1.Value = i;
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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
