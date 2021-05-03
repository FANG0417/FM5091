
namespace WindowsFormsApp4
{
    partial class New_InstType
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_InstType = new System.Windows.Forms.ComboBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instrument type name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_InstType
            // 
            this.comboBox_InstType.FormattingEnabled = true;
            this.comboBox_InstType.Items.AddRange(new object[] {
            "Stock",
            "EuropeanOption",
            "AsianOption",
            "DigitalOption",
            "BarrierOption",
            "LookbackOption",
            "RangeOption"});
            this.comboBox_InstType.Location = new System.Drawing.Point(260, 52);
            this.comboBox_InstType.Name = "comboBox_InstType";
            this.comboBox_InstType.Size = new System.Drawing.Size(482, 23);
            this.comboBox_InstType.TabIndex = 1;
            this.comboBox_InstType.SelectedIndexChanged += new System.EventHandler(this.comboBox_InstType_SelectedIndexChanged);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(150, 118);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(132, 32);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(473, 104);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(178, 45);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // New_InstType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 168);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.comboBox_InstType);
            this.Controls.Add(this.label1);
            this.Name = "New_InstType";
            this.Text = "Instrument Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_InstType;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
    }
}