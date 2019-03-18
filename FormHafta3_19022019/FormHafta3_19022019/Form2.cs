using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHafta3_19022019
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            string mesaj;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);

            if (sayi1 > sayi2)
                mesaj = sayi1 +" "+sayi2+ "'den büyüktür";
            else if (sayi2>sayi1)
                mesaj= sayi2 + " " + sayi1 + "'den büyüktür";
            else
                mesaj= sayi1 + " " + sayi2 + "'e eşittir";
            textBox1.Clear();
            textBox2.Clear();
            
            MessageBox.Show(mesaj, "Karşılaştırma");
            textBox1.Focus();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            float sonuc=0;
            
            try
            {
                sayi1 = Convert.ToInt16(textBox1.Text);
                sayi2 = Convert.ToInt16(textBox2.Text);
                sonuc = sayi1 / sayi2;
                textBox3.Text = Convert.ToString(sonuc);
            }
            catch
            {
                MessageBox.Show("Hatalı değer girdiniz");
            }
            if (sonuc == 2)
                button1.Enabled = false;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        int sayi = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi = sayi + 1;
            lbSure.Text = Convert.ToString(sayi);
            if (sayi == 10)
                timer1.Enabled = false;
        }
    }   
}
