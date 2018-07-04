namespace ARTYOMiNIKITIKUS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Plus = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Abs = new System.Windows.Forms.Button();
            this.Tg = new System.Windows.Forms.Button();
            this.Ctg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Orange;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Orange;
            this.textBox2.Location = new System.Drawing.Point(12, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.Red;
            this.Plus.Location = new System.Drawing.Point(12, 70);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(46, 23);
            this.Plus.TabIndex = 3;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.TextChanged += new System.EventHandler(this.button_Click);
            this.Plus.Click += new System.EventHandler(this.button_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.BackColor = System.Drawing.Color.Red;
            this.Multiplication.Location = new System.Drawing.Point(64, 70);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(46, 23);
            this.Multiplication.TabIndex = 4;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = false;
            this.Multiplication.Click += new System.EventHandler(this.button_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.Red;
            this.Minus.Location = new System.Drawing.Point(12, 99);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(46, 23);
            this.Minus.TabIndex = 5;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.button_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.Color.Red;
            this.Division.Location = new System.Drawing.Point(64, 99);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(46, 23);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(155, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 46);
            this.label1.TabIndex = 7;
            // 
            // Sin
            // 
            this.Sin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Sin.Location = new System.Drawing.Point(158, 70);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(46, 23);
            this.Sin.TabIndex = 8;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = false;
            this.Sin.TextChanged += new System.EventHandler(this.button1_Click);
            this.Sin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cos
            // 
            this.Cos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Cos.Location = new System.Drawing.Point(210, 70);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(46, 23);
            this.Cos.TabIndex = 9;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = false;
            this.Cos.TextChanged += new System.EventHandler(this.button1_Click);
            this.Cos.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Sqrt.Location = new System.Drawing.Point(158, 99);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(46, 23);
            this.Sqrt.TabIndex = 10;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = false;
            this.Sqrt.TextChanged += new System.EventHandler(this.button1_Click);
            this.Sqrt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Abs
            // 
            this.Abs.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Abs.Location = new System.Drawing.Point(210, 99);
            this.Abs.Name = "Abs";
            this.Abs.Size = new System.Drawing.Size(46, 23);
            this.Abs.TabIndex = 11;
            this.Abs.Text = "Abs";
            this.Abs.UseVisualStyleBackColor = false;
            this.Abs.TextChanged += new System.EventHandler(this.button1_Click);
            this.Abs.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tg
            // 
            this.Tg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Tg.Location = new System.Drawing.Point(158, 128);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(46, 23);
            this.Tg.TabIndex = 12;
            this.Tg.Text = "Tg";
            this.Tg.UseVisualStyleBackColor = false;
            this.Tg.TextChanged += new System.EventHandler(this.button1_Click);
            this.Tg.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ctg
            // 
            this.Ctg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Ctg.Location = new System.Drawing.Point(210, 128);
            this.Ctg.Name = "Ctg";
            this.Ctg.Size = new System.Drawing.Size(46, 23);
            this.Ctg.TabIndex = 13;
            this.Ctg.Text = "Ctg";
            this.Ctg.UseVisualStyleBackColor = false;
            this.Ctg.TextChanged += new System.EventHandler(this.button1_Click);
            this.Ctg.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Ctg);
            this.Controls.Add(this.Tg);
            this.Controls.Add(this.Abs);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Abs;
        private System.Windows.Forms.Button Tg;
        private System.Windows.Forms.Button Ctg;
    }
}

