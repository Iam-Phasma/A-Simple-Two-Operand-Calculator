
namespace CalculatorModule
{
    partial class Form1
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.lbl_screen = new System.Windows.Forms.Label();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_devide = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 99);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_1.Location = new System.Drawing.Point(12, 296);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(88, 73);
            this.btn_1.TabIndex = 2;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // lbl_screen
            // 
            this.lbl_screen.AutoSize = true;
            this.lbl_screen.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_screen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_screen.Location = new System.Drawing.Point(17, 37);
            this.lbl_screen.Name = "lbl_screen";
            this.lbl_screen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_screen.Size = new System.Drawing.Size(52, 55);
            this.lbl_screen.TabIndex = 3;
            this.lbl_screen.Text = "0";
            this.lbl_screen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_2.Location = new System.Drawing.Point(106, 296);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(88, 73);
            this.btn_2.TabIndex = 4;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_plus.Location = new System.Drawing.Point(200, 460);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(88, 73);
            this.btn_plus.TabIndex = 5;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_equals
            // 
            this.btn_equals.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equals.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_equals.Location = new System.Drawing.Point(12, 460);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(182, 73);
            this.btn_equals.TabIndex = 6;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = false;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.AllowDrop = true;
            this.btn_clear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clear.Location = new System.Drawing.Point(200, 378);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(88, 73);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_devide
            // 
            this.btn_devide.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_devide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_devide.Location = new System.Drawing.Point(294, 132);
            this.btn_devide.Name = "btn_devide";
            this.btn_devide.Size = new System.Drawing.Size(88, 73);
            this.btn_devide.TabIndex = 8;
            this.btn_devide.Text = "/";
            this.btn_devide.UseVisualStyleBackColor = false;
            this.btn_devide.Click += new System.EventHandler(this.btn_devide_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_multiply.Location = new System.Drawing.Point(294, 214);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(88, 73);
            this.btn_multiply.TabIndex = 9;
            this.btn_multiply.Text = "x";
            this.btn_multiply.UseVisualStyleBackColor = false;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_minus.Location = new System.Drawing.Point(294, 296);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(88, 237);
            this.btn_minus.TabIndex = 10;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_zero.Location = new System.Drawing.Point(12, 378);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(182, 73);
            this.btn_zero.TabIndex = 11;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = false;
            this.btn_zero.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_3.Location = new System.Drawing.Point(200, 296);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(88, 73);
            this.btn_3.TabIndex = 12;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_4.Location = new System.Drawing.Point(12, 214);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(88, 73);
            this.btn_4.TabIndex = 13;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_5.Location = new System.Drawing.Point(106, 214);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(88, 73);
            this.btn_5.TabIndex = 14;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_6.Location = new System.Drawing.Point(200, 214);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(88, 73);
            this.btn_6.TabIndex = 15;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_7.Location = new System.Drawing.Point(12, 132);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(88, 73);
            this.btn_7.TabIndex = 16;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_8.Location = new System.Drawing.Point(106, 132);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(88, 73);
            this.btn_8.TabIndex = 17;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_9.Location = new System.Drawing.Point(200, 132);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(88, 73);
            this.btn_9.TabIndex = 18;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(394, 544);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_devide);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.lbl_screen);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label lbl_screen;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_devide;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
    }
}

