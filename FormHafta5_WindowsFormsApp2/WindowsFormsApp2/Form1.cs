using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 4,sayac2=3;
            int[] dizi = new int[5];
            int[] dizi2 = { 10, 20, 30, 40 };
            foreach (Control x in this.Controls)
            {
                if (x is Label)
                {
                    x.Text = sayac.ToString();
                    sayac--;
                }
                if (x is TextBox)
                {
                    
                    x.Text = dizi2[sayac2].ToString();
                    sayac2--;
                }
            }
            int toplam = 0; 
            foreach (int y in dizi2)
            {
                toplam += y;
            }
            MessageBox.Show(toplam.ToString());
            
        }
    }
}
