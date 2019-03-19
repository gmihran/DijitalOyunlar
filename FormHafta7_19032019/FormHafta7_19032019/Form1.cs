using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHafta7_19032019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCoz_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt16(txtSayi1.Text);
                int sayi2 = Convert.ToInt16(txtSayi2.Text);

                if (sayi1 > sayi2)
                {
                    lblDurum.Text = "Durum=1.sayı büyüktür";
                }
                else if (sayi1 < sayi2)
                {
                    lblDurum.Text = "Durum=2.sayı büyüktür";
                }
                else
                {
                    lblDurum.Text = "Durum=Sayılar birbirine eşit";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı değer girdiniz", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }



        }

        private void txtKelime_KeyPress(object sender, KeyPressEventArgs e)
        {



            
        }

        private void txtKelime_TextChanged(object sender, EventArgs e)
        {

            /*1.yöntem for döngüsü
            lblKelime.Text = "";
            string kelime = txtKelime.Text;

            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                lblKelime.Text += kelime[i];

            }
            */
            //2.yöntem harfleri diziye atamak
            lblKelime.Text = "";
            string kelime = txtKelime.Text;
            char[] harfler = kelime.ToCharArray();
            Array.Reverse(harfler);
            lblKelime.Text = new string(harfler);
           
           
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            string kelime = lblKelime.Text;
            listA.Items.Clear();
            int sayac = 0;
            for(int i=0;i<kelime.Length;i++)
            {
                if (kelime[i]=='A' || kelime[i]=='a')
                {
                    listA.Items.Add(kelime[i]);
                    sayac++;
                }
            }
            if (sayac!=0)
            {
                listA.Items.Add(sayac + " tane \"a\" harfi var");
                listA.Items.Add(sayac + " tane 'a' harfi var");
            }
        }
        private void btnSesli_Click(object sender, EventArgs e)
        {
            string kelime = txtKelime.Text;
            char[] sesli = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            //Kelimenin tüm harflerine bakarak sesli dizisindeki 
            //herhangi bir harfi içeriyor mu?
            listSesli.Items.Clear();
            foreach (char harf in kelime)
            {
                foreach (char sesliharf in sesli)
                {
                    if (harf==sesliharf)
                    {
                        listSesli.Items.Add(sesliharf);
                        break;
                    }
                }
            }
        }
        string parola;
        private void button1_Click(object sender, EventArgs e)
        {
            //parola = textBox1.Text;
            if (textBox1.Text == textBox3.Text)
                //Parola oluşturuldu
                parola = textBox3.Text;
            
            if ((textBox1.Text=="Admin"&&textBox2.Text=="Admin")||(textBox1.Text=="Guest" && textBox2.Text=="123"))
            {
                //Giriş yapılıyor
                
                Form2 form = new Form2();
                
                form.Show();
                this.Hide();
             


            }
        }
    }

        
}
