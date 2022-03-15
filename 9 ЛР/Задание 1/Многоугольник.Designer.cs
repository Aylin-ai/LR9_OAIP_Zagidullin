
namespace Задание_1
{
    partial class Многоугольник
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.buttonCreatePoint = new System.Windows.Forms.Button();
            this.button_polygon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_amount = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание многоугольника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите координаты 1-й точки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите координату X";
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(29, 98);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(100, 20);
            this.textBox_X.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите координату Y";
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(29, 137);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(100, 20);
            this.textBox_Y.TabIndex = 6;
            // 
            // buttonCreatePoint
            // 
            this.buttonCreatePoint.BackColor = System.Drawing.Color.White;
            this.buttonCreatePoint.Location = new System.Drawing.Point(11, 163);
            this.buttonCreatePoint.Name = "buttonCreatePoint";
            this.buttonCreatePoint.Size = new System.Drawing.Size(142, 23);
            this.buttonCreatePoint.TabIndex = 7;
            this.buttonCreatePoint.Text = "Добавить точку";
            this.buttonCreatePoint.UseVisualStyleBackColor = false;
            this.buttonCreatePoint.Click += new System.EventHandler(this.buttonCreatePoint_Click);
            // 
            // button_polygon
            // 
            this.button_polygon.BackColor = System.Drawing.Color.White;
            this.button_polygon.Location = new System.Drawing.Point(11, 192);
            this.button_polygon.Name = "button_polygon";
            this.button_polygon.Size = new System.Drawing.Size(142, 23);
            this.button_polygon.TabIndex = 8;
            this.button_polygon.Text = "Нарисовать";
            this.button_polygon.UseVisualStyleBackColor = false;
            this.button_polygon.Click += new System.EventHandler(this.button_polygon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(208, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 429);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(12, 221);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 13;
            this.button_clear.Text = "Очистка";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(15, 46);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(100, 20);
            this.textBox_amount.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Введите количество точек";
            // 
            // button_amount
            // 
            this.button_amount.BackColor = System.Drawing.Color.White;
            this.button_amount.Location = new System.Drawing.Point(121, 44);
            this.button_amount.Name = "button_amount";
            this.button_amount.Size = new System.Drawing.Size(75, 23);
            this.button_amount.TabIndex = 16;
            this.button_amount.Text = "Задать";
            this.button_amount.UseVisualStyleBackColor = false;
            this.button_amount.Click += new System.EventHandler(this.button_amount_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.White;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_back.Location = new System.Drawing.Point(11, 403);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(37, 35);
            this.button_back.TabIndex = 17;
            this.button_back.Text = "<-";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = ">0 and <580";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = ">0 and <429";
            // 
            // Многоугольник
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_polygon);
            this.Controls.Add(this.buttonCreatePoint);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Многоугольник";
            this.Text = "Многоугольник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Многоугольник_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.Button buttonCreatePoint;
        private System.Windows.Forms.Button button_polygon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_amount;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}