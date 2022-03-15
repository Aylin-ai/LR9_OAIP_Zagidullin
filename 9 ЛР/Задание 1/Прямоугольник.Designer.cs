
namespace Задание_1
{
    partial class Прямоугольник
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_back = new System.Windows.Forms.Button();
            this.com = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(131, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 402);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.White;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_back.Location = new System.Drawing.Point(12, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(37, 35);
            this.button_back.TabIndex = 11;
            this.button_back.Text = "<-";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // com
            // 
            this.com.Location = new System.Drawing.Point(55, 12);
            this.com.Name = "com";
            this.com.Size = new System.Drawing.Size(733, 20);
            this.com.TabIndex = 12;
            this.com.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_KeyDown);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 62);
            this.label5.Multiline = true;
            this.label5.Name = "label5";
            this.label5.ReadOnly = true;
            this.label5.Size = new System.Drawing.Size(113, 376);
            this.label5.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "История команд:";
            // 
            // Прямоугольник
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.com);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Прямоугольник";
            this.Text = "Прямоугольник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Прямоугольник_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox com;
        private System.Windows.Forms.TextBox label5;
        private System.Windows.Forms.Label label1;
    }
}