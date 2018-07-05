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
            this.ArcCos = new System.Windows.Forms.Button();
            this.ArcSin = new System.Windows.Forms.Button();
            this.LgX = new System.Windows.Forms.Button();
            this.ngradeX = new System.Windows.Forms.Button();
            this.TengradeX = new System.Windows.Forms.Button();
            this.TwogradeX = new System.Windows.Forms.Button();
            this.LnX = new System.Windows.Forms.Button();
            this.XgradeTwo = new System.Windows.Forms.Button();
            this.ArcCtg = new System.Windows.Forms.Button();
            this.ArcTg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Orange;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 33);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Orange;
            this.textBox2.Location = new System.Drawing.Point(12, 65);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 35);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Plus.Location = new System.Drawing.Point(12, 123);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(46, 48);
            this.Plus.TabIndex = 3;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.TextChanged += new System.EventHandler(this.button_Click);
            this.Plus.Click += new System.EventHandler(this.button_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Multiplication.Location = new System.Drawing.Point(64, 123);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(46, 48);
            this.Multiplication.TabIndex = 4;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = false;
            this.Multiplication.Click += new System.EventHandler(this.button_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Minus.Location = new System.Drawing.Point(12, 177);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(46, 48);
            this.Minus.TabIndex = 5;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.button_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Division.Location = new System.Drawing.Point(64, 177);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(46, 48);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(292, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 85);
            this.label1.TabIndex = 7;
            // 
            // Sin
            // 
            this.Sin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Sin.Location = new System.Drawing.Point(116, 123);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(46, 48);
            this.Sin.TabIndex = 8;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = false;
            this.Sin.TextChanged += new System.EventHandler(this.button1_Click);
            this.Sin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cos
            // 
            this.Cos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Cos.Location = new System.Drawing.Point(168, 123);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(46, 48);
            this.Cos.TabIndex = 9;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = false;
            this.Cos.TextChanged += new System.EventHandler(this.button1_Click);
            this.Cos.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Sqrt.Location = new System.Drawing.Point(220, 123);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(46, 48);
            this.Sqrt.TabIndex = 10;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = false;
            this.Sqrt.TextChanged += new System.EventHandler(this.button1_Click);
            this.Sqrt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Abs
            // 
            this.Abs.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Abs.Location = new System.Drawing.Point(220, 177);
            this.Abs.Name = "Abs";
            this.Abs.Size = new System.Drawing.Size(46, 48);
            this.Abs.TabIndex = 11;
            this.Abs.Text = "Abs";
            this.Abs.UseVisualStyleBackColor = false;
            this.Abs.TextChanged += new System.EventHandler(this.button1_Click);
            this.Abs.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tg
            // 
            this.Tg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Tg.Location = new System.Drawing.Point(116, 177);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(46, 48);
            this.Tg.TabIndex = 12;
            this.Tg.Text = "Tg";
            this.Tg.UseVisualStyleBackColor = false;
            this.Tg.TextChanged += new System.EventHandler(this.button1_Click);
            this.Tg.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ctg
            // 
            this.Ctg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Ctg.Location = new System.Drawing.Point(168, 177);
            this.Ctg.Name = "Ctg";
            this.Ctg.Size = new System.Drawing.Size(46, 48);
            this.Ctg.TabIndex = 13;
            this.Ctg.Text = "Ctg";
            this.Ctg.UseVisualStyleBackColor = false;
            this.Ctg.TextChanged += new System.EventHandler(this.button1_Click);
            this.Ctg.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArcCos
            // 
            this.ArcCos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ArcCos.Location = new System.Drawing.Point(430, 177);
            this.ArcCos.Name = "ArcCos";
            this.ArcCos.Size = new System.Drawing.Size(55, 48);
            this.ArcCos.TabIndex = 16;
            this.ArcCos.Text = "ArcCos";
            this.ArcCos.UseVisualStyleBackColor = false;
            this.ArcCos.TextChanged += new System.EventHandler(this.button1_Click);
            this.ArcCos.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArcSin
            // 
            this.ArcSin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ArcSin.Location = new System.Drawing.Point(428, 123);
            this.ArcSin.Name = "ArcSin";
            this.ArcSin.Size = new System.Drawing.Size(57, 48);
            this.ArcSin.TabIndex = 14;
            this.ArcSin.Text = "ArcSin";
            this.ArcSin.UseVisualStyleBackColor = false;
            this.ArcSin.TextChanged += new System.EventHandler(this.button1_Click);
            this.ArcSin.Click += new System.EventHandler(this.button1_Click);
            // 
            // LgX
            // 
            this.LgX.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LgX.Location = new System.Drawing.Point(324, 177);
            this.LgX.Name = "LgX";
            this.LgX.Size = new System.Drawing.Size(46, 48);
            this.LgX.TabIndex = 24;
            this.LgX.Text = "Lg(x)";
            this.LgX.UseVisualStyleBackColor = false;
            this.LgX.TextChanged += new System.EventHandler(this.button1_Click);
            this.LgX.Click += new System.EventHandler(this.button1_Click);
            // 
            // ngradeX
            // 
            this.ngradeX.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ngradeX.Location = new System.Drawing.Point(272, 177);
            this.ngradeX.Name = "ngradeX";
            this.ngradeX.Size = new System.Drawing.Size(46, 48);
            this.ngradeX.TabIndex = 23;
            this.ngradeX.Text = "n^x";
            this.ngradeX.UseVisualStyleBackColor = false;
            this.ngradeX.TextChanged += new System.EventHandler(this.button_Click);
            this.ngradeX.Click += new System.EventHandler(this.button_Click);
            // 
            // TengradeX
            // 
            this.TengradeX.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TengradeX.Location = new System.Drawing.Point(376, 177);
            this.TengradeX.Name = "TengradeX";
            this.TengradeX.Size = new System.Drawing.Size(46, 48);
            this.TengradeX.TabIndex = 22;
            this.TengradeX.Text = "10^x";
            this.TengradeX.UseVisualStyleBackColor = false;
            this.TengradeX.TextChanged += new System.EventHandler(this.button1_Click);
            this.TengradeX.Click += new System.EventHandler(this.button1_Click);
            // 
            // TwogradeX
            // 
            this.TwogradeX.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TwogradeX.Location = new System.Drawing.Point(376, 123);
            this.TwogradeX.Name = "TwogradeX";
            this.TwogradeX.Size = new System.Drawing.Size(46, 48);
            this.TwogradeX.TabIndex = 21;
            this.TwogradeX.Text = "2^x";
            this.TwogradeX.UseVisualStyleBackColor = false;
            this.TwogradeX.TextChanged += new System.EventHandler(this.button1_Click);
            this.TwogradeX.Click += new System.EventHandler(this.button1_Click);
            // 
            // LnX
            // 
            this.LnX.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LnX.Location = new System.Drawing.Point(324, 123);
            this.LnX.Name = "LnX";
            this.LnX.Size = new System.Drawing.Size(46, 48);
            this.LnX.TabIndex = 20;
            this.LnX.Text = "Ln(x)";
            this.LnX.UseVisualStyleBackColor = false;
            this.LnX.TextChanged += new System.EventHandler(this.button1_Click);
            this.LnX.Click += new System.EventHandler(this.button1_Click);
            // 
            // XgradeTwo
            // 
            this.XgradeTwo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.XgradeTwo.Location = new System.Drawing.Point(272, 123);
            this.XgradeTwo.Name = "XgradeTwo";
            this.XgradeTwo.Size = new System.Drawing.Size(46, 48);
            this.XgradeTwo.TabIndex = 19;
            this.XgradeTwo.Text = "x^2";
            this.XgradeTwo.UseVisualStyleBackColor = false;
            this.XgradeTwo.TextChanged += new System.EventHandler(this.button1_Click);
            this.XgradeTwo.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArcCtg
            // 
            this.ArcCtg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ArcCtg.Location = new System.Drawing.Point(491, 176);
            this.ArcCtg.Name = "ArcCtg";
            this.ArcCtg.Size = new System.Drawing.Size(55, 48);
            this.ArcCtg.TabIndex = 18;
            this.ArcCtg.Text = "ArcCtg";
            this.ArcCtg.UseVisualStyleBackColor = false;
            this.ArcCtg.TextChanged += new System.EventHandler(this.button1_Click);
            this.ArcCtg.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArcTg
            // 
            this.ArcTg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ArcTg.Location = new System.Drawing.Point(491, 122);
            this.ArcTg.Name = "ArcTg";
            this.ArcTg.Size = new System.Drawing.Size(55, 48);
            this.ArcTg.TabIndex = 17;
            this.ArcTg.Text = "ArcTg";
            this.ArcTg.UseVisualStyleBackColor = false;
            this.ArcTg.TextChanged += new System.EventHandler(this.button1_Click);
            this.ArcTg.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(552, 289);
            this.Controls.Add(this.LgX);
            this.Controls.Add(this.ngradeX);
            this.Controls.Add(this.TengradeX);
            this.Controls.Add(this.TwogradeX);
            this.Controls.Add(this.LnX);
            this.Controls.Add(this.XgradeTwo);
            this.Controls.Add(this.ArcCtg);
            this.Controls.Add(this.ArcTg);
            this.Controls.Add(this.ArcCos);
            this.Controls.Add(this.ArcSin);
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
        private System.Windows.Forms.Button ArcCos;
        private System.Windows.Forms.Button ArcSin;
        private System.Windows.Forms.Button LgX;
        private System.Windows.Forms.Button ngradeX;
        private System.Windows.Forms.Button TengradeX;
        private System.Windows.Forms.Button TwogradeX;
        private System.Windows.Forms.Button LnX;
        private System.Windows.Forms.Button XgradeTwo;
        private System.Windows.Forms.Button ArcCtg;
        private System.Windows.Forms.Button ArcTg;
    }
}

