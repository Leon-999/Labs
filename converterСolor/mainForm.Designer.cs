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
            this.convertRightLeft = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            // 
            // convertRightLeft
            // 
            this.convertRightLeft.Location = new System.Drawing.Point(180, 128);
            this.convertRightLeft.Name = "convertRightLeft";
            this.convertRightLeft.Size = new System.Drawing.Size(75, 23);
            this.convertRightLeft.TabIndex = 13;
            this.convertRightLeft.Text = "<=";
            this.convertRightLeft.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(158, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 88);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 303);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.convertRightLeft);
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
        private System.Windows.Forms.Button convertRightLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

