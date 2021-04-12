
namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxS0 = new System.Windows.Forms.TextBox();
            this.textBoxsigma = new System.Windows.Forms.TextBox();
            this.textBoxr = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.textBoxsteps = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.textBoxGamma = new System.Windows.Forms.TextBox();
            this.textBoxVega = new System.Windows.Forms.TextBox();
            this.textBoxTheta = new System.Windows.Forms.TextBox();
            this.textBoxRho = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxStd = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Radio_call = new System.Windows.Forms.RadioButton();
            this.Radio_Put = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelCore = new System.Windows.Forms.Label();
            this.TextBoxCore = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_Normal = new System.Windows.Forms.CheckBox();
            this.checkBox_MT = new System.Windows.Forms.CheckBox();
            this.checkBox_CV = new System.Windows.Forms.CheckBox();
            this.checkBox_An = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_pro = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_Rebate = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton_UI = new System.Windows.Forms.RadioButton();
            this.radioButton_DI = new System.Windows.Forms.RadioButton();
            this.radioButton_UO = new System.Windows.Forms.RadioButton();
            this.radioButton_DO = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox_Barrier = new System.Windows.Forms.TextBox();
            this.radioButton_European = new System.Windows.Forms.RadioButton();
            this.radioButton_Asian = new System.Windows.Forms.RadioButton();
            this.radioButton_Lookback = new System.Windows.Forms.RadioButton();
            this.radioButton_Digital = new System.Windows.Forms.RadioButton();
            this.radioButton_Range = new System.Windows.Forms.RadioButton();
            this.radioButton_Barrier = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(283, 386);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(156, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxS0
            // 
            this.textBoxS0.Location = new System.Drawing.Point(128, 46);
            this.textBoxS0.Name = "textBoxS0";
            this.textBoxS0.Size = new System.Drawing.Size(93, 30);
            this.textBoxS0.TabIndex = 1;
            this.textBoxS0.TextChanged += new System.EventHandler(this.textBoxS0_TextChanged);
            // 
            // textBoxsigma
            // 
            this.textBoxsigma.Location = new System.Drawing.Point(128, 279);
            this.textBoxsigma.Name = "textBoxsigma";
            this.textBoxsigma.Size = new System.Drawing.Size(93, 30);
            this.textBoxsigma.TabIndex = 2;
            this.textBoxsigma.TextChanged += new System.EventHandler(this.textBoxsigma_TextChanged);
            // 
            // textBoxr
            // 
            this.textBoxr.Location = new System.Drawing.Point(128, 219);
            this.textBoxr.Name = "textBoxr";
            this.textBoxr.Size = new System.Drawing.Size(93, 30);
            this.textBoxr.TabIndex = 3;
            this.textBoxr.TextChanged += new System.EventHandler(this.textBoxr_TextChanged);
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(128, 160);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(93, 30);
            this.textBoxT.TabIndex = 4;
            this.textBoxT.TextChanged += new System.EventHandler(this.textBoxT_TextChanged);
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(128, 100);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(93, 30);
            this.textBoxK.TabIndex = 5;
            this.textBoxK.TextChanged += new System.EventHandler(this.textBoxK_TextChanged);
            // 
            // textBoxsteps
            // 
            this.textBoxsteps.Location = new System.Drawing.Point(128, 409);
            this.textBoxsteps.Name = "textBoxsteps";
            this.textBoxsteps.Size = new System.Drawing.Size(93, 30);
            this.textBoxsteps.TabIndex = 6;
            this.textBoxsteps.TextChanged += new System.EventHandler(this.textBoxsteps_TextChanged);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(128, 344);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(93, 30);
            this.textBoxN.TabIndex = 7;
            this.textBoxN.TextChanged += new System.EventHandler(this.textBoxN_TextChanged);
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(101, 142);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(135, 30);
            this.textBoxDelta.TabIndex = 8;
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Location = new System.Drawing.Point(101, 194);
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.Size = new System.Drawing.Size(135, 30);
            this.textBoxGamma.TabIndex = 9;
            // 
            // textBoxVega
            // 
            this.textBoxVega.Location = new System.Drawing.Point(101, 245);
            this.textBoxVega.Name = "textBoxVega";
            this.textBoxVega.Size = new System.Drawing.Size(135, 30);
            this.textBoxVega.TabIndex = 10;
            // 
            // textBoxTheta
            // 
            this.textBoxTheta.Location = new System.Drawing.Point(101, 296);
            this.textBoxTheta.Name = "textBoxTheta";
            this.textBoxTheta.Size = new System.Drawing.Size(135, 30);
            this.textBoxTheta.TabIndex = 11;
            this.textBoxTheta.TextChanged += new System.EventHandler(this.textBoxTheta_TextChanged);
            // 
            // textBoxRho
            // 
            this.textBoxRho.Location = new System.Drawing.Point(101, 344);
            this.textBoxRho.Name = "textBoxRho";
            this.textBoxRho.Size = new System.Drawing.Size(135, 30);
            this.textBoxRho.TabIndex = 12;
            this.textBoxRho.TextChanged += new System.EventHandler(this.textBoxRho_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(101, 37);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(135, 30);
            this.textBoxPrice.TabIndex = 13;
            // 
            // textBoxStd
            // 
            this.textBoxStd.Location = new System.Drawing.Point(101, 91);
            this.textBoxStd.Name = "textBoxStd";
            this.textBoxStd.Size = new System.Drawing.Size(135, 30);
            this.textBoxStd.TabIndex = 14;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(101, 392);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(135, 30);
            this.textBoxTime.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Strike";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Underlying";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "RunTime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Steps";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Trials";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Volatility";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Interest Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tenor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "StdError";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 24);
            this.label12.TabIndex = 28;
            this.label12.Text = "Rho";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 24);
            this.label13.TabIndex = 29;
            this.label13.Text = "Theta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 24);
            this.label14.TabIndex = 30;
            this.label14.Text = "Vega";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 24);
            this.label15.TabIndex = 31;
            this.label15.Text = "Gamma";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 24);
            this.label16.TabIndex = 32;
            this.label16.Text = "Delta";
            // 
            // Radio_call
            // 
            this.Radio_call.AutoSize = true;
            this.Radio_call.Location = new System.Drawing.Point(16, 38);
            this.Radio_call.Name = "Radio_call";
            this.Radio_call.Size = new System.Drawing.Size(66, 28);
            this.Radio_call.TabIndex = 33;
            this.Radio_call.TabStop = true;
            this.Radio_call.Text = "Call";
            this.Radio_call.UseVisualStyleBackColor = true;
            this.Radio_call.CheckedChanged += new System.EventHandler(this.call_CheckedChanged);
            // 
            // Radio_Put
            // 
            this.Radio_Put.AutoSize = true;
            this.Radio_Put.Location = new System.Drawing.Point(16, 88);
            this.Radio_Put.Name = "Radio_Put";
            this.Radio_Put.Size = new System.Drawing.Size(63, 28);
            this.Radio_Put.TabIndex = 34;
            this.Radio_Put.TabStop = true;
            this.Radio_Put.Text = "Put";
            this.Radio_Put.UseVisualStyleBackColor = true;
            this.Radio_Put.CheckedChanged += new System.EventHandler(this.put_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.textBoxsteps);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxS0);
            this.groupBox1.Controls.Add(this.textBoxsigma);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxr);
            this.groupBox1.Controls.Add(this.textBoxT);
            this.groupBox1.Controls.Add(this.textBoxK);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 460);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.Radio_call);
            this.groupBox2.Controls.Add(this.Radio_Put);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(267, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 135);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Call/Put";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.labelCore);
            this.groupBox3.Controls.Add(this.TextBoxCore);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxPrice);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBoxTime);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBoxRho);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.textBoxStd);
            this.groupBox3.Controls.Add(this.textBoxTheta);
            this.groupBox3.Controls.Add(this.textBoxDelta);
            this.groupBox3.Controls.Add(this.textBoxGamma);
            this.groupBox3.Controls.Add(this.textBoxVega);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(793, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 475);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outputs";
            // 
            // labelCore
            // 
            this.labelCore.AutoSize = true;
            this.labelCore.Location = new System.Drawing.Point(0, 442);
            this.labelCore.Name = "labelCore";
            this.labelCore.Size = new System.Drawing.Size(98, 24);
            this.labelCore.TabIndex = 34;
            this.labelCore.Text = "CoreNum";
            // 
            // TextBoxCore
            // 
            this.TextBoxCore.Location = new System.Drawing.Point(101, 439);
            this.TextBoxCore.Name = "TextBoxCore";
            this.TextBoxCore.Size = new System.Drawing.Size(135, 30);
            this.TextBoxCore.TabIndex = 33;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.checkBox_Normal);
            this.groupBox4.Controls.Add(this.checkBox_MT);
            this.groupBox4.Controls.Add(this.checkBox_CV);
            this.groupBox4.Controls.Add(this.checkBox_An);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(438, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(329, 135);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Method";
            // 
            // checkBox_Normal
            // 
            this.checkBox_Normal.AutoSize = true;
            this.checkBox_Normal.Location = new System.Drawing.Point(8, 39);
            this.checkBox_Normal.Name = "checkBox_Normal";
            this.checkBox_Normal.Size = new System.Drawing.Size(99, 28);
            this.checkBox_Normal.TabIndex = 44;
            this.checkBox_Normal.Text = "Normal";
            this.checkBox_Normal.UseVisualStyleBackColor = true;
            // 
            // checkBox_MT
            // 
            this.checkBox_MT.AutoSize = true;
            this.checkBox_MT.Location = new System.Drawing.Point(150, 86);
            this.checkBox_MT.Name = "checkBox_MT";
            this.checkBox_MT.Size = new System.Drawing.Size(174, 28);
            this.checkBox_MT.TabIndex = 43;
            this.checkBox_MT.Text = "MultiThreading";
            this.checkBox_MT.UseVisualStyleBackColor = true;
            // 
            // checkBox_CV
            // 
            this.checkBox_CV.AutoSize = true;
            this.checkBox_CV.Location = new System.Drawing.Point(150, 39);
            this.checkBox_CV.Name = "checkBox_CV";
            this.checkBox_CV.Size = new System.Drawing.Size(173, 28);
            this.checkBox_CV.TabIndex = 42;
            this.checkBox_CV.Text = "Control Variate";
            this.checkBox_CV.UseVisualStyleBackColor = true;
            // 
            // checkBox_An
            // 
            this.checkBox_An.AutoSize = true;
            this.checkBox_An.Location = new System.Drawing.Point(8, 85);
            this.checkBox_An.Name = "checkBox_An";
            this.checkBox_An.Size = new System.Drawing.Size(122, 28);
            this.checkBox_An.TabIndex = 41;
            this.checkBox_An.Text = "Antithetic";
            this.checkBox_An.UseVisualStyleBackColor = true;
            this.checkBox_An.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(267, 495);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(301, 21);
            this.progressBar1.TabIndex = 42;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label_pro
            // 
            this.label_pro.AutoSize = true;
            this.label_pro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pro.Location = new System.Drawing.Point(439, 444);
            this.label_pro.Name = "label_pro";
            this.label_pro.Size = new System.Drawing.Size(0, 24);
            this.label_pro.TabIndex = 43;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Controls.Add(this.radioButton_Barrier);
            this.groupBox5.Controls.Add(this.radioButton_Range);
            this.groupBox5.Controls.Add(this.radioButton_Digital);
            this.groupBox5.Controls.Add(this.radioButton_Lookback);
            this.groupBox5.Controls.Add(this.radioButton_Asian);
            this.groupBox5.Controls.Add(this.radioButton_European);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(267, 167);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(500, 107);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Type";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.textBox_Rebate);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(267, 283);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(157, 85);
            this.groupBox6.TabIndex = 45;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Digital Rebate";
            // 
            // textBox_Rebate
            // 
            this.textBox_Rebate.Location = new System.Drawing.Point(16, 39);
            this.textBox_Rebate.Name = "textBox_Rebate";
            this.textBox_Rebate.Size = new System.Drawing.Size(129, 30);
            this.textBox_Rebate.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.radioButton_UI);
            this.groupBox7.Controls.Add(this.radioButton_DI);
            this.groupBox7.Controls.Add(this.radioButton_UO);
            this.groupBox7.Controls.Add(this.radioButton_DO);
            this.groupBox7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(439, 283);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(328, 87);
            this.groupBox7.TabIndex = 46;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Barrier Type";
            // 
            // radioButton_UI
            // 
            this.radioButton_UI.AutoSize = true;
            this.radioButton_UI.Location = new System.Drawing.Point(180, 57);
            this.radioButton_UI.Name = "radioButton_UI";
            this.radioButton_UI.Size = new System.Drawing.Size(121, 28);
            this.radioButton_UI.TabIndex = 3;
            this.radioButton_UI.TabStop = true;
            this.radioButton_UI.Text = "Up and In";
            this.radioButton_UI.UseVisualStyleBackColor = true;
            // 
            // radioButton_DI
            // 
            this.radioButton_DI.AutoSize = true;
            this.radioButton_DI.Location = new System.Drawing.Point(6, 57);
            this.radioButton_DI.Name = "radioButton_DI";
            this.radioButton_DI.Size = new System.Drawing.Size(148, 28);
            this.radioButton_DI.TabIndex = 2;
            this.radioButton_DI.TabStop = true;
            this.radioButton_DI.Text = "Down and In";
            this.radioButton_DI.UseVisualStyleBackColor = true;
            // 
            // radioButton_UO
            // 
            this.radioButton_UO.AutoSize = true;
            this.radioButton_UO.Location = new System.Drawing.Point(178, 23);
            this.radioButton_UO.Name = "radioButton_UO";
            this.radioButton_UO.Size = new System.Drawing.Size(139, 28);
            this.radioButton_UO.TabIndex = 1;
            this.radioButton_UO.TabStop = true;
            this.radioButton_UO.Text = "Up and Out";
            this.radioButton_UO.UseVisualStyleBackColor = true;
            // 
            // radioButton_DO
            // 
            this.radioButton_DO.AutoSize = true;
            this.radioButton_DO.Location = new System.Drawing.Point(6, 23);
            this.radioButton_DO.Name = "radioButton_DO";
            this.radioButton_DO.Size = new System.Drawing.Size(166, 28);
            this.radioButton_DO.TabIndex = 0;
            this.radioButton_DO.TabStop = true;
            this.radioButton_DO.Text = "Down and Out";
            this.radioButton_DO.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.textBox_Barrier);
            this.groupBox8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(627, 374);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(134, 60);
            this.groupBox8.TabIndex = 47;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Barrier";
            // 
            // textBox_Barrier
            // 
            this.textBox_Barrier.Location = new System.Drawing.Point(31, 24);
            this.textBox_Barrier.Name = "textBox_Barrier";
            this.textBox_Barrier.Size = new System.Drawing.Size(82, 30);
            this.textBox_Barrier.TabIndex = 0;
            // 
            // radioButton_European
            // 
            this.radioButton_European.AutoSize = true;
            this.radioButton_European.Location = new System.Drawing.Point(7, 29);
            this.radioButton_European.Name = "radioButton_European";
            this.radioButton_European.Size = new System.Drawing.Size(122, 28);
            this.radioButton_European.TabIndex = 47;
            this.radioButton_European.TabStop = true;
            this.radioButton_European.Text = "European";
            this.radioButton_European.UseVisualStyleBackColor = true;
            // 
            // radioButton_Asian
            // 
            this.radioButton_Asian.AutoSize = true;
            this.radioButton_Asian.Location = new System.Drawing.Point(187, 29);
            this.radioButton_Asian.Name = "radioButton_Asian";
            this.radioButton_Asian.Size = new System.Drawing.Size(83, 28);
            this.radioButton_Asian.TabIndex = 48;
            this.radioButton_Asian.TabStop = true;
            this.radioButton_Asian.Text = "Asian";
            this.radioButton_Asian.UseVisualStyleBackColor = true;
            // 
            // radioButton_Lookback
            // 
            this.radioButton_Lookback.AutoSize = true;
            this.radioButton_Lookback.Location = new System.Drawing.Point(350, 29);
            this.radioButton_Lookback.Name = "radioButton_Lookback";
            this.radioButton_Lookback.Size = new System.Drawing.Size(123, 28);
            this.radioButton_Lookback.TabIndex = 49;
            this.radioButton_Lookback.TabStop = true;
            this.radioButton_Lookback.Text = "Lookback";
            this.radioButton_Lookback.UseVisualStyleBackColor = true;
            // 
            // radioButton_Digital
            // 
            this.radioButton_Digital.AutoSize = true;
            this.radioButton_Digital.Location = new System.Drawing.Point(7, 62);
            this.radioButton_Digital.Name = "radioButton_Digital";
            this.radioButton_Digital.Size = new System.Drawing.Size(90, 28);
            this.radioButton_Digital.TabIndex = 50;
            this.radioButton_Digital.TabStop = true;
            this.radioButton_Digital.Text = "Digital";
            this.radioButton_Digital.UseVisualStyleBackColor = true;
            // 
            // radioButton_Range
            // 
            this.radioButton_Range.AutoSize = true;
            this.radioButton_Range.Location = new System.Drawing.Point(187, 62);
            this.radioButton_Range.Name = "radioButton_Range";
            this.radioButton_Range.Size = new System.Drawing.Size(91, 28);
            this.radioButton_Range.TabIndex = 51;
            this.radioButton_Range.TabStop = true;
            this.radioButton_Range.Text = "Range";
            this.radioButton_Range.UseVisualStyleBackColor = true;
            // 
            // radioButton_Barrier
            // 
            this.radioButton_Barrier.AutoSize = true;
            this.radioButton_Barrier.Location = new System.Drawing.Point(350, 62);
            this.radioButton_Barrier.Name = "radioButton_Barrier";
            this.radioButton_Barrier.Size = new System.Drawing.Size(96, 28);
            this.radioButton_Barrier.TabIndex = 52;
            this.radioButton_Barrier.TabStop = true;
            this.radioButton_Barrier.Text = "Barrier";
            this.radioButton_Barrier.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 532);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label_pro);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Monte Carlo Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxS0;
        private System.Windows.Forms.TextBox textBoxsigma;
        private System.Windows.Forms.TextBox textBoxr;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.TextBox textBoxsteps;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.TextBox textBoxGamma;
        private System.Windows.Forms.TextBox textBoxVega;
        private System.Windows.Forms.TextBox textBoxTheta;
        private System.Windows.Forms.TextBox textBoxRho;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxStd;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton Radio_call;
        private System.Windows.Forms.RadioButton Radio_Put;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_pro;
        private System.Windows.Forms.Label labelCore;
        private System.Windows.Forms.TextBox TextBoxCore;
        private System.Windows.Forms.CheckBox checkBox_An;
        private System.Windows.Forms.CheckBox checkBox_Normal;
        private System.Windows.Forms.CheckBox checkBox_MT;
        private System.Windows.Forms.CheckBox checkBox_CV;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox_Rebate;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton_DO;
        private System.Windows.Forms.RadioButton radioButton_UI;
        private System.Windows.Forms.RadioButton radioButton_DI;
        private System.Windows.Forms.RadioButton radioButton_UO;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox_Barrier;
        private System.Windows.Forms.RadioButton radioButton_Barrier;
        private System.Windows.Forms.RadioButton radioButton_Range;
        private System.Windows.Forms.RadioButton radioButton_Digital;
        private System.Windows.Forms.RadioButton radioButton_Lookback;
        private System.Windows.Forms.RadioButton radioButton_Asian;
        private System.Windows.Forms.RadioButton radioButton_European;
    }
}

