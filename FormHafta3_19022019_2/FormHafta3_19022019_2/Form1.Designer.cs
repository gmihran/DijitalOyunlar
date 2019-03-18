namespace FormHafta3_19022019_2
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
            this.components = new System.ComponentModel.Container();
            this.lbs1 = new System.Windows.Forms.Label();
            this.lbi = new System.Windows.Forms.Label();
            this.txts = new System.Windows.Forms.TextBox();
            this.lbs2 = new System.Windows.Forms.Label();
            this.btni = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbs = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbs1
            // 
            this.lbs1.AutoSize = true;
            this.lbs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbs1.Location = new System.Drawing.Point(134, 91);
            this.lbs1.Name = "lbs1";
            this.lbs1.Size = new System.Drawing.Size(122, 42);
            this.lbs1.TabIndex = 0;
            this.lbs1.Text = "Sayı 1";
            // 
            // lbi
            // 
            this.lbi.AutoSize = true;
            this.lbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbi.Location = new System.Drawing.Point(151, 148);
            this.lbi.Name = "lbi";
            this.lbi.Size = new System.Drawing.Size(105, 42);
            this.lbi.TabIndex = 1;
            this.lbi.Text = "İşlem";
            // 
            // txts
            // 
            this.txts.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txts.Location = new System.Drawing.Point(141, 276);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(142, 49);
            this.txts.TabIndex = 2;
            
            // 
            // lbs2
            // 
            this.lbs2.AutoSize = true;
            this.lbs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbs2.Location = new System.Drawing.Point(133, 206);
            this.lbs2.Name = "lbs2";
            this.lbs2.Size = new System.Drawing.Size(122, 42);
            this.lbs2.TabIndex = 3;
            this.lbs2.Text = "Sayı 2";
            // 
            // btni
            // 
            this.btni.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btni.Location = new System.Drawing.Point(33, 352);
            this.btni.Name = "btni";
            this.btni.Size = new System.Drawing.Size(222, 55);
            this.btni.TabIndex = 4;
            this.btni.Text = "İşlem";
            this.btni.UseVisualStyleBackColor = true;
            this.btni.Click += new System.EventHandler(this.btni_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(357, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 42);
            this.label4.TabIndex = 5;
            this.label4.Text = "Puan";
            // 
            // lbp
            // 
            this.lbp.AutoSize = true;
            this.lbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbp.Location = new System.Drawing.Point(481, 81);
            this.lbp.Name = "lbp";
            this.lbp.Size = new System.Drawing.Size(39, 42);
            this.lbp.TabIndex = 6;
            this.lbp.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(357, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 42);
            this.label6.TabIndex = 7;
            this.label6.Text = "Süre";
            // 
            // lbs
            // 
            this.lbs.AutoSize = true;
            this.lbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbs.Location = new System.Drawing.Point(481, 136);
            this.lbs.Name = "lbs";
            this.lbs.Size = new System.Drawing.Size(39, 42);
            this.lbs.TabIndex = 8;
            this.lbs.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "sonuc";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(261, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Yeniden Oyna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btni;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btni);
            this.Controls.Add(this.lbs2);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.lbi);
            this.Controls.Add(this.lbs1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbs1;
        private System.Windows.Forms.Label lbi;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.Label lbs2;
        private System.Windows.Forms.Button btni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

