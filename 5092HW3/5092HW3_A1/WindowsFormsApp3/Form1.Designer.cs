
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
            this.call = new System.Windows.Forms.RadioButton();
            this.put = new System.Windows.Forms.RadioButton();
            this.normal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.antithetic = new System.Windows.Forms.RadioButton();
            this.CV = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(324, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate!";
            this.button1.UseVisualStyleBackColor = true;
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
            this.textBoxDelta.Size = new System.Drawing.Size(151, 30);
            this.textBoxDelta.TabIndex = 8;
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Location = new System.Drawing.Point(101, 194);
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.Size = new System.Drawing.Size(151, 30);
            this.textBoxGamma.TabIndex = 9;
            // 
            // textBoxVega
            // 
            this.textBoxVega.Location = new System.Drawing.Point(101, 251);
            this.textBoxVega.Name = "textBoxVega";
            this.textBoxVega.Size = new System.Drawing.Size(151, 30);
            this.textBoxVega.TabIndex = 10;
            // 
            // textBoxTheta
            // 
            this.textBoxTheta.Location = new System.Drawing.Point(101, 302);
            this.textBoxTheta.Name = "textBoxTheta";
            this.textBoxTheta.Size = new System.Drawing.Size(151, 30);
            this.textBoxTheta.TabIndex = 11;
            this.textBoxTheta.TextChanged += new System.EventHandler(this.textBoxTheta_TextChanged);
            // 
            // textBoxRho
            // 
            this.textBoxRho.Location = new System.Drawing.Point(101, 350);
            this.textBoxRho.Name = "textBoxRho";
            this.textBoxRho.Size = new System.Drawing.Size(151, 30);
            this.textBoxRho.TabIndex = 12;
            this.textBoxRho.TextChanged += new System.EventHandler(this.textBoxRho_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(101, 37);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(151, 30);
            this.textBoxPrice.TabIndex = 13;
            // 
            // textBoxStd
            // 
            this.textBoxStd.Location = new System.Drawing.Point(101, 91);
            this.textBoxStd.Name = "textBoxStd";
            this.textBoxStd.Size = new System.Drawing.Size(151, 30);
            this.textBoxStd.TabIndex = 14;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(101, 395);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(151, 30);
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 398);
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
            this.label7.Location = new System.Drawing.Point(-4, 222);
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
            this.label12.Location = new System.Drawing.Point(35, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 24);
            this.label12.TabIndex = 28;
            this.label12.Text = "Rho";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 24);
            this.label13.TabIndex = 29;
            this.label13.Text = "Theta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 254);
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
            // call
            // 
            this.call.AutoSize = true;
            this.call.Location = new System.Drawing.Point(16, 38);
            this.call.Name = "call";
            this.call.Size = new System.Drawing.Size(66, 28);
            this.call.TabIndex = 33;
            this.call.TabStop = true;
            this.call.Text = "Call";
            this.call.UseVisualStyleBackColor = true;
            this.call.CheckedChanged += new System.EventHandler(this.call_CheckedChanged);
            // 
            // put
            // 
            this.put.AutoSize = true;
            this.put.Location = new System.Drawing.Point(134, 38);
            this.put.Name = "put";
            this.put.Size = new System.Drawing.Size(63, 28);
            this.put.TabIndex = 34;
            this.put.TabStop = true;
            this.put.Text = "Put";
            this.put.UseVisualStyleBackColor = true;
            this.put.CheckedChanged += new System.EventHandler(this.put_CheckedChanged);
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Location = new System.Drawing.Point(6, 45);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(98, 28);
            this.normal.TabIndex = 35;
            this.normal.TabStop = true;
            this.normal.Text = "Normal";
            this.normal.UseVisualStyleBackColor = true;
            this.normal.CheckedChanged += new System.EventHandler(this.normal_CheckedChanged);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 466);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.call);
            this.groupBox2.Controls.Add(this.put);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(373, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 72);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Call/Put";
            // 
            // groupBox3
            // 
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
            this.groupBox3.Location = new System.Drawing.Point(718, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 451);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outputs";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.antithetic);
            this.groupBox4.Controls.Add(this.normal);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(373, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 98);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Method";
            // 
            // antithetic
            // 
            this.antithetic.AutoSize = true;
            this.antithetic.Location = new System.Drawing.Point(143, 45);
            this.antithetic.Name = "antithetic";
            this.antithetic.Size = new System.Drawing.Size(121, 28);
            this.antithetic.TabIndex = 40;
            this.antithetic.TabStop = true;
            this.antithetic.Text = "Antithetic";
            this.antithetic.UseVisualStyleBackColor = true;
            this.antithetic.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // CV
            // 
            this.CV.AutoSize = true;
            this.CV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV.Location = new System.Drawing.Point(379, 246);
            this.CV.Name = "CV";
            this.CV.Size = new System.Drawing.Size(178, 28);
            this.CV.TabIndex = 40;
            this.CV.TabStop = true;
            this.CV.Text = " Control Variate";
            this.CV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 577);
            this.Controls.Add(this.CV);
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
        private System.Windows.Forms.RadioButton call;
        private System.Windows.Forms.RadioButton put;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton antithetic;
        private System.Windows.Forms.RadioButton CV;
    }
}

