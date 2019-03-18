using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHafta2_12022019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            
            lblAd.Text = "Hoşgeldin " +txtAd.Text ;
            lblAd.Visible = true;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt16(txtSayi1.Text);
            sayi2 = Convert.ToInt16(txtSayi2.Text);
            txtSonuc.Text = Convert.ToString(sayi1 + sayi2);

            lblSonuc.Text = Convert.ToString(Convert.ToInt16(txtSayi1.Text) + Convert.ToInt16(txtSayi2.Text));
        }
    }
}
