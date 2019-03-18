using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHafta4_26022019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt16(txtSayi.Text);
             
                if (sayi < 0 || sayi > 100)
                    throw new FormatException();
                lblSonuc.Text = Convert.ToString(sayi * sayi);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
                
            }
     
            
        }

        private void btnBolum_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt16(txtSayi1.Text);
                int sayi2 = Convert.ToInt16(txtSayi2.Text);
                lblSonuc2.Text = Convert.ToString(sayi1 / sayi2);
                //lblSonuc2.Text = (sayi1 / sayi2).ToString();
                listSayilar.Items.Add(lblSonuc2.Text);
                
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Bir sayı sıfıra bölünemez", "Sıfıra Bölünme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                txtSayi1.Clear();
                txtSayi2.Clear();
                //txtSayi1.Text = "";
                
                
            }

        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            listSayilar.Items.Clear(); //listbox içindeki değerleri siler
            int bas, bit, miktar,i,sayi,x;
            try
            {
                bas = Convert.ToInt16(txtBas.Text);
                bit = Convert.ToInt16(txtBit.Text);
                if (bas > bit)
                {
                    x = bas;
                    bas = bit;
                    bit = x;
                }
                miktar = Convert.ToInt16(txtMiktar.Text);
                Random rnd = new Random();
                for (i = 1; i <= miktar; i++)
                {
                    //sayi = rnd.Next() % (bit-bas+1) + bas;
                    sayi = rnd.Next(bas, bit + 1);
                    listSayilar.Items.Add(sayi);
                }
                btnKontrol.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz");   
            }
            finally
            {
                txtBas.Clear();
                txtBit.Clear();
                txtMiktar.Clear();
            }
            
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            int i,sayi;
            for (i=0;i<=listSayilar.Items.Count-1;i++)
            {
                sayi = Convert.ToInt16(listSayilar.Items[i]);
           
                if (sayi%2==0)
                {
                    list2.Items.Add(sayi);
                }
                if (sayi%3==0)
                {
                    list3.Items.Add(sayi);
                }
                asalsayi();
            }
        }

        private void asalsayi()
        {
            int i,j,sayi;
            bool kontrol=true; //Eğer true ise asaldır
            listAsal.Items.Clear();
            for (i = 0; i <= listSayilar.Items.Count - 1; i++)
            {
                
                sayi = Convert.ToInt16(listSayilar.Items[i]);
                if (sayi == 1)
                    kontrol = false;
                else
                {
                    for (j = 2; j <= (sayi / 2); j++)
                    {
                        if (sayi % j == 0)
                        {
                            kontrol = false; //Eğer false ise asal değildir
                            break;
                        }
                    }
                }
                
                if (kontrol) //kontrol true ise çalışır
                {
                    listAsal.Items.Add(sayi);
                }
                kontrol = true;
            }
        }
    }
}
