
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
            this.textBoxtype = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxS0
            // 
            this.textBoxS0.Location = new System.Drawing.Point(73, 21);
            this.textBoxS0.Name = "textBoxS0";
            this.textBoxS0.Size = new System.Drawing.Size(93, 25);
            this.textBoxS0.TabIndex = 1;
            this.textBoxS0.TextChanged += new System.EventHandler(this.textBoxS0_TextChanged);
            // 
            // textBoxsigma
            // 
            this.textBoxsigma.Location = new System.Drawing.Point(73, 219);
            this.textBoxsigma.Name = "textBoxsigma";
            this.textBoxsigma.Size = new System.Drawing.Size(93, 25);
            this.textBoxsigma.TabIndex = 2;
            this.textBoxsigma.TextChanged += new System.EventHandler(this.textBoxsigma_TextChanged);
            // 
            // textBoxr
            // 
            this.textBoxr.Location = new System.Drawing.Point(73, 168);
            this.textBoxr.Name = "textBoxr";
            this.textBoxr.Size = new System.Drawing.Size(93, 25);
            this.textBoxr.TabIndex = 3;
            this.textBoxr.TextChanged += new System.EventHandler(this.textBoxr_TextChanged);
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(73, 118);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(93, 25);
            this.textBoxT.TabIndex = 4;
            this.textBoxT.TextChanged += new System.EventHandler(this.textBoxT_TextChanged);
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(73, 71);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(93, 25);
            this.textBoxK.TabIndex = 5;
            this.textBoxK.TextChanged += new System.EventHandler(this.textBoxK_TextChanged);
            // 
            // textBoxsteps
            // 
            this.textBoxsteps.Location = new System.Drawing.Point(73, 320);
            this.textBoxsteps.Name = "textBoxsteps";
            this.textBoxsteps.Size = new System.Drawing.Size(93, 25);
            this.textBoxsteps.TabIndex = 6;
            this.textBoxsteps.TextChanged += new System.EventHandler(this.textBoxsteps_TextChanged);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(73, 270);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(93, 25);
            this.textBoxN.TabIndex = 7;
            this.textBoxN.TextChanged += new System.EventHandler(this.textBoxN_TextChanged);
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(678, 21);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(93, 25);
            this.textBoxDelta.TabIndex = 8;
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Location = new System.Drawing.Point(678, 88);
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.Size = new System.Drawing.Size(93, 25);
            this.textBoxGamma.TabIndex = 9;
            // 
            // textBoxVega
            // 
            this.textBoxVega.Location = new System.Drawing.Point(678, 168);
            this.textBoxVega.Name = "textBoxVega";
            this.textBoxVega.Size = new System.Drawing.Size(93, 25);
            this.textBoxVega.TabIndex = 10;
            // 
            // textBoxTheta
            // 
            this.textBoxTheta.Location = new System.Drawing.Point(678, 240);
            this.textBoxTheta.Name = "textBoxTheta";
            this.textBoxTheta.Size = new System.Drawing.Size(93, 25);
            this.textBoxTheta.TabIndex = 11;
            // 
            // textBoxRho
            // 
            this.textBoxRho.Location = new System.Drawing.Point(678, 320);
            this.textBoxRho.Name = "textBoxRho";
            this.textBoxRho.Size = new System.Drawing.Size(93, 25);
            this.textBoxRho.TabIndex = 12;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(492, 118);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(93, 25);
            this.textBoxPrice.TabIndex = 13;
            // 
            // textBoxStd
            // 
            this.textBoxStd.Location = new System.Drawing.Point(492, 207);
            this.textBoxStd.Name = "textBoxStd";
            this.textBoxStd.Size = new System.Drawing.Size(93, 25);
            this.textBoxStd.TabIndex = 14;
            // 
            // textBoxtype
            // 
            this.textBoxtype.Location = new System.Drawing.Point(73, 376);
            this.textBoxtype.Name = "textBoxtype";
            this.textBoxtype.Size = new System.Drawing.Size(93, 25);
            this.textBoxtype.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "K";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "S0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "steps";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "N";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "sigma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "r";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "T";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "call is true, put is false";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(439, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(448, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "std";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(625, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "rho";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(625, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "theta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(625, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "vega";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(625, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 15);
            this.label15.TabIndex = 31;
            this.label15.Text = "gamma";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(625, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 15);
            this.label16.TabIndex = 32;
            this.label16.Text = "delta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxtype);
            this.Controls.Add(this.textBoxStd);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxRho);
            this.Controls.Add(this.textBoxTheta);
            this.Controls.Add(this.textBoxVega);
            this.Controls.Add(this.textBoxGamma);
            this.Controls.Add(this.textBoxDelta);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxsteps);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.textBoxr);
            this.Controls.Add(this.textBoxsigma);
            this.Controls.Add(this.textBoxS0);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox textBoxtype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

