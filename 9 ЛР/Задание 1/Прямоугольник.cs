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
    public partial class Прямоугольник : Form
    {
        public Graphics g;
        public Bitmap bitmap;
        public Pen pen;
        public Rectagle recrangle;
        public Прямоугольник()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox1;
        }
        public void Chooser()
        {
            try {
                string[] cm = com.Text.Split('[', ']', ';');
                Rectagle rec;
                if (cm[0] == "R")
                {
                    rec = new Rectagle(Convert.ToInt32(cm[2]), Convert.ToInt32(cm[3]), Convert.ToInt32(cm[4]), Convert.ToInt32(cm[5]), Brushes.Black);
                    rec.name = cm[1];
                    rec.Draw();
                    ShapeContainer.AddFigure(rec);
                    label5.Text += $"Прямоугольник {Convert.ToString(rec.name)} успешно нарисован" + '\n';
                }
                else if (cm[0] == "D")
                {
                    for (int i = 0; i < ShapeContainer.container.Count; i++)
                    {
                        if (ShapeContainer.container[i].name == cm[1])
                        {
                            label5.Text += $"Прямоугольник {Convert.ToString(ShapeContainer.container[i].name)} успешно удален" + '\n';
                            ShapeContainer.DeleteFigure(ShapeContainer.container[i]);
                        }
                    }
                    Rectagle rec1 = new Rectagle(0, 0, 1000, 1000, Brushes.White);
                    rec1.Draw();
                    for (int i = 0; i < ShapeContainer.container.Count; i++)
                    {
                        ShapeContainer.container[i].Draw();
                    }
                }
                else if (cm[0] == "M")
                {
                    for (int i = 0; i < ShapeContainer.container.Count; i++)
                    {
                        if (ShapeContainer.container[i].name == cm[1])
                        {
                            ShapeContainer.container[i].x += int.Parse(cm[2]);
                            ShapeContainer.container[i].y += int.Parse(cm[3]);
                            label5.Text += $"Прямоугольник {Convert.ToString(ShapeContainer.container[i].name)} успешно перемещен на ({cm[2]}, {cm[3]})" + '\n';
                        }
                    }
                    Rectagle rec1 = new Rectagle(0, 0, 1000, 1000, Brushes.White);
                    rec1.Draw();
                    for (int i = 0; i < ShapeContainer.container.Count; i++)
                    {
                        ShapeContainer.container[i].Draw();
                    }
                }
                else
                    label5.Text += $"Команда ({com.Text}) введена неккоректно" + '\n';
            }
            catch
            {
                label5.Text += $"Команда ({com.Text}) введена неккоректно" + '\n';
            }
        }
        private void Прямоугольник_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form1 one = new Form1();
            one.Show();
            this.Hide();
        }

        private void com_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                Chooser();
            }
        }
    }
}
