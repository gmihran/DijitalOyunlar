using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHafta5_05032019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        private void Form1_Load(object sender, EventArgs e)
        {
            a = 0;
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //a++;
            //MessageBox.Show("sayı="+a);
            Point point=this.PointToClient(Cursor.Position);
            MessageBox.Show(point.ToString());
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Fare ile kontrol üzerinde hareket ettirildiğinde çalışır.
            Point point = this.PointToClient(Cursor.Position);
            lb1.Text = point.ToString();
            label2.Text = "X="+point.X.ToString();
            label3.Text = "Y="+point.Y.ToString();
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = this.PointToClient(Cursor.Position);
            label4.Text = point.ToString();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            
            label5.Text = "x="+x+" y="+y;

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = this.Width;
            int y = this.Height;
            int ballx = pictureBox3.Width;
            int bally = pictureBox3.Height;
            if (e.KeyCode == Keys.Left && pictureBox3.Location.X >= 0)
            {
                pictureBox3.Left -= 10;
            }
            //if (e.KeyCode == Keys.Right && pictureBox3.Location.X <= 780)
            if (e.KeyCode==Keys.Right && pictureBox3.Location.X+ballx*1.5 <=x )
            {
                pictureBox3.Left += 10;
            }
            if (e.KeyCode == Keys.Up && pictureBox3.Location.Y >= 0)
            {
                pictureBox3.Top -= 10;
            }
            
            lb1.Text = "Y=" + pictureBox3.Location.Y.ToString();
            label2.Text = "X=" + pictureBox3.Location.X.ToString();
            label3.Text = "Width=" + pictureBox3.Width.ToString();
            label4.Text = "Height=" + pictureBox3.Height.ToString();
            //if (e.KeyCode == Keys.Down && pictureBox3.Location.Y<=570)
            if (e.KeyCode == Keys.Down && pictureBox3.Location.Y+bally*2 <= y)
            {
                pictureBox3.Top += 10;
            }
        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }
    }
}
