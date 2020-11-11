using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool ciz;
        int baslaX, baslaY;
        int kalinlik = 3;
        ColorDialog renksec = new ColorDialog();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //fareye tıklayınca,sürükleyince neler oluyor?

            ciz = true;
            baslaX = e.X; //x koordinatına atadık.
            baslaY = e.Y; //y koordinatına atadık.

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //fareye basılı tutulunca neler yapıyor?

            Graphics g = this.CreateGraphics();
            Pen p = new Pen(renksec.Color, kalinlik);

            Point p1 = new Point(baslaX, baslaY);
            Point p2 = new Point(e.X, e.Y);

            if(ciz==true)
            {
                g.DrawLine(p, p1, p2);
                baslaX = e.X;
                baslaY = e.Y;
            }

            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //basılı mousetan elimizi çekersek.
            ciz = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            renksec.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kalinlik = int.Parse(comboBox1.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
