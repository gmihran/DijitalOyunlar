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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            lbAd.Text = txtAd.Text;
            MessageBox.Show("Hoşgeldiniz " + txtAd.Text,"Merhaba",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 frm = new Form2();
            frm.ShowDialog();
            
            
        }
    }
}
