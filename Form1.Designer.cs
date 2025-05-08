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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnKills = new Button();
            btnDeaths = new Button();
            btnAssists = new Button();
            panelData = new Panel();
            ((System.ComponentModel.ISupportInitialize)chartRanked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartNormal).BeginInit();
            SuspendLayout();
            // 
            // txtGameName
            // 
            txtGameName.BackColor = Color.RoyalBlue;
            txtGameName.ForeColor = SystemColors.WindowText;
            txtGameName.Location = new Point(12, 38);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(392, 31);
            txtGameName.TabIndex = 0;
            // 
            // txtTagLine
            // 
            txtTagLine.BackColor = Color.RoyalBlue;
            txtTagLine.Location = new Point(410, 38);
            txtTagLine.Name = "txtTagLine";
            txtTagLine.Size = new Size(166, 31);
            txtTagLine.TabIndex = 1;
            // 
            // btnFetchData
            // 
            btnFetchData.BackColor = Color.RoyalBlue;
            btnFetchData.ForeColor = SystemColors.WindowText;
            btnFetchData.Location = new Point(716, 34);
            btnFetchData.Name = "btnFetchData";
            btnFetchData.Size = new Size(112, 34);
            btnFetchData.TabIndex = 3;
            btnFetchData.Text = "Fetch Data";
            btnFetchData.UseVisualStyleBackColor = false;
            btnFetchData.Click += btnFetchData_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = SystemColors.Control;
            lblStatus.Location = new Point(12, 72);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(250, 25);
            lblStatus.TabIndex = 100;
            lblStatus.Text = "Please Enter Your Information!";
            // 
            // chartRanked
            // 
            chartRanked.BackColor = Color.RoyalBlue;
            chartRanked.BorderlineColor = Color.CornflowerBlue;
            chartArea1.Name = "ChartArea1";
            chartRanked.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRanked.Legends.Add(legend1);
            chartRanked.Location = new Point(12, 100);
            chartRanked.Name = "chartRanked";
            chartRanked.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRanked.Series.Add(series1);
            chartRanked.Size = new Size(549, 509);
            chartRanked.TabIndex = 4;
            // 
            // chartNormal
            // 
            chartNormal.BackColor = Color.RoyalBlue;
            chartArea2.Name = "ChartArea1";
            chartNormal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartNormal.Legends.Add(legend2);
            chartNormal.Location = new Point(567, 100);
            chartNormal.Name = "chartNormal";
            chartNormal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartNormal.Series.Add(series2);
            chartNormal.Size = new Size(549, 509);
            chartNormal.TabIndex = 5;
            chartNormal.TabStop = false;
            // 
            // lstSummary
            // 
            lstSummary.BackColor = Color.RoyalBlue;
            lstSummary.ForeColor = SystemColors.WindowText;
            lstSummary.FormattingEnabled = true;
            lstSummary.ItemHeight = 25;
            lstSummary.Location = new Point(12, 619);
            lstSummary.Name = "lstSummary";
            lstSummary.Size = new Size(1104, 129);
            lstSummary.TabIndex = 200;
            lstSummary.TabStop = false;
            // 
            // txtGameCount
            // 
            txtGameCount.BackColor = Color.RoyalBlue;
            txtGameCount.Location = new Point(582, 37);
            txtGameCount.Name = "txtGameCount";
            txtGameCount.Size = new Size(128, 31);
            txtGameCount.TabIndex = 2;
            txtGameCount.Text = "50";
            // 
            // btnKDA
            // 
            btnKDA.BackColor = Color.RoyalBlue;
            btnKDA.Location = new Point(1130, 100);
            btnKDA.Name = "btnKDA";
            btnKDA.Size = new Size(88, 34);
            btnKDA.TabIndex = 6;
            btnKDA.Text = "KDA";
            btnKDA.UseVisualStyleBackColor = false;
            btnKDA.Click += btnKDA_Click;
            // 
            // btnDamage
            // 
            btnDamage.BackColor = Color.RoyalBlue;
            btnDamage.Location = new Point(1130, 140);
            btnDamage.Name = "btnDamage";
            btnDamage.Size = new Size(88, 34);
            btnDamage.TabIndex = 7;
            btnDamage.Text = "Damage";
            btnDamage.UseVisualStyleBackColor = false;
            btnDamage.Click += btnDamage_Click;
            // 
            // btnCS
            // 
            btnCS.BackColor = Color.RoyalBlue;
            btnCS.Location = new Point(1130, 180);
            btnCS.Name = "btnCS";
            btnCS.Size = new Size(88, 34);
            btnCS.TabIndex = 8;
            btnCS.Text = "CS";
            btnCS.UseVisualStyleBackColor = false;
            btnCS.Click += btnCS_Click;
            // 
            // btnVision
            // 
            btnVision.BackColor = Color.RoyalBlue;
            btnVision.Location = new Point(1130, 220);
            btnVision.Name = "btnVision";
            btnVision.Size = new Size(88, 34);
            btnVision.TabIndex = 9;
            btnVision.Text = "Vision";
            btnVision.UseVisualStyleBackColor = false;
            btnVision.Click += btnVision_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 13;
            label1.Text = "Riot ID ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(410, 9);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 14;
            label2.Text = "Tag Line";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(582, 9);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 15;
            label3.Text = "# of Games";
            // 
            // btnKills
            // 
            btnKills.BackColor = Color.RoyalBlue;
            btnKills.Location = new Point(1130, 260);
            btnKills.Name = "btnKills";
            btnKills.Size = new Size(88, 34);
            btnKills.TabIndex = 201;
            btnKills.Text = "Kills";
            btnKills.UseVisualStyleBackColor = false;
            btnKills.Click += btnKills_Click;
            // 
            // btnDeaths
            // 
            btnDeaths.BackColor = Color.RoyalBlue;
            btnDeaths.Location = new Point(1130, 300);
            btnDeaths.Name = "btnDeaths";
            btnDeaths.Size = new Size(88, 34);
            btnDeaths.TabIndex = 202;
            btnDeaths.Text = "Deaths";
            btnDeaths.UseVisualStyleBackColor = false;
            btnDeaths.Click += btnDeaths_Click;
            // 
            // btnAssists
            // 
            btnAssists.BackColor = Color.RoyalBlue;
            btnAssists.Location = new Point(1130, 340);
            btnAssists.Name = "btnAssists";
            btnAssists.Size = new Size(88, 34);
            btnAssists.TabIndex = 203;
            btnAssists.Text = "Assists";
            btnAssists.UseVisualStyleBackColor = false;
            btnAssists.Click += btnAssists_Click;
            // 
            // panelData
            // 
            panelData.Location = new Point(-17, 100);
            panelData.Name = "panelData";
            panelData.Size = new Size(1255, 664);
            panelData.TabIndex = 204;
            // 
            // RiotForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1230, 759);
            Controls.Add(panelData);
            Controls.Add(btnAssists);
            Controls.Add(btnDeaths);
            Controls.Add(btnKills);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnKills;
        private Button btnDeaths;
        private Button btnAssists;
        private Panel panelData;
    }
}
