using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = false;
            timer1.Interval = 100;
        }
        float xz, yz;
        float one;
        float rz;
        float wz, hz;
        int k = 0;
        float teta0 = (float)(5 * Math.PI / 4);
        float R0;
        float rs;
        float ws, hs;

        private void pictureData()
        {
            xz = pictureBox1.Size.Width / 2;
            yz = pictureBox1.Size.Height / 2;
            one = Math.Min(xz, yz) / kOne;
            rz = one * kz;
            wz = xz - rz;
            hz = yz - rz;
            rs = one * ks;
            ws = wz;
            hs = hz;
            float R;
            R0 = (float)Math.Sqrt((ws - xz) * (ws - xz) + (hs - yz)*(hs - yz));
            float dR = one * kr;
            R = Math.Min(R0 + k * dR, one * 80);
            if(u)
            {
                k = k / 2;
                ws = (float)(R * Math.Cos(teta0 + k * dt)) + xz;
                hs = (float)(R * Math.Sin(teta0 + k * dt)) + yz;
            }
            else
            {
                ws = (float)(R * Math.Cos(teta0 + k * dt)) + xz;
                hs = (float)(R * Math.Sin(teta0 + k * dt)) + yz;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureData();
            k++;
            pictureBox1.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!timer1.Enabled)
                pictureData();
            pictureBox1.Refresh();
        }
        bool u = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text== "Посадка")
            {
                u = true;      
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Посадка";
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics target = e.Graphics;
            Pen blackPen = new Pen(Color.Black);
            Pen greenPen = new Pen(Color.Green);
            target.FillEllipse(blackPen.Brush,ws,hs,2*rs,2*rs);
            target.FillEllipse(greenPen.Brush, wz, hz, 2 * rz, 2 * rz);
        }

        float dt = (float)(Math.PI / 100);
        int kz = 15, ks = 4, kr = 1, kOne = 100;

    }
}
