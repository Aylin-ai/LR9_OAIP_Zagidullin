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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Прямоугольник rec = new Прямоугольник();
            rec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Квадрат sq = new Квадрат();
            sq.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Эллипс el = new Эллипс();
            el.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Круг cir = new Круг();
            cir.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Многоугольник mnogo = new Многоугольник();
            mnogo.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Гусеница gus = new Гусеница();
            gus.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
