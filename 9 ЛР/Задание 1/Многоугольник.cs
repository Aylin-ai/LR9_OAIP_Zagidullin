using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1
{
    public partial class Многоугольник : Form
    {
        public Graphics g;
        public Bitmap bitmap;
        public Pen pen;
        public PointFs pointFs = new PointFs();
        int i = 0;
        int amount;
        public Многоугольник()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox1;
            button_polygon.Enabled = false;
        }
        private void button_amount_Click(object sender, EventArgs e)
        {
            pointFs.brush = Brushes.Red;
            amount = int.Parse(textBox_amount.Text);
            pointFs.pointFss = new PointF[amount];
            button_amount.Enabled = false;
        }

        private void buttonCreatePoint_Click(object sender, EventArgs e)
        {
            label2.Text = "Введите координаты {i + 2}-й точки";
            pointFs.pointFss[i].X = int.Parse(textBox_X.Text);
            pointFs.pointFss[i].Y = int.Parse(textBox_Y.Text);
            i++;
            if (i == amount)
            {
                label2.Text = "";
                buttonCreatePoint.Enabled = false;
                button_polygon.Enabled = true;
            }
            PointM point = new PointM(int.Parse(textBox_X.Text), int.Parse(textBox_Y.Text), int.Parse(textBox_X.Text), int.Parse(textBox_Y.Text) + 1);
            this.pen = new Pen(Color.Red, 5);
            Init.pen = this.pen;
            point.Draw();
        }

        private void button_polygon_Click(object sender, EventArgs e)
        {
            pointFs.Draw();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            pointFs.brush = Brushes.White;
            pointFs.Draw();
        }

        private void Многоугольник_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form1 one = new Form1();
            one.Show();
            this.Hide();
        }
    }
}
