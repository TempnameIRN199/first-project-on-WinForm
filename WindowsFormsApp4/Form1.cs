using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1() { InitializeComponent(); g = pictureBox1.CreateGraphics(); }
        float y(float x) { return x * x; }
        float Y(float x) { return x * x * x; }

        private void construct(Graphics g)
        {
            Pen myVed = new Pen(Color.Black);
            int k = 100;
            float xMin = 0, xMax = 2, yMax = 4;
            float xStep = (xMax - xMin) / k;
            float kx = pictureBox1.Width / xMax;
            float ky = pictureBox1.Height / yMax;
            float x1 = xMin, y1 = y(x1), x2, y2;
            for (int i = 0; i < k; i++)
            {
                x2 = x1 + xStep;
                y2 = y(x2);
                g.DrawLine(myVed, kx * x1, pictureBox1.Height - ky * y1, kx * x2, pictureBox1.Height - ky * y2 + 1);
                x1 = x2;
                y1 = y2;
            }
        }

        private void constructs(Graphics g)
        {
            Pen myVed = new Pen(Color.Black);
            int k = 100;
            float xMin = 0, xMax = 2, yMax = 4;
            float xStep = (xMax - xMin) / k;
            float kx = pictureBox1.Width / xMax;
            float ky = pictureBox1.Height / yMax;
            float x1 = xMin, y1 = y(x1), x2, y2;
            for (int i = 0; i < k; i++)
            {
                x2 = x1 + xStep;
                y2 = Y(x2);
                g.DrawLine(myVed, kx * x1, pictureBox1.Height - ky * y1, kx * x2, pictureBox1.Height - ky * y2 + 1);
                x1 = x2;
                y1 = y2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Dispose();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) construct(g);
            if (radioButton2.Checked) constructs(g);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Dispose();
        }
    }
}
