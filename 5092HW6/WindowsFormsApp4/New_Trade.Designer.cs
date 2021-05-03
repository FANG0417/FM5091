
namespace WindowsFormsApp4
{
    partial class New_Trade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Direction = new System.Windows.Forms.Label();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.label_Instrument = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.radioButton_Buy = new System.Windows.Forms.RadioButton();
            this.radioButton_Sell = new System.Windows.Forms.RadioButton();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.comboBox_Instrument = new System.Windows.Forms.ComboBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Direction
            // 
            this.label_Direction.AutoSize = true;
            this.label_Direction.Location = new System.Drawing.Point(75, 26);
            this.label_Direction.Name = "label_Direction";
            this.label_Direction.Size = new System.Drawing.Size(79, 15);
            this.label_Direction.TabIndex = 0;
            this.label_Direction.Text = "Direction";
            // 
            // label_Quantity
            // 
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Location = new System.Drawing.Point(87, 90);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(71, 15);
            this.label_Quantity.TabIndex = 1;
            this.label_Quantity.Text = "Quantity";
            // 
            // label_Instrument
            // 
            this.label_Instrument.AutoSize = true;
            this.label_Instrument.Location = new System.Drawing.Point(75, 157);
            this.label_Instrument.Name = "label_Instrument";
            this.label_Instrument.Size = new System.Drawing.Size(87, 15);
            this.label_Instrument.TabIndex = 2;
            this.label_Instrument.Text = "Instrument";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(87, 216);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(47, 15);
            this.label_Price.TabIndex = 3;
            this.label_Price.Text = "Price";
            // 
            // radioButton_Buy
            // 
            this.radioButton_Buy.AutoSize = true;
            this.radioButton_Buy.Location = new System.Drawing.Point(240, 26);
            this.radioButton_Buy.Name = "radioButton_Buy";
            this.radioButton_Buy.Size = new System.Drawing.Size(52, 19);
            this.radioButton_Buy.TabIndex = 4;
            this.radioButton_Buy.TabStop = true;
            this.radioButton_Buy.Text = "Buy";
            this.radioButton_Buy.UseVisualStyleBackColor = true;
            // 
            // radioButton_Sell
            // 
            this.radioButton_Sell.AutoSize = true;
            this.radioButton_Sell.Location = new System.Drawing.Point(362, 26);
            this.radioButton_Sell.Name = "radioButton_Sell";
            this.radioButton_Sell.Size = new System.Drawing.Size(60, 19);
            this.radioButton_Sell.TabIndex = 5;
            this.radioButton_Sell.TabStop = true;
            this.radioButton_Sell.Text = "Sell";
            this.radioButton_Sell.UseVisualStyleBackColor = true;
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(240, 87);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(100, 25);
            this.textBox_Quantity.TabIndex = 6;
            // 
            // comboBox_Instrument
            // 
            this.comboBox_Instrument.FormattingEnabled = true;
            this.comboBox_Instrument.Location = new System.Drawing.Point(203, 154);
            this.comboBox_Instrument.Name = "comboBox_Instrument";
            this.comboBox_Instrument.Size = new System.Drawing.Size(249, 23);
            this.comboBox_Instrument.TabIndex = 7;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(207, 217);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(203, 25);
            this.textBox_Price.TabIndex = 8;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(189, 260);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 9;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(326, 260);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(69, 23);
            this.button_Cancel.TabIndex = 10;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // New_Trade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 295);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.comboBox_Instrument);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.radioButton_Sell);
            this.Controls.Add(this.radioButton_Buy);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.label_Instrument);
            this.Controls.Add(this.label_Quantity);
            this.Controls.Add(this.label_Direction);
            this.Name = "New_Trade";
            this.Text = "New_Trade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Direction;
        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.Label label_Instrument;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.RadioButton radioButton_Buy;
        private System.Windows.Forms.RadioButton radioButton_Sell;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.ComboBox comboBox_Instrument;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
    }
}