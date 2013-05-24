namespace photoFilter
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.radioSourseFile = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonGray = new System.Windows.Forms.RadioButton();
            this.radioButtonBlackAndWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonShift = new System.Windows.Forms.RadioButton();
            this.textBoxShiftX = new System.Windows.Forms.TextBox();
            this.textBoxShiftY = new System.Windows.Forms.TextBox();
            this.labelShiftX = new System.Windows.Forms.Label();
            this.labelShiftY = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(12, 27);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(535, 454);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(743, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenu
            // 
            this.fileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenu,
            this.saveAsToolStripMenu,
            this.exitToolStripMenu});
            this.fileToolStripMenu.Name = "fileToolStripMenu";
            this.fileToolStripMenu.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenu.Text = "File";
            // 
            // openToolStripMenu
            // 
            this.openToolStripMenu.Name = "openToolStripMenu";
            this.openToolStripMenu.Size = new System.Drawing.Size(120, 22);
            this.openToolStripMenu.Text = "Open";
            this.openToolStripMenu.Click += new System.EventHandler(this.openToolStripMenu_Click);
            // 
            // saveAsToolStripMenu
            // 
            this.saveAsToolStripMenu.Name = "saveAsToolStripMenu";
            this.saveAsToolStripMenu.Size = new System.Drawing.Size(120, 22);
            this.saveAsToolStripMenu.Text = "Save as";
            this.saveAsToolStripMenu.Click += new System.EventHandler(this.saveAsToolStripMenu_Click);
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(120, 22);
            this.exitToolStripMenu.Text = "Exit";
            this.exitToolStripMenu.Click += new System.EventHandler(this.exitToolStripMenu_Click);
            // 
            // radioSourseFile
            // 
            this.radioSourseFile.AutoSize = true;
            this.radioSourseFile.Location = new System.Drawing.Point(606, 27);
            this.radioSourseFile.Name = "radioSourseFile";
            this.radioSourseFile.Size = new System.Drawing.Size(87, 17);
            this.radioSourseFile.TabIndex = 3;
            this.radioSourseFile.TabStop = true;
            this.radioSourseFile.Text = "sourse image";
            this.radioSourseFile.UseVisualStyleBackColor = true;
            this.radioSourseFile.CheckedChanged += new System.EventHandler(this.radioSourseFile_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "What display?";
            // 
            // radioButtonGray
            // 
            this.radioButtonGray.AutoSize = true;
            this.radioButtonGray.Location = new System.Drawing.Point(606, 50);
            this.radioButtonGray.Name = "radioButtonGray";
            this.radioButtonGray.Size = new System.Drawing.Size(45, 17);
            this.radioButtonGray.TabIndex = 5;
            this.radioButtonGray.TabStop = true;
            this.radioButtonGray.Text = "gray";
            this.radioButtonGray.UseVisualStyleBackColor = true;
            this.radioButtonGray.CheckedChanged += new System.EventHandler(this.radioButtonGray_CheckedChanged);
            // 
            // radioButtonBlackAndWhite
            // 
            this.radioButtonBlackAndWhite.AutoSize = true;
            this.radioButtonBlackAndWhite.Location = new System.Drawing.Point(606, 73);
            this.radioButtonBlackAndWhite.Name = "radioButtonBlackAndWhite";
            this.radioButtonBlackAndWhite.Size = new System.Drawing.Size(79, 17);
            this.radioButtonBlackAndWhite.TabIndex = 6;
            this.radioButtonBlackAndWhite.TabStop = true;
            this.radioButtonBlackAndWhite.Text = "black-white";
            this.radioButtonBlackAndWhite.UseVisualStyleBackColor = true;
            this.radioButtonBlackAndWhite.CheckedChanged += new System.EventHandler(this.radioButtonBlackAndWhite_CheckedChanged);
            // 
            // radioButtonShift
            // 
            this.radioButtonShift.AutoSize = true;
            this.radioButtonShift.Location = new System.Drawing.Point(606, 96);
            this.radioButtonShift.Name = "radioButtonShift";
            this.radioButtonShift.Size = new System.Drawing.Size(44, 17);
            this.radioButtonShift.TabIndex = 7;
            this.radioButtonShift.TabStop = true;
            this.radioButtonShift.Text = "shift";
            this.radioButtonShift.UseVisualStyleBackColor = true;
            this.radioButtonShift.CheckedChanged += new System.EventHandler(this.radioButtonShift_CheckedChanged);
            // 
            // textBoxShiftX
            // 
            this.textBoxShiftX.Location = new System.Drawing.Point(625, 119);
            this.textBoxShiftX.Name = "textBoxShiftX";
            this.textBoxShiftX.Size = new System.Drawing.Size(43, 20);
            this.textBoxShiftX.TabIndex = 8;
            this.textBoxShiftX.Text = "0";
            // 
            // textBoxShiftY
            // 
            this.textBoxShiftY.Location = new System.Drawing.Point(696, 119);
            this.textBoxShiftY.Name = "textBoxShiftY";
            this.textBoxShiftY.Size = new System.Drawing.Size(43, 20);
            this.textBoxShiftY.TabIndex = 9;
            this.textBoxShiftY.Text = "0";
            // 
            // labelShiftX
            // 
            this.labelShiftX.AutoSize = true;
            this.labelShiftX.Location = new System.Drawing.Point(599, 122);
            this.labelShiftX.Name = "labelShiftX";
            this.labelShiftX.Size = new System.Drawing.Size(20, 13);
            this.labelShiftX.TabIndex = 10;
            this.labelShiftX.Text = "dX";
            // 
            // labelShiftY
            // 
            this.labelShiftY.AutoSize = true;
            this.labelShiftY.Location = new System.Drawing.Point(673, 122);
            this.labelShiftY.Name = "labelShiftY";
            this.labelShiftY.Size = new System.Drawing.Size(20, 13);
            this.labelShiftY.TabIndex = 11;
            this.labelShiftY.Text = "dY";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(303, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(244, 16);
            this.progressBar1.TabIndex = 12;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 493);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelShiftY);
            this.Controls.Add(this.labelShiftX);
            this.Controls.Add(this.textBoxShiftY);
            this.Controls.Add(this.textBoxShiftX);
            this.Controls.Add(this.radioButtonShift);
            this.Controls.Add(this.radioButtonBlackAndWhite);
            this.Controls.Add(this.radioButtonGray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioSourseFile);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.RadioButton radioSourseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonGray;
        private System.Windows.Forms.RadioButton radioButtonBlackAndWhite;
        private System.Windows.Forms.RadioButton radioButtonShift;
        private System.Windows.Forms.TextBox textBoxShiftX;
        private System.Windows.Forms.TextBox textBoxShiftY;
        private System.Windows.Forms.Label labelShiftX;
        private System.Windows.Forms.Label labelShiftY;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

