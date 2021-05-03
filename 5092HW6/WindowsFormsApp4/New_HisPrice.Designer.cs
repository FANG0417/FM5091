
namespace WindowsFormsApp4
{
    partial class New_HisPrice
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
            this.label_Product = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_ClosingPrice = new System.Windows.Forms.Label();
            this.comboBox_Product = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.textBox_ClosingPrice = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Product
            // 
            this.label_Product.AutoSize = true;
            this.label_Product.Location = new System.Drawing.Point(54, 37);
            this.label_Product.Name = "label_Product";
            this.label_Product.Size = new System.Drawing.Size(63, 15);
            this.label_Product.TabIndex = 0;
            this.label_Product.Text = "Product";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(54, 88);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(39, 15);
            this.label_Date.TabIndex = 1;
            this.label_Date.Text = "Date";
            // 
            // label_ClosingPrice
            // 
            this.label_ClosingPrice.AutoSize = true;
            this.label_ClosingPrice.Location = new System.Drawing.Point(54, 144);
            this.label_ClosingPrice.Name = "label_ClosingPrice";
            this.label_ClosingPrice.Size = new System.Drawing.Size(111, 15);
            this.label_ClosingPrice.TabIndex = 2;
            this.label_ClosingPrice.Text = "Closing price";
            // 
            // comboBox_Product
            // 
            this.comboBox_Product.FormattingEnabled = true;
            this.comboBox_Product.Location = new System.Drawing.Point(222, 34);
            this.comboBox_Product.Name = "comboBox_Product";
            this.comboBox_Product.Size = new System.Drawing.Size(189, 23);
            this.comboBox_Product.TabIndex = 3;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(222, 88);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_Date.TabIndex = 4;
            // 
            // textBox_ClosingPrice
            // 
            this.textBox_ClosingPrice.Location = new System.Drawing.Point(220, 144);
            this.textBox_ClosingPrice.Name = "textBox_ClosingPrice";
            this.textBox_ClosingPrice.Size = new System.Drawing.Size(202, 25);
            this.textBox_ClosingPrice.TabIndex = 5;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(132, 196);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(365, 196);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // New_HisPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 231);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_ClosingPrice);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.comboBox_Product);
            this.Controls.Add(this.label_ClosingPrice);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Product);
            this.Name = "New_HisPrice";
            this.Text = "New_HisPrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Product;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_ClosingPrice;
        private System.Windows.Forms.ComboBox comboBox_Product;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.TextBox textBox_ClosingPrice;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
    }
}