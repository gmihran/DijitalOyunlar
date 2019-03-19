namespace FormHafta7_19032019
{
    partial class Form1
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
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.btnCoz = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.lblKelime = new System.Windows.Forms.Label();
            this.listA = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listSesli = new System.Windows.Forms.ListBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnSesli = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(31, 18);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(179, 20);
            this.txtSayi1.TabIndex = 0;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(31, 53);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(179, 20);
            this.txtSayi2.TabIndex = 1;
            // 
            // btnCoz
            // 
            this.btnCoz.Location = new System.Drawing.Point(83, 127);
            this.btnCoz.Name = "btnCoz";
            this.btnCoz.Size = new System.Drawing.Size(75, 23);
            this.btnCoz.TabIndex = 2;
            this.btnCoz.Text = "Çöz";
            this.btnCoz.UseVisualStyleBackColor = true;
            this.btnCoz.Click += new System.EventHandler(this.btnCoz_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(56, 95);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(41, 13);
            this.lblDurum.TabIndex = 3;
            this.lblDurum.Text = "Durum:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDurum);
            this.panel1.Controls.Add(this.btnCoz);
            this.panel1.Controls.Add(this.txtSayi2);
            this.panel1.Controls.Add(this.txtSayi1);
            this.panel1.Location = new System.Drawing.Point(15, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 179);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSesli);
            this.panel2.Controls.Add(this.btnA);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.listSesli);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.listA);
            this.panel2.Controls.Add(this.lblKelime);
            this.panel2.Controls.Add(this.txtKelime);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(308, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 220);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelimeyi tersten yazdıran program";
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(96, 58);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(100, 20);
            this.txtKelime.TabIndex = 1;
            this.txtKelime.TextChanged += new System.EventHandler(this.txtKelime_TextChanged);
            this.txtKelime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKelime_KeyPress);
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Location = new System.Drawing.Point(107, 100);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(78, 13);
            this.lblKelime.TabIndex = 2;
            this.lblKelime.Text = "Kelimenin Tersi";
            // 
            // listA
            // 
            this.listA.FormattingEnabled = true;
            this.listA.Location = new System.Drawing.Point(275, 70);
            this.listA.Name = "listA";
            this.listA.Size = new System.Drawing.Size(91, 134);
            this.listA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "\"A\" Harfleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sesli Harfler";
            // 
            // listSesli
            // 
            this.listSesli.FormattingEnabled = true;
            this.listSesli.Location = new System.Drawing.Point(384, 70);
            this.listSesli.Name = "listSesli";
            this.listSesli.Size = new System.Drawing.Size(94, 134);
            this.listSesli.TabIndex = 5;
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(65, 142);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 7;
            this.btnA.Text = "A Harfi";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnSesli
            // 
            this.btnSesli.Location = new System.Drawing.Point(169, 142);
            this.btnSesli.Name = "btnSesli";
            this.btnSesli.Size = new System.Drawing.Size(75, 23);
            this.btnSesli.TabIndex = 8;
            this.btnSesli.Text = "Sesli Harfler";
            this.btnSesli.UseVisualStyleBackColor = true;
            this.btnSesli.Click += new System.EventHandler(this.btnSesli_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Button btnCoz;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSesli;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listSesli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listA;
    }
}

