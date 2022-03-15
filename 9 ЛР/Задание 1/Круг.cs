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
    public partial class Круг : Form
    {
        public Graphics g;
        public Bitmap bitmap;
        public Pen pen;
        public Круг()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox1;
        }

        private void button_rec_Click(object sender, EventArgs e)
        {
            if (textBox_X.Text == "" || int.Parse(textBox_X.Text) < 0 || int.Parse(textBox_X.Text) > 623)
                textBox_X.Text = "0";
            if (textBox_Y.Text == "" || int.Parse(textBox_Y.Text) < 0 || int.Parse(textBox_Y.Text) > 432)
                textBox_Y.Text = "0";
            Circle circle = new Circle(int.Parse(textBox_X.Text), int.Parse(textBox_Y.Text), int.Parse(textBox_circle.Text));
            circle.brush = Brushes.Red;
            circle.Draw();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            if (textBox_X.Text == "" || int.Parse(textBox_X.Text) < 0 || int.Parse(textBox_X.Text) > 623)
                textBox_X.Text = "0";
            if (textBox_Y.Text == "" || int.Parse(textBox_Y.Text) < 0 || int.Parse(textBox_Y.Text) > 432)
                textBox_Y.Text = "0";
            Circle circle = new Circle(int.Parse(textBox_X.Text), int.Parse(textBox_Y.Text), int.Parse(textBox_circle.Text));
            circle.brush = Brushes.White;
            circle.Draw();
        }

        private void Круг_FormClosing(object sender, FormClosingEventArgs e)
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
