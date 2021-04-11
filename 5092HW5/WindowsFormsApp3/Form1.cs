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

            calculation();

            DateTime afterDT = System.DateTime.Now;  //停止监视

            TimeSpan ts = afterDT.Subtract(beforDT);//从afterDT中减去beforDT的时间

            label_pro.Text = "Calculate Time";
            textBoxTime.Text = Convert.ToString(ts);
            inprogress(100);

            label_pro.Text = "もう　俺の妻になったぞ";
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

        public void calculation()
        {
            label_pro.Text = "Input";

            //create objects
            RandomNumber randomnumber = new RandomNumber();
            Value value = new Value();

            //Define the inputs
            value.S = Convert.ToDouble(textBoxS0.Text);
            value.K = Convert.ToDouble(textBoxK.Text);
            value.T = Convert.ToDouble(textBoxT.Text);
            value.R = Convert.ToDouble(textBoxr.Text);
            value.Sigma = Convert.ToDouble(textBoxsigma.Text);
            value.Trials = Convert.ToInt32(textBoxN.Text);
            value.N = Convert.ToInt32(textBoxsteps.Text);
            value.Type = Convert.ToBoolean(Radio_call.Checked);
            value.An = Convert.ToBoolean(checkBox_An.Checked);
            value.CV = Convert.ToBoolean(checkBox_CV.Checked);
            value.MT = Convert.ToBoolean(checkBox_MT.Checked);                  

            label_pro.Text = "Reading Your Data";
            inprogress(10);

            double[,] Rn = randomnumber.Rand(value.Trials, value.N, value.MT);
            value.Rn = Rn;

            label_pro.Text = "Creating Random Number Array";
            inprogress(20);

            //Outputs
            if (checkBox_European.Checked)
            {
                value.Rb = 0;
                value.Bt = 0;
                value.Br = 0;
                European european = new European();

                label_pro.Text = "Calculate Price";
                textBoxPrice.Text = Convert.ToString(european.OptionPrice(value)[0]);
                inprogress(30);

                label_pro.Text = "Calculate Std";
                textBoxStd.Text = Convert.ToString(european.OptionPrice(value)[1]);
                inprogress(40);

                label_pro.Text = "Calculate Delta";
                textBoxDelta.Text = Convert.ToString(european.Delta(value));
                inprogress(50);

                label_pro.Text = "Calculate Gamma";
                textBoxGamma.Text = Convert.ToString(european.Gamma(value));
                inprogress(60);

                label_pro.Text = "Calculate Vega";
                textBoxVega.Text = Convert.ToString(european.Vega(value));
                inprogress(70);

                label_pro.Text = "Calculate Theta";
                textBoxTheta.Text = Convert.ToString(european.Theta(value));
                inprogress(80);

                label_pro.Text = "Calculate Rho";
                textBoxRho.Text = Convert.ToString(european.Rho(value));
                inprogress(90);
            }
            if (checkBox_Asian.Checked)
            {
                value.Rb = 0;
                value.Bt = 0;
                value.Br = 0;
                Asian asian = new Asian();

                label_pro.Text = "Calculate Price";
                textBoxPrice.Text = Convert.ToString(asian.OptionPrice(value)[0]);                
                inprogress(30);

                label_pro.Text = "Calculate Std";
                textBoxStd.Text = Convert.ToString(asian.OptionPrice(value)[1]);                
                inprogress(40);

                label_pro.Text = "Calculate Delta";
                textBoxDelta.Text = Convert.ToString(asian.Delta(value));                
                inprogress(50);

                label_pro.Text = "Calculate Gamma";
                textBoxGamma.Text = Convert.ToString(asian.Gamma(value));
                inprogress(60);

                label_pro.Text = "Calculate Vega";
                textBoxVega.Text = Convert.ToString(asian.Vega(value));                
                inprogress(70);

                label_pro.Text = "Calculate Theta";
                textBoxTheta.Text = Convert.ToString(asian.Theta(value));                
                inprogress(80);

                label_pro.Text = "Calculate Rho";
                textBoxRho.Text = Convert.ToString(asian.Rho(value));                
                inprogress(90);
            }
            if (checkBox_Digital.Checked)
            {
                if (textBox_Rebate.Text == string.Empty)
                {
                    textBox_Rebate.BackColor = Color.Pink;
                }
                else
                {
                    value.Rb = Convert.ToDouble(textBox_Rebate.Text);
                    value.Bt = 0;
                    value.Br = 0;
                    Digital digital = new Digital();

                    label_pro.Text = "Calculate Price";
                    textBoxPrice.Text = Convert.ToString(digital.OptionPrice(value)[0]);
                    inprogress(30);

                    label_pro.Text = "Calculate Std";
                    textBoxStd.Text = Convert.ToString(digital.OptionPrice(value)[1]);
                    inprogress(40);

                    label_pro.Text = "Calculate Delta";
                    textBoxDelta.Text = Convert.ToString(digital.Delta(value));
                    inprogress(50);

                    label_pro.Text = "Calculate Gamma";
                    textBoxGamma.Text = Convert.ToString(digital.Gamma(value));
                    inprogress(60);

                    label_pro.Text = "Calculate Vega";
                    textBoxVega.Text = Convert.ToString(digital.Vega(value));
                    inprogress(70);

                    label_pro.Text = "Calculate Theta";
                    textBoxTheta.Text = Convert.ToString(digital.Theta(value));
                    inprogress(80);

                    label_pro.Text = "Calculate Rho";
                    textBoxRho.Text = Convert.ToString(digital.Rho(value));
                    inprogress(90);
                }
                
            }
            if (checkBox_Barrier.Checked)
            {
                if (textBox_Barrier.Text == string.Empty)
                {
                    textBox_Barrier.BackColor = Color.Pink;
                }
                else
                {
                    value.Rb = 0;
                    value.Br = Convert.ToDouble(textBox_Barrier.Text);
                    if (radioButton_DO.Checked)
                        value.Bt = 0;
                    if (radioButton_UO.Checked)
                        value.Bt = 1;
                    if (radioButton_DI.Checked)
                        value.Bt = 2;
                    if (radioButton_UI.Checked)
                        value.Bt = 3;
                    Barrier barrier = new Barrier();

                    label_pro.Text = "Calculate Price";
                    textBoxPrice.Text = Convert.ToString(barrier.OptionPrice(value)[0]);
                    inprogress(30);

                    label_pro.Text = "Calculate Std";
                    textBoxStd.Text = Convert.ToString(barrier.OptionPrice(value)[1]);
                    inprogress(40);

                    label_pro.Text = "Calculate Delta";
                    textBoxDelta.Text = Convert.ToString(barrier.Delta(value));
                    inprogress(50);

                    label_pro.Text = "Calculate Gamma";
                    textBoxGamma.Text = Convert.ToString(barrier.Gamma(value));
                    inprogress(60);

                    label_pro.Text = "Calculate Vega";
                    textBoxVega.Text = Convert.ToString(barrier.Vega(value));
                    inprogress(70);

                    label_pro.Text = "Calculate Theta";
                    textBoxTheta.Text = Convert.ToString(barrier.Theta(value));
                    inprogress(80);

                    label_pro.Text = "Calculate Rho";
                    textBoxRho.Text = Convert.ToString(barrier.Rho(value));
                    inprogress(90);
                }                
            }
            if (checkBox_Lookback.Checked)
            {
                value.Rb = 0;
                value.Bt = 0;
                value.Br = 0;
                Lookback lookback = new Lookback();

                label_pro.Text = "Calculate Price";
                textBoxPrice.Text = Convert.ToString(lookback.OptionPrice(value)[0]);
                inprogress(30);

                label_pro.Text = "Calculate Std";
                textBoxStd.Text = Convert.ToString(lookback.OptionPrice(value)[1]);
                inprogress(40);

                label_pro.Text = "Calculate Delta";
                textBoxDelta.Text = Convert.ToString(lookback.Delta(value));
                inprogress(50);

                label_pro.Text = "Calculate Gamma";
                textBoxGamma.Text = Convert.ToString(lookback.Gamma(value));
                inprogress(60);

                label_pro.Text = "Calculate Vega";
                textBoxVega.Text = Convert.ToString(lookback.Vega(value));
                inprogress(70);

                label_pro.Text = "Calculate Theta";
                textBoxTheta.Text = Convert.ToString(lookback.Theta(value));
                inprogress(80);

                label_pro.Text = "Calculate Rho";
                textBoxRho.Text = Convert.ToString(lookback.Rho(value));
                inprogress(90);
            }
            if (checkBox_Range.Checked)
            {
                value.Rb = 0;
                value.Bt = 0;
                value.Br = 0;
                Range range = new Range();

                label_pro.Text = "Calculate Price";
                textBoxPrice.Text = Convert.ToString(range.OptionPrice(value)[0]);
                inprogress(30);

                label_pro.Text = "Calculate Std";
                textBoxStd.Text = Convert.ToString(range.OptionPrice(value)[1]);
                inprogress(40);

                label_pro.Text = "Calculate Delta";
                textBoxDelta.Text = Convert.ToString(range.Delta(value));
                inprogress(50);

                label_pro.Text = "Calculate Gamma";
                textBoxGamma.Text = Convert.ToString(range.Gamma(value));
                inprogress(60);

                label_pro.Text = "Calculate Vega";
                textBoxVega.Text = Convert.ToString(range.Vega(value));
                inprogress(70);

                label_pro.Text = "Calculate Theta";
                textBoxTheta.Text = Convert.ToString(range.Theta(value));
                inprogress(80);

                label_pro.Text = "Calculate Rho";
                textBoxRho.Text = Convert.ToString(range.Rho(value));
                inprogress(90);
            }
            int core_num;
            if (value.MT == true)
                core_num = System.Environment.ProcessorCount;
            else
                core_num = 1;
            TextBoxCore.Text = Convert.ToString(core_num);
        }
        //Some error settings
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
