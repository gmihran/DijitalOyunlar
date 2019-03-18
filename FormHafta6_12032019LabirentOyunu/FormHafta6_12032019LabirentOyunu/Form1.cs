using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHafta6_12032019LabirentOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Point p;
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(p);
        }
        
        int sure = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            p= labelBasla.Location;
            
            Cursor.Position = PointToScreen(p);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            labelSure.Text = "Süre="+sure.ToString();
            if (sure==20)
            {
                timer1.Enabled = false;
                DialogResult sonuc=MessageBox.Show("Süre bitti. Yenildiniz. Tekrar oynamak ister misiniz?","Oyun Bitti",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (sonuc==DialogResult.Yes)
                {
                    //Oyun devam edecek
                    sure = 0;
                    timer1.Enabled = true;
                    
                }
                else
                {
                    //Oyun bitecek
                    this.Close();
                    Application.Exit();
                }
            }

        }

        private void labelBitis_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler. Kazandınız");
        }
    }
}
