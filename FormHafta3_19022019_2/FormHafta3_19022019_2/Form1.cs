using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHafta3_19022019_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sure = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            lbs.Text = Convert.ToString(sure);
            if (sure==10)
            {
                timer1.Enabled = false;
                MessageBox.Show("Süre sona erdi.", "Bilemediniz",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                MessageBox.Show("Puanınız:" + puan,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
        }
        int sayi1, sayi2, islem,sonuc,puan=0;

        private void button1_Click(object sender, EventArgs e)
        {
            sure = 0;
            puan = 0;
            sayiuret();
            txts.Clear();
            timer1.Enabled = true;
            lbp.Text = Convert.ToString(puan);
            
        }
        

        private void btni_Click(object sender, EventArgs e)
        {
            kontrol_et();
        }
        private void kontrol_et()
        {
            int ksonuc;
            ksonuc = Convert.ToInt16(txts.Text);
            if (ksonuc == sonuc)
            {
                puan += 10;
            }
            else
            {
                puan -= 15;
                timer1.Interval -= 20;
                //Süreyi hızlandırdık
            }
            txts.Clear();
            sure = 0;
            lbp.Text = Convert.ToString(puan);
            if (puan >= 50)
            {
                timer1.Enabled = false;
                MessageBox.Show("Tebrikler Kazandınız.", "Tebrikler");
            }
            else
                sayiuret();
            txts.Focus();
        }

        string s_islem;
        public void sayiuret()
        {
            
            Random rnd = new Random();
            sayi1 = rnd.Next() % 10 + 1;
            sayi2 = rnd.Next() % 10 + 1;
            islem = rnd.Next() % 4 + 1;
            lbs1.Text = Convert.ToString(sayi1);
            lbs2.Text = Convert.ToString(sayi2);
            switch (islem)
            {
                case 1: s_islem = "+"; sonuc = sayi1 + sayi2; break;
                case 2: s_islem = "-"; sonuc = sayi1 - sayi2; break;
                case 3: s_islem = "*"; sonuc = sayi1 * sayi2; break;
                case 4: s_islem = "/"; sonuc = sayi1 / sayi2; break;
            }
            lbi.Text = s_islem;
            label1.Text = Convert.ToString(sonuc);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            sayiuret();
        }
    }
}
