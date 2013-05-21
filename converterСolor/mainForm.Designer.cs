namespace converterСolor
{
    partial class mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxLeft = new System.Windows.Forms.ComboBox();
            this.comboBoxRight = new System.Windows.Forms.ComboBox();
            this.textBoxLeft1 = new System.Windows.Forms.TextBox();
            this.textBoxLeft2 = new System.Windows.Forms.TextBox();
            this.textBoxLeft3 = new System.Windows.Forms.TextBox();
            this.textBoxRight1 = new System.Windows.Forms.TextBox();
            this.textBoxRight2 = new System.Windows.Forms.TextBox();
            this.textBoxRight3 = new System.Windows.Forms.TextBox();
            this.textBoxRight4 = new System.Windows.Forms.TextBox();
            this.textBoxLeft4 = new System.Windows.Forms.TextBox();
            this.convertLeftRight = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLeft1 = new System.Windows.Forms.Label();
            this.labelLeft2 = new System.Windows.Forms.Label();
            this.labelLeft3 = new System.Windows.Forms.Label();
            this.labelLeft4 = new System.Windows.Forms.Label();
            this.labelRight4 = new System.Windows.Forms.Label();
            this.labelRight3 = new System.Windows.Forms.Label();
            this.labelRight2 = new System.Windows.Forms.Label();
            this.labelRight1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLeft
            // 
            this.comboBoxLeft.FormattingEnabled = true;
            this.comboBoxLeft.Items.AddRange(new object[] {
            "RGB",
            "CMYK",
            "HSV",
            "HSL",
            "XYZ"});
            this.comboBoxLeft.Location = new System.Drawing.Point(12, 25);
            this.comboBoxLeft.Name = "comboBoxLeft";
            this.comboBoxLeft.Size = new System.Drawing.Size(181, 21);
            this.comboBoxLeft.TabIndex = 0;
            this.comboBoxLeft.Text = "XYZ";
            this.comboBoxLeft.SelectedIndexChanged += new System.EventHandler(this.comboBoxLeft_SelectedIndexChanged);
            // 
            // comboBoxRight
            // 
            this.comboBoxRight.FormattingEnabled = true;
            this.comboBoxRight.Items.AddRange(new object[] {
            "RGB",
            "CMYK",
            "HSV",
            "HSL",
            "XYZ"});
            this.comboBoxRight.Location = new System.Drawing.Point(236, 25);
            this.comboBoxRight.Name = "comboBoxRight";
            this.comboBoxRight.Size = new System.Drawing.Size(181, 21);
            this.comboBoxRight.TabIndex = 2;
            this.comboBoxRight.Text = "RGB";
            this.comboBoxRight.SelectedIndexChanged += new System.EventHandler(this.comboBoxRight_SelectedIndexChanged);
            // 
            // textBoxLeft1
            // 
            this.textBoxLeft1.Location = new System.Drawing.Point(53, 82);
            this.textBoxLeft1.Name = "textBoxLeft1";
            this.textBoxLeft1.Size = new System.Drawing.Size(99, 20);
            this.textBoxLeft1.TabIndex = 3;
            // 
            // textBoxLeft2
            // 
            this.textBoxLeft2.Location = new System.Drawing.Point(53, 128);
            this.textBoxLeft2.Name = "textBoxLeft2";
            this.textBoxLeft2.Size = new System.Drawing.Size(99, 20);
            this.textBoxLeft2.TabIndex = 4;
            // 
            // textBoxLeft3
            // 
            this.textBoxLeft3.Location = new System.Drawing.Point(53, 176);
            this.textBoxLeft3.Name = "textBoxLeft3";
            this.textBoxLeft3.Size = new System.Drawing.Size(99, 20);
            this.textBoxLeft3.TabIndex = 5;
            // 
            // textBoxRight1
            // 
            this.textBoxRight1.Location = new System.Drawing.Point(277, 82);
            this.textBoxRight1.Name = "textBoxRight1";
            this.textBoxRight1.Size = new System.Drawing.Size(99, 20);
            this.textBoxRight1.TabIndex = 6;
            // 
            // textBoxRight2
            // 
            this.textBoxRight2.Location = new System.Drawing.Point(277, 128);
            this.textBoxRight2.Name = "textBoxRight2";
            this.textBoxRight2.Size = new System.Drawing.Size(99, 20);
            this.textBoxRight2.TabIndex = 7;
            // 
            // textBoxRight3
            // 
            this.textBoxRight3.Location = new System.Drawing.Point(277, 176);
            this.textBoxRight3.Name = "textBoxRight3";
            this.textBoxRight3.Size = new System.Drawing.Size(99, 20);
            this.textBoxRight3.TabIndex = 8;
            // 
            // textBoxRight4
            // 
            this.textBoxRight4.Location = new System.Drawing.Point(277, 225);
            this.textBoxRight4.Name = "textBoxRight4";
            this.textBoxRight4.Size = new System.Drawing.Size(99, 20);
            this.textBoxRight4.TabIndex = 10;
            // 
            // textBoxLeft4
            // 
            this.textBoxLeft4.Location = new System.Drawing.Point(53, 225);
            this.textBoxLeft4.Name = "textBoxLeft4";
            this.textBoxLeft4.Size = new System.Drawing.Size(99, 20);
            this.textBoxLeft4.TabIndex = 11;
            // 
            // convertLeftRight
            // 
            this.convertLeftRight.Location = new System.Drawing.Point(180, 82);
            this.convertLeftRight.Name = "convertLeftRight";
            this.convertLeftRight.Size = new System.Drawing.Size(75, 23);
            this.convertLeftRight.TabIndex = 12;
            this.convertLeftRight.Text = "=>";
            this.convertLeftRight.UseVisualStyleBackColor = true;
            this.convertLeftRight.Click += new System.EventHandler(this.convertLeftRight_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(158, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 88);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // labelLeft1
            // 
            this.labelLeft1.AutoSize = true;
            this.labelLeft1.Location = new System.Drawing.Point(12, 85);
            this.labelLeft1.Name = "labelLeft1";
            this.labelLeft1.Size = new System.Drawing.Size(35, 13);
            this.labelLeft1.TabIndex = 15;
            this.labelLeft1.Text = "label1";
            // 
            // labelLeft2
            // 
            this.labelLeft2.AutoSize = true;
            this.labelLeft2.Location = new System.Drawing.Point(12, 133);
            this.labelLeft2.Name = "labelLeft2";
            this.labelLeft2.Size = new System.Drawing.Size(35, 13);
            this.labelLeft2.TabIndex = 16;
            this.labelLeft2.Text = "label1";
            // 
            // labelLeft3
            // 
            this.labelLeft3.AutoSize = true;
            this.labelLeft3.Location = new System.Drawing.Point(12, 179);
            this.labelLeft3.Name = "labelLeft3";
            this.labelLeft3.Size = new System.Drawing.Size(35, 13);
            this.labelLeft3.TabIndex = 17;
            this.labelLeft3.Text = "label1";
            // 
            // labelLeft4
            // 
            this.labelLeft4.AutoSize = true;
            this.labelLeft4.Location = new System.Drawing.Point(12, 228);
            this.labelLeft4.Name = "labelLeft4";
            this.labelLeft4.Size = new System.Drawing.Size(35, 13);
            this.labelLeft4.TabIndex = 18;
            this.labelLeft4.Text = "label1";
            // 
            // labelRight4
            // 
            this.labelRight4.AutoSize = true;
            this.labelRight4.Location = new System.Drawing.Point(382, 226);
            this.labelRight4.Name = "labelRight4";
            this.labelRight4.Size = new System.Drawing.Size(35, 13);
            this.labelRight4.TabIndex = 22;
            this.labelRight4.Text = "label1";
            // 
            // labelRight3
            // 
            this.labelRight3.AutoSize = true;
            this.labelRight3.Location = new System.Drawing.Point(382, 177);
            this.labelRight3.Name = "labelRight3";
            this.labelRight3.Size = new System.Drawing.Size(35, 13);
            this.labelRight3.TabIndex = 21;
            this.labelRight3.Text = "label1";
            // 
            // labelRight2
            // 
            this.labelRight2.AutoSize = true;
            this.labelRight2.Location = new System.Drawing.Point(382, 131);
            this.labelRight2.Name = "labelRight2";
            this.labelRight2.Size = new System.Drawing.Size(35, 13);
            this.labelRight2.TabIndex = 20;
            this.labelRight2.Text = "label1";
            // 
            // labelRight1
            // 
            this.labelRight1.AutoSize = true;
            this.labelRight1.Location = new System.Drawing.Point(382, 83);
            this.labelRight1.Name = "labelRight1";
            this.labelRight1.Size = new System.Drawing.Size(35, 13);
            this.labelRight1.TabIndex = 19;
            this.labelRight1.Text = "label1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 303);
            this.Controls.Add(this.labelRight4);
            this.Controls.Add(this.labelRight3);
            this.Controls.Add(this.labelRight2);
            this.Controls.Add(this.labelRight1);
            this.Controls.Add(this.labelLeft4);
            this.Controls.Add(this.labelLeft3);
            this.Controls.Add(this.labelLeft2);
            this.Controls.Add(this.labelLeft1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.convertLeftRight);
            this.Controls.Add(this.textBoxLeft4);
            this.Controls.Add(this.textBoxRight4);
            this.Controls.Add(this.textBoxRight3);
            this.Controls.Add(this.textBoxRight2);
            this.Controls.Add(this.textBoxRight1);
            this.Controls.Add(this.textBoxLeft3);
            this.Controls.Add(this.textBoxLeft2);
            this.Controls.Add(this.textBoxLeft1);
            this.Controls.Add(this.comboBoxRight);
            this.Controls.Add(this.comboBoxLeft);
            this.Name = "mainForm";
            this.Text = "Converter color";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLeft;
        private System.Windows.Forms.ComboBox comboBoxRight;
        private System.Windows.Forms.TextBox textBoxLeft1;
        private System.Windows.Forms.TextBox textBoxLeft2;
        private System.Windows.Forms.TextBox textBoxLeft3;
        private System.Windows.Forms.TextBox textBoxRight1;
        private System.Windows.Forms.TextBox textBoxRight2;
        private System.Windows.Forms.TextBox textBoxRight3;
        private System.Windows.Forms.TextBox textBoxRight4;
        private System.Windows.Forms.TextBox textBoxLeft4;
        private System.Windows.Forms.Button convertLeftRight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLeft1;
        private System.Windows.Forms.Label labelLeft2;
        private System.Windows.Forms.Label labelLeft3;
        private System.Windows.Forms.Label labelLeft4;
        private System.Windows.Forms.Label labelRight4;
        private System.Windows.Forms.Label labelRight3;
        private System.Windows.Forms.Label labelRight2;
        private System.Windows.Forms.Label labelRight1;
    }
}

