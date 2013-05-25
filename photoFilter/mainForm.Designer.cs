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
            this.buttonHorizontalWaves = new System.Windows.Forms.Button();
            this.buttonVerticalWaves = new System.Windows.Forms.Button();
            this.buttonGlass = new System.Windows.Forms.Button();
            this.buttonCorrection = new System.Windows.Forms.Button();
            this.pictureBoxBaseColor = new System.Windows.Forms.PictureBox();
            this.labelBase = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.pictureBoxDestinationColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaseColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDestinationColor)).BeginInit();
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
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
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
            this.openToolStripMenu.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenu.Text = "Open";
            this.openToolStripMenu.Click += new System.EventHandler(this.openToolStripMenu_Click);
            // 
            // saveAsToolStripMenu
            // 
            this.saveAsToolStripMenu.Name = "saveAsToolStripMenu";
            this.saveAsToolStripMenu.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenu.Text = "Save as";
            this.saveAsToolStripMenu.Click += new System.EventHandler(this.saveAsToolStripMenu_Click);
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(112, 22);
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
            this.buttonSourceFile.Size = new System.Drawing.Size(97, 21);
            this.buttonSourceFile.TabIndex = 14;
            this.buttonSourceFile.Text = "source image";
            this.buttonSourceFile.UseVisualStyleBackColor = true;
            this.buttonSourceFile.Click += new System.EventHandler(this.buttonSourceFile_Click);
            // 
            // buttonGray
            // 
            this.buttonGray.Location = new System.Drawing.Point(606, 54);
            this.buttonGray.Name = "buttonGray";
            this.buttonGray.Size = new System.Drawing.Size(97, 21);
            this.buttonGray.TabIndex = 15;
            this.buttonGray.Text = "gray";
            this.buttonGray.UseVisualStyleBackColor = true;
            this.buttonGray.Click += new System.EventHandler(this.buttonGray_Click);
            // 
            // buttonBlackAndWhite
            // 
            this.buttonBlackAndWhite.Location = new System.Drawing.Point(606, 81);
            this.buttonBlackAndWhite.Name = "buttonBlackAndWhite";
            this.buttonBlackAndWhite.Size = new System.Drawing.Size(97, 21);
            this.buttonBlackAndWhite.TabIndex = 16;
            this.buttonBlackAndWhite.Text = "black-white";
            this.buttonBlackAndWhite.UseVisualStyleBackColor = true;
            this.buttonBlackAndWhite.Click += new System.EventHandler(this.buttonBlackAndWhite_Click);
            // 
            // buttonShift
            // 
            this.buttonShift.Location = new System.Drawing.Point(606, 107);
            this.buttonShift.Name = "buttonShift";
            this.buttonShift.Size = new System.Drawing.Size(97, 21);
            this.buttonShift.TabIndex = 17;
            this.buttonShift.Text = "shift";
            this.buttonShift.UseVisualStyleBackColor = true;
            this.buttonShift.Click += new System.EventHandler(this.buttonShift_Click);
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(606, 160);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(97, 21);
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
            // buttonHorizontalWaves
            // 
            this.buttonHorizontalWaves.Location = new System.Drawing.Point(606, 216);
            this.buttonHorizontalWaves.Name = "buttonHorizontalWaves";
            this.buttonHorizontalWaves.Size = new System.Drawing.Size(97, 21);
            this.buttonHorizontalWaves.TabIndex = 21;
            this.buttonHorizontalWaves.Text = "horizontal waves";
            this.buttonHorizontalWaves.UseVisualStyleBackColor = true;
            this.buttonHorizontalWaves.Click += new System.EventHandler(this.buttonHorizontalWaves_Click);
            // 
            // buttonVerticalWaves
            // 
            this.buttonVerticalWaves.Location = new System.Drawing.Point(606, 243);
            this.buttonVerticalWaves.Name = "buttonVerticalWaves";
            this.buttonVerticalWaves.Size = new System.Drawing.Size(97, 21);
            this.buttonVerticalWaves.TabIndex = 22;
            this.buttonVerticalWaves.Text = "vertical waves";
            this.buttonVerticalWaves.UseVisualStyleBackColor = true;
            this.buttonVerticalWaves.Click += new System.EventHandler(this.buttonVerticalWaves_Click);
            // 
            // buttonGlass
            // 
            this.buttonGlass.Location = new System.Drawing.Point(606, 270);
            this.buttonGlass.Name = "buttonGlass";
            this.buttonGlass.Size = new System.Drawing.Size(97, 21);
            this.buttonGlass.TabIndex = 23;
            this.buttonGlass.Text = "glass";
            this.buttonGlass.UseVisualStyleBackColor = true;
            this.buttonGlass.Click += new System.EventHandler(this.buttonGlass_Click);
            // 
            // buttonCorrection
            // 
            this.buttonCorrection.Location = new System.Drawing.Point(606, 297);
            this.buttonCorrection.Name = "buttonCorrection";
            this.buttonCorrection.Size = new System.Drawing.Size(97, 21);
            this.buttonCorrection.TabIndex = 24;
            this.buttonCorrection.Text = "correction";
            this.buttonCorrection.UseVisualStyleBackColor = true;
            this.buttonCorrection.Click += new System.EventHandler(this.buttonCorrection_Click);
            // 
            // pictureBoxBaseColor
            // 
            this.pictureBoxBaseColor.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBoxBaseColor.Location = new System.Drawing.Point(606, 325);
            this.pictureBoxBaseColor.Name = "pictureBoxBaseColor";
            this.pictureBoxBaseColor.Size = new System.Drawing.Size(32, 31);
            this.pictureBoxBaseColor.TabIndex = 25;
            this.pictureBoxBaseColor.TabStop = false;
            this.pictureBoxBaseColor.Click += new System.EventHandler(this.pictureBoxBaseColor_Click);
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(570, 343);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(30, 13);
            this.labelBase.TabIndex = 26;
            this.labelBase.Text = "base";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(643, 343);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(58, 13);
            this.labelDestination.TabIndex = 28;
            this.labelDestination.Text = "destination";
            // 
            // pictureBoxDestinationColor
            // 
            this.pictureBoxDestinationColor.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxDestinationColor.Location = new System.Drawing.Point(707, 325);
            this.pictureBoxDestinationColor.Name = "pictureBoxDestinationColor";
            this.pictureBoxDestinationColor.Size = new System.Drawing.Size(32, 31);
            this.pictureBoxDestinationColor.TabIndex = 27;
            this.pictureBoxDestinationColor.TabStop = false;
            this.pictureBoxDestinationColor.Click += new System.EventHandler(this.pictureBoxDestinationColor_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 493);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.pictureBoxDestinationColor);
            this.Controls.Add(this.labelBase);
            this.Controls.Add(this.pictureBoxBaseColor);
            this.Controls.Add(this.buttonCorrection);
            this.Controls.Add(this.buttonGlass);
            this.Controls.Add(this.buttonVerticalWaves);
            this.Controls.Add(this.buttonHorizontalWaves);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaseColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDestinationColor)).EndInit();
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
        private System.Windows.Forms.Button buttonHorizontalWaves;
        private System.Windows.Forms.Button buttonVerticalWaves;
        private System.Windows.Forms.Button buttonGlass;
        private System.Windows.Forms.Button buttonCorrection;
        private System.Windows.Forms.PictureBox pictureBoxBaseColor;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.PictureBox pictureBoxDestinationColor;
    }
}

