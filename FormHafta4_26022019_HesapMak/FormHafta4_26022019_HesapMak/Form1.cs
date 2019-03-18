using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHafta4_26022019_HesapMak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(txtSayi.Text!="0")
                txtSayi.Text += 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            sifir_kontrol();
            txtSayi.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            sifir_kontrol();
            txtSayi.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            sifir_kontrol();
            txtSayi.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            sifir_kontrol();
            txtSayi.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            sifir_kontrol();
            txtSayi.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            sifir_kontrol();
            txtSayi.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            sifir_kontrol();
            txtSayi.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            sifir_kontrol();
            txtSayi.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            sifir_kontrol();
            txtSayi.Text += 9;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            sifir_kontrol();
            txtSayi.Clear();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtSayi.Clear();
            txtSonuc.Clear();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1, sayi2;
                sayi1 = Convert.ToInt16(txtSayi.Text);
                if (txtSonuc.Text == "")
                    sayi2 = 0;
                else
                    sayi2 = Convert.ToInt16(txtSonuc.Text);
                txtSonuc.Text = (sayi2 + sayi1).ToString();
            }
            catch (Exception)
            {

                
            }
            finally
            {
                txtSayi.Clear();
            }
            
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1, sayi2;
                sayi1 = Convert.ToInt16(txtSayi.Text);
                if (txtSonuc.Text == "")
                    txtSonuc.Text = txtSayi.Text;
                else
                {
                    sayi2 = Convert.ToInt16(txtSonuc.Text);
                    txtSonuc.Text = (sayi2 - sayi1).ToString();
                }
            }
            catch (Exception)
            {

                
            }
            finally
            {
                txtSayi.Clear();
            }
           
                
            
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1, sayi2;
                sayi1 = Convert.ToInt16(txtSayi.Text);
                if (txtSonuc.Text == "")
                    sayi2 = 1;
                else
                    sayi2 = Convert.ToInt16(txtSonuc.Text);
                txtSonuc.Text = (sayi2 * sayi1).ToString();
            }
            catch (Exception)
            {

                
            }
           finally
            {
                txtSayi.Clear();
            }
            
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1, sayi2;
                sayi1 = Convert.ToInt16(txtSayi.Text);
                if (txtSonuc.Text == "")
                    txtSonuc.Text = txtSayi.Text;
                else
                {
                    sayi2 = Convert.ToInt16(txtSonuc.Text);
                    txtSonuc.Text = (sayi2 / sayi1).ToString();
                }
            }
            catch (Exception)
            {

                
            }
            finally
            {
                txtSayi.Clear();
            }
                
            
        }
        private void sifir_kontrol()
        {
            if (txtSayi.Text == "0")
                txtSayi.Clear();
        }
    }
}
