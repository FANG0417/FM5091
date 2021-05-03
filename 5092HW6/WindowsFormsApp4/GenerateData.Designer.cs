
namespace WindowsFormsApp4
{
    partial class GenerateData
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
            this.button_GoStock = new System.Windows.Forms.Button();
            this.button_GoOption = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_GoStock
            // 
            this.button_GoStock.Location = new System.Drawing.Point(45, 33);
            this.button_GoStock.Name = "button_GoStock";
            this.button_GoStock.Size = new System.Drawing.Size(280, 91);
            this.button_GoStock.TabIndex = 0;
            this.button_GoStock.Text = "Go Stock";
            this.button_GoStock.UseVisualStyleBackColor = true;
            this.button_GoStock.Click += new System.EventHandler(this.button_Go_Click);
            // 
            // button_GoOption
            // 
            this.button_GoOption.Location = new System.Drawing.Point(45, 166);
            this.button_GoOption.Name = "button_GoOption";
            this.button_GoOption.Size = new System.Drawing.Size(280, 96);
            this.button_GoOption.TabIndex = 1;
            this.button_GoOption.Text = "Go Option";
            this.button_GoOption.UseVisualStyleBackColor = true;
            this.button_GoOption.Click += new System.EventHandler(this.button_GoOption_Click);
            // 
            // GenerateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 292);
            this.Controls.Add(this.button_GoOption);
            this.Controls.Add(this.button_GoStock);
            this.Name = "GenerateData";
            this.Text = "GenerateData";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_GoStock;
        private System.Windows.Forms.Button button_GoOption;
    }
}