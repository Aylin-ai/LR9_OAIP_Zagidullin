
namespace Задание_1
{
    partial class Гусеница
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
            this.button_g = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_back = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_g
            // 
            this.button_g.BackColor = System.Drawing.Color.White;
            this.button_g.Location = new System.Drawing.Point(12, 12);
            this.button_g.Name = "button_g";
            this.button_g.Size = new System.Drawing.Size(83, 23);
            this.button_g.TabIndex = 0;
            this.button_g.Text = "Нарисовать";
            this.button_g.UseVisualStyleBackColor = false;
            this.button_g.Click += new System.EventHandler(this.button_g_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(101, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 397);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.White;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_back.Location = new System.Drawing.Point(12, 403);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(37, 35);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "<-";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button_del
            // 
            this.button_del.BackColor = System.Drawing.Color.White;
            this.button_del.Location = new System.Drawing.Point(12, 41);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(83, 23);
            this.button_del.TabIndex = 5;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // Гусеница
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_g);
            this.Controls.Add(this.comboBox1);
            this.Name = "Гусеница";
            this.Text = "Гусеница";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Гусеница_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_g;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_del;
    }
}