namespace YazılımYapımıProjeÖdeviA
{
    partial class Istatistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Istatistik));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mCboxAy = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mCboxYıl = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Goster = new MetroFramework.Controls.MetroButton();
            this.LblÖğrenilen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(722, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.White;
            this.BtnCikis.Image = ((System.Drawing.Image)(resources.GetObject("BtnCikis.Image")));
            this.BtnCikis.Location = new System.Drawing.Point(773, 12);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(20, 20);
            this.BtnCikis.TabIndex = 8;
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 93);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ezberlendi";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(566, 300);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // mCboxAy
            // 
            this.mCboxAy.FormattingEnabled = true;
            this.mCboxAy.ItemHeight = 24;
            this.mCboxAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.mCboxAy.Location = new System.Drawing.Point(642, 118);
            this.mCboxAy.Name = "mCboxAy";
            this.mCboxAy.Size = new System.Drawing.Size(121, 30);
            this.mCboxAy.TabIndex = 11;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(595, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 30);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "AY:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(595, 166);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 30);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "YIL:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mCboxYıl
            // 
            this.mCboxYıl.FormattingEnabled = true;
            this.mCboxYıl.ItemHeight = 24;
            this.mCboxYıl.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020"});
            this.mCboxYıl.Location = new System.Drawing.Point(642, 166);
            this.mCboxYıl.Name = "mCboxYıl";
            this.mCboxYıl.Size = new System.Drawing.Size(121, 30);
            this.mCboxYıl.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(202, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "SON 4 AY:";
            // 
            // Goster
            // 
            this.Goster.Location = new System.Drawing.Point(669, 213);
            this.Goster.Name = "Goster";
            this.Goster.Size = new System.Drawing.Size(75, 23);
            this.Goster.TabIndex = 16;
            this.Goster.Text = "GÖSTER";
            this.Goster.Click += new System.EventHandler(this.Goster_Click);
            // 
            // LblÖğrenilen
            // 
            this.LblÖğrenilen.AutoSize = true;
            this.LblÖğrenilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblÖğrenilen.ForeColor = System.Drawing.Color.Red;
            this.LblÖğrenilen.Location = new System.Drawing.Point(646, 239);
            this.LblÖğrenilen.Name = "LblÖğrenilen";
            this.LblÖğrenilen.Size = new System.Drawing.Size(0, 25);
            this.LblÖğrenilen.TabIndex = 17;
            // 
            // Istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.LblÖğrenilen);
            this.Controls.Add(this.Goster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mCboxYıl);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mCboxAy);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCikis);
            this.DisplayHeader = false;
            this.Name = "Istatistik";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "Istatistik";
            this.Load += new System.EventHandler(this.Istatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroComboBox mCboxAy;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox mCboxYıl;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton Goster;
        private System.Windows.Forms.Label LblÖğrenilen;
    }
}