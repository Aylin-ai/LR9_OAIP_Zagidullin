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
    public partial class Квадрат : Form
    {
        public Graphics g;
        public Bitmap bitmap;
        public Pen pen;
        public Square square;
        public Квадрат()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox1;
        }

        private void button_rec_Click(object sender, EventArgs e)
        {
            if (textBox_X.Text == "" || int.Parse(textBox_X.Text) < 0 || int.Parse(textBox_X.Text) > 604)
                textBox_X.Text = "0";
            if (textBox_Y.Text == "" || int.Parse(textBox_Y.Text) < 0 || int.Parse(textBox_Y.Text) > 429)
                textBox_Y.Text = "0";
            square = new Square(int.Parse(textBox_X.Text), int.Parse(textBox_Y.Text), int.Parse(textBox_square.Text), Brushes.Red);
            square.Draw();
        }
        private void button_clear_Click_1(object sender, EventArgs e)
        {
            if (textBox_X.Text == "" || int.Parse(textBox_X.Text) < 0 || int.Parse(textBox_X.Text) > 604)
                textBox_X.Text = "0";
            if (textBox_Y.Text == "" || int.Parse(textBox_Y.Text) < 0 || int.Parse(textBox_Y.Text) > 429)
                textBox_Y.Text = "0";
            square = new Square(int.Parse(textBox_X.Text), int.Parse(textBox_Y.Text), int.Parse(textBox_square.Text), Brushes.White);
            square.Draw();
        }

        private void Квадрат_FormClosing(object sender, FormClosingEventArgs e)
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
