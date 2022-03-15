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
    public partial class Гусеница : Form
    {
        public Graphics g;
        public Bitmap bitmap;
        public Pen pen;
        public PointFs pointFs = new PointFs();
        public Worm wormy = new Worm();
        public Гусеница()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox1;
            pointFs.pointFss = new PointF[3];

            pointFs.pointFss[0].X = 80;
            pointFs.pointFss[0].Y = 170;

            pointFs.pointFss[1].X = 185;
            pointFs.pointFss[1].Y = 170;

            pointFs.pointFss[2].X = 132;
            pointFs.pointFss[2].Y = 200;

        }

        private void button_g_Click(object sender, EventArgs e)
        {
            wormy.Draw(pointFs);
            foreach (Figure fig in ShapeContainer.container)
            {
                comboBox1.Items.Add(Convert.ToString(fig));
            }
        }
        private void button_del_Click(object sender, EventArgs e)
        {
            if (ShapeContainer.container.Count != 0)
            {
                comboBox1.Items.Remove(Convert.ToString(ShapeContainer.container[ShapeContainer.container.Count - 1]));
                ShapeContainer.DeleteFigure(ShapeContainer.container[ShapeContainer.container.Count - 1]);
            }
            Rectagle rec = new Rectagle(0, 0, 1000, 1000, Brushes.White);
            rec.Draw();
            for (int i = 0; i < ShapeContainer.container.Count; i++)
            {
                ShapeContainer.container[i].Draw();
            }
        }
        private void Гусеница_FormClosing(object sender, FormClosingEventArgs e)
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
