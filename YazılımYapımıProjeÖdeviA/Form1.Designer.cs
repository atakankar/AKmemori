namespace YazılımYapımıProjeÖdeviA
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.buttonOgren = new System.Windows.Forms.Button();
            this.buttonHazine = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonIstatistik = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOgren
            // 
            this.buttonOgren.Image = ((System.Drawing.Image)(resources.GetObject("buttonOgren.Image")));
            this.buttonOgren.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOgren.Location = new System.Drawing.Point(110, 109);
            this.buttonOgren.Name = "buttonOgren";
            this.buttonOgren.Size = new System.Drawing.Size(120, 120);
            this.buttonOgren.TabIndex = 0;
            this.buttonOgren.Text = "ÖĞRENMEYE BAŞLA";
            this.buttonOgren.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOgren.UseVisualStyleBackColor = true;
            this.buttonOgren.Click += new System.EventHandler(this.buttonOgren_Click);
            // 
            // buttonHazine
            // 
            this.buttonHazine.Image = ((System.Drawing.Image)(resources.GetObject("buttonHazine.Image")));
            this.buttonHazine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHazine.Location = new System.Drawing.Point(570, 109);
            this.buttonHazine.Name = "buttonHazine";
            this.buttonHazine.Size = new System.Drawing.Size(120, 120);
            this.buttonHazine.TabIndex = 1;
            this.buttonHazine.Text = "ÖĞRENME HAZİNESİ";
            this.buttonHazine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHazine.UseVisualStyleBackColor = true;
            this.buttonHazine.Click += new System.EventHandler(this.buttonHazine_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Image = ((System.Drawing.Image)(resources.GetObject("buttonEkle.Image")));
            this.buttonEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEkle.Location = new System.Drawing.Point(225, 275);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(120, 120);
            this.buttonEkle.TabIndex = 2;
            this.buttonEkle.Text = "YENİ KELİME EKLE";
            this.buttonEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(771, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 20);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonIstatistik
            // 
            this.buttonIstatistik.Image = ((System.Drawing.Image)(resources.GetObject("buttonIstatistik.Image")));
            this.buttonIstatistik.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonIstatistik.Location = new System.Drawing.Point(455, 275);
            this.buttonIstatistik.Name = "buttonIstatistik";
            this.buttonIstatistik.Size = new System.Drawing.Size(120, 120);
            this.buttonIstatistik.TabIndex = 4;
            this.buttonIstatistik.Text = "ÖĞRENME İSTATİSTİKLERİ";
            this.buttonIstatistik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonIstatistik.UseVisualStyleBackColor = true;
            this.buttonIstatistik.Click += new System.EventHandler(this.buttonIstatistik_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Image = ((System.Drawing.Image)(resources.GetObject("buttonTest.Image")));
            this.buttonTest.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTest.Location = new System.Drawing.Point(340, 109);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(120, 120);
            this.buttonTest.TabIndex = 5;
            this.buttonTest.Text = "TEST ET";
            this.buttonTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonIstatistik);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.buttonHazine);
            this.Controls.Add(this.buttonOgren);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "Anasayfa";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "AKMemori";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOgren;
        private System.Windows.Forms.Button buttonHazine;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonIstatistik;
        private System.Windows.Forms.Button buttonTest;
    }
}

