﻿namespace photoFilter
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
            this.labelWhatDisplay = new System.Windows.Forms.Label();
            this.textBoxShiftX = new System.Windows.Forms.TextBox();
            this.textBoxShiftY = new System.Windows.Forms.TextBox();
            this.labelShiftX = new System.Windows.Forms.Label();
            this.labelShiftY = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonSourceFile = new System.Windows.Forms.Button();
            this.buttonGray = new System.Windows.Forms.Button();
            this.buttonBlackAndWhite = new System.Windows.Forms.Button();
            this.buttonShift = new System.Windows.Forms.Button();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.labelRotateAngle = new System.Windows.Forms.Label();
            this.textBoxRotateAngle = new System.Windows.Forms.TextBox();
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
            this.fileToolStripMenu.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenu.Text = "File";
            // 
            // openToolStripMenu
            // 
            this.openToolStripMenu.Name = "openToolStripMenu";
            this.openToolStripMenu.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenu.Text = "Open";
            this.openToolStripMenu.Click += new System.EventHandler(this.openToolStripMenu_Click);
            // 
            // saveAsToolStripMenu
            // 
            this.saveAsToolStripMenu.Name = "saveAsToolStripMenu";
            this.saveAsToolStripMenu.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenu.Text = "Save as";
            this.saveAsToolStripMenu.Click += new System.EventHandler(this.saveAsToolStripMenu_Click);
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenu.Text = "Exit";
            this.exitToolStripMenu.Click += new System.EventHandler(this.exitToolStripMenu_Click);
            // 
            // labelWhatDisplay
            // 
            this.labelWhatDisplay.AutoSize = true;
            this.labelWhatDisplay.Location = new System.Drawing.Point(580, 6);
            this.labelWhatDisplay.Name = "labelWhatDisplay";
            this.labelWhatDisplay.Size = new System.Drawing.Size(74, 13);
            this.labelWhatDisplay.TabIndex = 4;
            this.labelWhatDisplay.Text = "What display?";
            // 
            // textBoxShiftX
            // 
            this.textBoxShiftX.Location = new System.Drawing.Point(625, 134);
            this.textBoxShiftX.Name = "textBoxShiftX";
            this.textBoxShiftX.Size = new System.Drawing.Size(43, 20);
            this.textBoxShiftX.TabIndex = 8;
            this.textBoxShiftX.Text = "0";
            // 
            // textBoxShiftY
            // 
            this.textBoxShiftY.Location = new System.Drawing.Point(696, 134);
            this.textBoxShiftY.Name = "textBoxShiftY";
            this.textBoxShiftY.Size = new System.Drawing.Size(43, 20);
            this.textBoxShiftY.TabIndex = 9;
            this.textBoxShiftY.Text = "0";
            // 
            // labelShiftX
            // 
            this.labelShiftX.AutoSize = true;
            this.labelShiftX.Location = new System.Drawing.Point(599, 137);
            this.labelShiftX.Name = "labelShiftX";
            this.labelShiftX.Size = new System.Drawing.Size(20, 13);
            this.labelShiftX.TabIndex = 10;
            this.labelShiftX.Text = "dX";
            // 
            // labelShiftY
            // 
            this.labelShiftY.AutoSize = true;
            this.labelShiftY.Location = new System.Drawing.Point(673, 137);
            this.labelShiftY.Name = "labelShiftY";
            this.labelShiftY.Size = new System.Drawing.Size(20, 13);
            this.labelShiftY.TabIndex = 11;
            this.labelShiftY.Text = "dY";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(303, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(244, 16);
            this.progressBar.TabIndex = 12;
            this.progressBar.Visible = false;
            // 
            // buttonSourceFile
            // 
            this.buttonSourceFile.Location = new System.Drawing.Point(606, 27);
            this.buttonSourceFile.Name = "buttonSourceFile";
            this.buttonSourceFile.Size = new System.Drawing.Size(87, 21);
            this.buttonSourceFile.TabIndex = 14;
            this.buttonSourceFile.Text = "source image";
            this.buttonSourceFile.UseVisualStyleBackColor = true;
            this.buttonSourceFile.Click += new System.EventHandler(this.buttonSourceFile_Click);
            // 
            // buttonGray
            // 
            this.buttonGray.Location = new System.Drawing.Point(606, 54);
            this.buttonGray.Name = "buttonGray";
            this.buttonGray.Size = new System.Drawing.Size(87, 21);
            this.buttonGray.TabIndex = 15;
            this.buttonGray.Text = "gray";
            this.buttonGray.UseVisualStyleBackColor = true;
            this.buttonGray.Click += new System.EventHandler(this.buttonGray_Click);
            // 
            // buttonBlackAndWhite
            // 
            this.buttonBlackAndWhite.Location = new System.Drawing.Point(606, 81);
            this.buttonBlackAndWhite.Name = "buttonBlackAndWhite";
            this.buttonBlackAndWhite.Size = new System.Drawing.Size(87, 21);
            this.buttonBlackAndWhite.TabIndex = 16;
            this.buttonBlackAndWhite.Text = "black-white";
            this.buttonBlackAndWhite.UseVisualStyleBackColor = true;
            this.buttonBlackAndWhite.Click += new System.EventHandler(this.buttonBlackAndWhite_Click);
            // 
            // buttonShift
            // 
            this.buttonShift.Location = new System.Drawing.Point(606, 107);
            this.buttonShift.Name = "buttonShift";
            this.buttonShift.Size = new System.Drawing.Size(87, 21);
            this.buttonShift.TabIndex = 17;
            this.buttonShift.Text = "shift";
            this.buttonShift.UseVisualStyleBackColor = true;
            this.buttonShift.Click += new System.EventHandler(this.buttonShift_Click);
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(606, 160);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(87, 21);
            this.buttonRotate.TabIndex = 18;
            this.buttonRotate.Text = "rotate";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // labelRotateAngle
            // 
            this.labelRotateAngle.AutoSize = true;
            this.labelRotateAngle.Location = new System.Drawing.Point(599, 193);
            this.labelRotateAngle.Name = "labelRotateAngle";
            this.labelRotateAngle.Size = new System.Drawing.Size(33, 13);
            this.labelRotateAngle.TabIndex = 20;
            this.labelRotateAngle.Text = "angle";
            // 
            // textBoxRotateAngle
            // 
            this.textBoxRotateAngle.Location = new System.Drawing.Point(638, 190);
            this.textBoxRotateAngle.Name = "textBoxRotateAngle";
            this.textBoxRotateAngle.Size = new System.Drawing.Size(43, 20);
            this.textBoxRotateAngle.TabIndex = 19;
            this.textBoxRotateAngle.Text = "0";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 493);
            this.Controls.Add(this.labelRotateAngle);
            this.Controls.Add(this.textBoxRotateAngle);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.buttonShift);
            this.Controls.Add(this.buttonBlackAndWhite);
            this.Controls.Add(this.buttonGray);
            this.Controls.Add(this.buttonSourceFile);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelShiftY);
            this.Controls.Add(this.labelShiftX);
            this.Controls.Add(this.textBoxShiftY);
            this.Controls.Add(this.textBoxShiftX);
            this.Controls.Add(this.labelWhatDisplay);
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
        private System.Windows.Forms.Label labelWhatDisplay;
        private System.Windows.Forms.TextBox textBoxShiftX;
        private System.Windows.Forms.TextBox textBoxShiftY;
        private System.Windows.Forms.Label labelShiftX;
        private System.Windows.Forms.Label labelShiftY;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonSourceFile;
        private System.Windows.Forms.Button buttonGray;
        private System.Windows.Forms.Button buttonBlackAndWhite;
        private System.Windows.Forms.Button buttonShift;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Label labelRotateAngle;
        private System.Windows.Forms.TextBox textBoxRotateAngle;
    }
}

