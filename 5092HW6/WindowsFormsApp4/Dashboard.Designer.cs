
namespace WindowsFormsApp4
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumenttypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interestRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicalPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTradesFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceBookFromSimulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicalPriceAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interestRateAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PriceVol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_Totals = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.listView_AllTrades = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectedTradeDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.refreshTradesFromDatabaseToolStripMenuItem,
            this.priceBookFromSimulatorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumenttypeToolStripMenuItem,
            this.instrumentToolStripMenuItem1,
            this.tradeToolStripMenuItem,
            this.interestRateToolStripMenuItem,
            this.historicalPriceToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // instrumenttypeToolStripMenuItem
            // 
            this.instrumenttypeToolStripMenuItem.Name = "instrumenttypeToolStripMenuItem";
            this.instrumenttypeToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.instrumenttypeToolStripMenuItem.Text = "Instrument type";
            this.instrumenttypeToolStripMenuItem.Click += new System.EventHandler(this.instrumenttypeToolStripMenuItem_Click);
            // 
            // instrumentToolStripMenuItem1
            // 
            this.instrumentToolStripMenuItem1.Name = "instrumentToolStripMenuItem1";
            this.instrumentToolStripMenuItem1.Size = new System.Drawing.Size(208, 26);
            this.instrumentToolStripMenuItem1.Text = "Instrument";
            this.instrumentToolStripMenuItem1.Click += new System.EventHandler(this.instrumentToolStripMenuItem1_Click);
            // 
            // tradeToolStripMenuItem
            // 
            this.tradeToolStripMenuItem.Name = "tradeToolStripMenuItem";
            this.tradeToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.tradeToolStripMenuItem.Text = "Trade";
            this.tradeToolStripMenuItem.Click += new System.EventHandler(this.tradeToolStripMenuItem_Click);
            // 
            // interestRateToolStripMenuItem
            // 
            this.interestRateToolStripMenuItem.Name = "interestRateToolStripMenuItem";
            this.interestRateToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.interestRateToolStripMenuItem.Text = "Interest rate";
            this.interestRateToolStripMenuItem.Click += new System.EventHandler(this.interestRateToolStripMenuItem_Click);
            // 
            // historicalPriceToolStripMenuItem
            // 
            this.historicalPriceToolStripMenuItem.Name = "historicalPriceToolStripMenuItem";
            this.historicalPriceToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.historicalPriceToolStripMenuItem.Text = "Historical price";
            this.historicalPriceToolStripMenuItem.Click += new System.EventHandler(this.historicalPriceToolStripMenuItem_Click);
            // 
            // refreshTradesFromDatabaseToolStripMenuItem
            // 
            this.refreshTradesFromDatabaseToolStripMenuItem.Name = "refreshTradesFromDatabaseToolStripMenuItem";
            this.refreshTradesFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.refreshTradesFromDatabaseToolStripMenuItem.Text = "Refresh trades from database";
            this.refreshTradesFromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.refreshTradesFromDatabaseToolStripMenuItem_Click);
            // 
            // priceBookFromSimulatorToolStripMenuItem
            // 
            this.priceBookFromSimulatorToolStripMenuItem.Name = "priceBookFromSimulatorToolStripMenuItem";
            this.priceBookFromSimulatorToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.priceBookFromSimulatorToolStripMenuItem.Text = "Price book from simulator";
            this.priceBookFromSimulatorToolStripMenuItem.Click += new System.EventHandler(this.priceBookFromSimulatorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historicalPriceAnalysisToolStripMenuItem,
            this.interestRateAnalysisToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // historicalPriceAnalysisToolStripMenuItem
            // 
            this.historicalPriceAnalysisToolStripMenuItem.Name = "historicalPriceAnalysisToolStripMenuItem";
            this.historicalPriceAnalysisToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.historicalPriceAnalysisToolStripMenuItem.Text = "Historical price analysis";
            this.historicalPriceAnalysisToolStripMenuItem.Click += new System.EventHandler(this.historicalPriceAnalysisToolStripMenuItem_Click);
            // 
            // interestRateAnalysisToolStripMenuItem
            // 
            this.interestRateAnalysisToolStripMenuItem.Name = "interestRateAnalysisToolStripMenuItem";
            this.interestRateAnalysisToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.interestRateAnalysisToolStripMenuItem.Text = "Interest rate analysis";
            this.interestRateAnalysisToolStripMenuItem.Click += new System.EventHandler(this.interestRateAnalysisToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateDataToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // generateDataToolStripMenuItem
            // 
            this.generateDataToolStripMenuItem.Name = "generateDataToolStripMenuItem";
            this.generateDataToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.generateDataToolStripMenuItem.Text = "Generate Data";
            this.generateDataToolStripMenuItem.Click += new System.EventHandler(this.generateDataToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price Volatility(%)";
            // 
            // textBox_PriceVol
            // 
            this.textBox_PriceVol.Location = new System.Drawing.Point(190, 38);
            this.textBox_PriceVol.Name = "textBox_PriceVol";
            this.textBox_PriceVol.Size = new System.Drawing.Size(182, 25);
            this.textBox_PriceVol.TabIndex = 2;
            this.textBox_PriceVol.Text = "50";
            this.textBox_PriceVol.TextChanged += new System.EventHandler(this.textBox_PriceVol_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Totals";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listView_Totals
            // 
            this.listView_Totals.HideSelection = false;
            this.listView_Totals.Location = new System.Drawing.Point(15, 91);
            this.listView_Totals.Name = "listView_Totals";
            this.listView_Totals.Size = new System.Drawing.Size(973, 97);
            this.listView_Totals.TabIndex = 4;
            this.listView_Totals.UseCompatibleStateImageBehavior = false;
            this.listView_Totals.View = System.Windows.Forms.View.Details;
            this.listView_Totals.SelectedIndexChanged += new System.EventHandler(this.listView_Totals_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "All trades";
            // 
            // listView_AllTrades
            // 
            this.listView_AllTrades.BackColor = System.Drawing.SystemColors.Window;
            this.listView_AllTrades.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_AllTrades.FullRowSelect = true;
            this.listView_AllTrades.HideSelection = false;
            this.listView_AllTrades.Location = new System.Drawing.Point(15, 225);
            this.listView_AllTrades.Name = "listView_AllTrades";
            this.listView_AllTrades.Size = new System.Drawing.Size(973, 218);
            this.listView_AllTrades.TabIndex = 6;
            this.listView_AllTrades.UseCompatibleStateImageBehavior = false;
            this.listView_AllTrades.View = System.Windows.Forms.View.Details;
            this.listView_AllTrades.SelectedIndexChanged += new System.EventHandler(this.listView_AllTrades_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedTradeDeleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(237, 28);
            // 
            // selectedTradeDeleteToolStripMenuItem
            // 
            this.selectedTradeDeleteToolStripMenuItem.Name = "selectedTradeDeleteToolStripMenuItem";
            this.selectedTradeDeleteToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.selectedTradeDeleteToolStripMenuItem.Text = "Selected trade delete";
            this.selectedTradeDeleteToolStripMenuItem.Click += new System.EventHandler(this.selectedTradeDeleteToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 475);
            this.Controls.Add(this.listView_AllTrades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView_Totals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_PriceVol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Portfolio Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumenttypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceBookFromSimulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicalPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PriceVol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_Totals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView_AllTrades;
        private System.Windows.Forms.ToolStripMenuItem historicalPriceAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interestRateAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interestRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshTradesFromDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectedTradeDeleteToolStripMenuItem;
    }
}

