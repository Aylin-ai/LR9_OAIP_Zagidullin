
namespace Задание_1
{
    partial class Круг
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
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_circle = new System.Windows.Forms.TextBox();
            this.button_rec = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите координату X";
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(12, 25);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(100, 20);
            this.textBox_X.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите координату Y";
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(12, 64);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(100, 20);
            this.textBox_Y.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите размерность круга";
            // 
            // textBox_circle
            // 
            this.textBox_circle.Location = new System.Drawing.Point(12, 103);
            this.textBox_circle.Name = "textBox_circle";
            this.textBox_circle.Size = new System.Drawing.Size(100, 20);
            this.textBox_circle.TabIndex = 8;
            // 
            // button_rec
            // 
            this.button_rec.BackColor = System.Drawing.Color.White;
            this.button_rec.Location = new System.Drawing.Point(12, 129);
            this.button_rec.Name = "button_rec";
            this.button_rec.Size = new System.Drawing.Size(82, 23);
            this.button_rec.TabIndex = 11;
            this.button_rec.Text = "Нарисовать";
            this.button_rec.UseVisualStyleBackColor = false;
            this.button_rec.Click += new System.EventHandler(this.button_rec_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(12, 158);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 13;
            this.button_clear.Text = "Очистка";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(165, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 432);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.White;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_back.Location = new System.Drawing.Point(12, 406);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(37, 35);
            this.button_back.TabIndex = 15;
            this.button_back.Text = "<-";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Круг
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_rec);
            this.Controls.Add(this.textBox_circle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.label1);
            this.Name = "Круг";
            this.Text = "Круг";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Круг_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_circle;
        private System.Windows.Forms.Button button_rec;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_back;
    }
}