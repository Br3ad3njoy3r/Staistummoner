namespace RiotApp
{
    partial class RiotForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            txtGameName = new TextBox();
            txtTagLine = new TextBox();
            btnFetchData = new Button();
            lblStatus = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chartRanked = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartNormal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lstSummary = new ListBox();
            txtGameCount = new TextBox();
            btnKDA = new Button();
            btnDamage = new Button();
            btnCS = new Button();
            btnVision = new Button();
            btnWins = new Button();
            ((System.ComponentModel.ISupportInitialize)chartRanked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartNormal).BeginInit();
            SuspendLayout();
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(2, 8);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(392, 31);
            txtGameName.TabIndex = 0;
            // 
            // txtTagLine
            // 
            txtTagLine.Location = new Point(400, 8);
            txtTagLine.Name = "txtTagLine";
            txtTagLine.Size = new Size(166, 31);
            txtTagLine.TabIndex = 1;
            txtTagLine.Text = "No # included";
            // 
            // btnFetchData
            // 
            btnFetchData.Location = new Point(680, 5);
            btnFetchData.Name = "btnFetchData";
            btnFetchData.Size = new Size(112, 34);
            btnFetchData.TabIndex = 2;
            btnFetchData.Text = "Fetch Data";
            btnFetchData.UseVisualStyleBackColor = true;
            btnFetchData.Click += btnFetchData_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(2, 42);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(31, 25);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "lbl";
            // 
            // chartRanked
            // 
            chartArea1.Name = "ChartArea1";
            chartRanked.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRanked.Legends.Add(legend1);
            chartRanked.Location = new Point(2, 74);
            chartRanked.Name = "chartRanked";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRanked.Series.Add(series1);
            chartRanked.Size = new Size(383, 402);
            chartRanked.TabIndex = 4;
            chartRanked.Text = "chart1";
            // 
            // chartNormal
            // 
            chartArea2.Name = "ChartArea1";
            chartNormal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartNormal.Legends.Add(legend2);
            chartNormal.Location = new Point(409, 74);
            chartNormal.Name = "chartNormal";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartNormal.Series.Add(series2);
            chartNormal.Size = new Size(383, 402);
            chartNormal.TabIndex = 5;
            chartNormal.Text = "chart1";
            // 
            // lstSummary
            // 
            lstSummary.FormattingEnabled = true;
            lstSummary.ItemHeight = 25;
            lstSummary.Location = new Point(2, 482);
            lstSummary.Name = "lstSummary";
            lstSummary.Size = new Size(869, 129);
            lstSummary.TabIndex = 6;
            // 
            // txtGameCount
            // 
            txtGameCount.Location = new Point(572, 7);
            txtGameCount.Name = "txtGameCount";
            txtGameCount.Size = new Size(102, 31);
            txtGameCount.TabIndex = 7;
            txtGameCount.Text = "# of games";
            // 
            // btnKDA
            // 
            btnKDA.Location = new Point(798, 74);
            btnKDA.Name = "btnKDA";
            btnKDA.Size = new Size(88, 34);
            btnKDA.TabIndex = 8;
            btnKDA.Text = "KDA";
            btnKDA.UseVisualStyleBackColor = true;
            btnKDA.Click += btnKDA_Click;
            // 
            // btnDamage
            // 
            btnDamage.Location = new Point(798, 114);
            btnDamage.Name = "btnDamage";
            btnDamage.Size = new Size(88, 34);
            btnDamage.TabIndex = 9;
            btnDamage.Text = "Damage";
            btnDamage.UseVisualStyleBackColor = true;
            btnDamage.Click += btnDamage_Click;
            // 
            // btnCS
            // 
            btnCS.Location = new Point(798, 154);
            btnCS.Name = "btnCS";
            btnCS.Size = new Size(88, 34);
            btnCS.TabIndex = 10;
            btnCS.Text = "CS";
            btnCS.UseVisualStyleBackColor = true;
            btnCS.Click += btnCS_Click;
            // 
            // btnVision
            // 
            btnVision.Location = new Point(798, 194);
            btnVision.Name = "btnVision";
            btnVision.Size = new Size(88, 34);
            btnVision.TabIndex = 11;
            btnVision.Text = "Vision";
            btnVision.UseVisualStyleBackColor = true;
            btnVision.Click += btnVision_Click;
            // 
            // btnWins
            // 
            btnWins.Location = new Point(798, 234);
            btnWins.Name = "btnWins";
            btnWins.Size = new Size(88, 34);
            btnWins.TabIndex = 12;
            btnWins.Text = "Wins";
            btnWins.UseVisualStyleBackColor = true;
            btnWins.Click += btnWins_Click;
            // 
            // RiotForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 623);
            Controls.Add(btnWins);
            Controls.Add(btnVision);
            Controls.Add(btnCS);
            Controls.Add(btnDamage);
            Controls.Add(btnKDA);
            Controls.Add(txtGameCount);
            Controls.Add(lstSummary);
            Controls.Add(chartNormal);
            Controls.Add(chartRanked);
            Controls.Add(lblStatus);
            Controls.Add(btnFetchData);
            Controls.Add(txtTagLine);
            Controls.Add(txtGameName);
            Name = "RiotForm";
            Text = "Riot Stats";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chartRanked).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartNormal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGameName;
        private TextBox txtTagLine;
        private Button btnFetchData;
        private Label lblStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRanked;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNormal;
        private ListBox lstSummary;
        private TextBox txtGameCount;
        private Button btnKDA;
        private Button btnDamage;
        private Button btnCS;
        private Button btnVision;
        private Button btnWins;
    }
}
