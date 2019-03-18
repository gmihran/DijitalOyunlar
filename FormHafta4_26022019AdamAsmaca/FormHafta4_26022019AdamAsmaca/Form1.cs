using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHafta4_26022019AdamAsmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kelime;
        int hata = 0;
        private void btnA_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("A");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnA.Enabled = false;
            basari();
           
           
            

        }
        private int harf_kontrol(string harf)
        {
            int kontrol = 0;
            label1.Text = harf;
            for (int i = 0; i < kelime.Length; i++)
            {
                if (String.Compare(harf, kelime.Substring(i, 1)) == 0)
                {
                    label1.Text = harf;
                    switch (i)
                    {
                        case 0: lbl1.Text = harf; break;
                        case 1: lbl2.Text = harf; break;
                        case 2: lbl3.Text = harf; break;
                        case 3: lbl4.Text = harf; break;
                        case 4: lbl5.Text = harf; break;
                        case 5: lbl6.Text = harf; break;
                    }
                    kontrol = 1;
                }
                
            }
                
            return kontrol;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
          
            int kontrol=harf_kontrol("E");
            if (kontrol==0)
            {
                hata++;
                adam_as();
            }
            btnE.Enabled = false;
            basari();
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("K");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnK.Enabled = false;
            basari();
        }
        private void adam_as()
        {
             switch (hata)
            {
                case 1: pictureBox1.Visible = true;break;
                case 2: pictureBox2.Visible = true; break;
                case 3: pictureBox3.Visible = true; break;
                case 4: pictureBox4.Visible = true; break;
                case 5: pictureBox5.Visible = true; break;
                case 6: pictureBox6.Visible = true; break;
                case 7: pictureBox7.Visible = true; break;
                case 8:
                    pictureBox8.Visible = true;
                    DialogResult tercih=MessageBox.Show("Üzgünüm. Yenildiniz.Tekrar oynamak ister misiniz?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (tercih==DialogResult.Yes)
                    {
                        //Oyun tekrar başlayacak
                           
                    }
                    else
                    {
                        Application.Exit();
                    }
                    

                    break;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("B");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnB.Enabled = false;
            basari();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("C");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnC.Enabled = false;
            basari();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("D");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnD.Enabled = false;
            basari();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("F");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnF.Enabled = false;
            basari();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("G");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnG.Enabled = false;
            basari();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("H");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnH.Enabled = false;
            basari();
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("I");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnI.Enabled = false;
            basari();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("L");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnL.Enabled = false;
            basari();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("M");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnM.Enabled = false;
            basari();

        }

        private void btnN_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("N");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnN.Enabled = false;
            basari();

        }

        private void btnO_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("O");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnO.Enabled = false;
            basari();

        }

        private void btnP_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("P");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnP.Enabled = false;
            basari();

        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("R");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnR.Enabled = false;
            basari();

        }

        private void btnS_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("S");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnS.Enabled = false;
            basari();

        }

        private void btnT_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("T");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnT.Enabled = false;
            basari();

        }

        private void btnU_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("U");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnU.Enabled = false;
            basari();

        }

        private void btnV_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("V");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnV.Enabled = false;
            basari();

        }

        private void btnY_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("Y");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnY.Enabled = false;
            basari();

        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            int kontrol = harf_kontrol("Z");
            if (kontrol == 0)
            {
                hata++;
                adam_as();
            }
            btnZ.Enabled = false;
            basari();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] kelimeler = { "KOLTUK", "ARABA", "BUKET", "FURKAN", "YALIN", "ONUR", "DOGAN", "CAN", "KAAN", "GOZDE" };
            Random rnd = new Random();
            int rastgele = rnd.Next(0, 10);
            kelime = kelimeler[rastgele];
            lblKelime.Text = kelime;
            int uzunluk = kelime.Length;
            switch (uzunluk)
            {
                case 5:
                    lbl6.Visible = false;
                    break;
                case 4:
                    lbl6.Visible = false;
                    lbl5.Visible = false;
                    break;
                case 3:
                    lbl6.Visible = false;
                    lbl5.Visible = false;
                    lbl4.Visible = false;
                    break;


            }
        }
        private void basari()
        {
            int uzunluk = kelime.Length;
            bool k = false;
            switch (uzunluk)
            {
                case 6:
                    if (lbl1.Text != "_" && lbl2.Text != "_" && lbl3.Text != "_" && lbl4.Text != "_" && lbl5.Text != "_" && lbl6.Text != "_")
                        k = true;break;
          
                case 5:
                    if (lbl1.Text != "_" && lbl2.Text != "_" && lbl3.Text != "_" && lbl4.Text != "_" && lbl5.Text != "_")
                        k = true; break;
                    
                case 4:
                    if (lbl1.Text != "_" && lbl2.Text != "_" && lbl3.Text != "_" && lbl4.Text != "_")
                        k = true; break;
                case 3:
                    if (lbl1.Text != "_" && lbl2.Text != "_" && lbl3.Text != "_")
                        k = true; break;
            }
                    
            
                if (k==true)
                {
                    DialogResult tercih = MessageBox.Show("Tebrikler Bildiniz. Tekrar oynamak ister misiniz?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (tercih == DialogResult.Yes)
                    {
                        //Oyun tekrar başlayacak

                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                
                
            
        }
    }

}
