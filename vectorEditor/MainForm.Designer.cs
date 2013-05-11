namespace vectorEditor
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows (уже не совсем)

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.radioButtonQuadrate = new System.Windows.Forms.RadioButton();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.checkBoxFill = new System.Windows.Forms.CheckBox();
            this.radioButtonPickOut = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(544, 422);
            this.canvas.TabIndex = 1;
            this.canvas.TabStop = false;
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(489, 449);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(66, 22);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(117, 449);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(41, 17);
            this.radioButtonLine.TabIndex = 4;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Text = "line";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            this.radioButtonLine.CheckedChanged += new System.EventHandler(this.radioButtonLine_CheckedChanged);
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.AutoSize = true;
            this.radioButtonTriangle.Location = new System.Drawing.Point(117, 482);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(59, 17);
            this.radioButtonTriangle.TabIndex = 5;
            this.radioButtonTriangle.TabStop = true;
            this.radioButtonTriangle.Text = "triangle";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            this.radioButtonTriangle.CheckedChanged += new System.EventHandler(this.radioButtonTriangle_CheckedChanged);
            // 
            // radioButtonQuadrate
            // 
            this.radioButtonQuadrate.AutoSize = true;
            this.radioButtonQuadrate.Location = new System.Drawing.Point(220, 449);
            this.radioButtonQuadrate.Name = "radioButtonQuadrate";
            this.radioButtonQuadrate.Size = new System.Drawing.Size(67, 17);
            this.radioButtonQuadrate.TabIndex = 6;
            this.radioButtonQuadrate.TabStop = true;
            this.radioButtonQuadrate.Text = "quadrate";
            this.radioButtonQuadrate.UseVisualStyleBackColor = true;
            this.radioButtonQuadrate.CheckedChanged += new System.EventHandler(this.radioButtonQuadrate_CheckedChanged);
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(220, 482);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(54, 17);
            this.radioButtonEllipse.TabIndex = 7;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Text = "ellipse";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            this.radioButtonEllipse.CheckedChanged += new System.EventHandler(this.radioButtonEllipse_CheckedChanged);
            // 
            // checkBoxFill
            // 
            this.checkBoxFill.AutoSize = true;
            this.checkBoxFill.Location = new System.Drawing.Point(12, 449);
            this.checkBoxFill.Name = "checkBoxFill";
            this.checkBoxFill.Size = new System.Drawing.Size(35, 17);
            this.checkBoxFill.TabIndex = 8;
            this.checkBoxFill.Text = "fill";
            this.checkBoxFill.UseVisualStyleBackColor = true;
            this.checkBoxFill.CheckedChanged += new System.EventHandler(this.checkBoxFill_CheckedChanged);
            // 
            // radioButtonPickOut
            // 
            this.radioButtonPickOut.AutoSize = true;
            this.radioButtonPickOut.Location = new System.Drawing.Point(12, 482);
            this.radioButtonPickOut.Name = "radioButtonPickOut";
            this.radioButtonPickOut.Size = new System.Drawing.Size(63, 17);
            this.radioButtonPickOut.TabIndex = 9;
            this.radioButtonPickOut.TabStop = true;
            this.radioButtonPickOut.Text = "pick out";
            this.radioButtonPickOut.UseVisualStyleBackColor = true;
            this.radioButtonPickOut.CheckedChanged += new System.EventHandler(this.radioButtonPickOut_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 517);
            this.Controls.Add(this.radioButtonPickOut);
            this.Controls.Add(this.checkBoxFill);
            this.Controls.Add(this.radioButtonEllipse);
            this.Controls.Add(this.radioButtonQuadrate);
            this.Controls.Add(this.radioButtonTriangle);
            this.Controls.Add(this.radioButtonLine);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.canvas);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //будь внимателен, генератор любит перегенерировать
        public System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.RadioButton radioButtonQuadrate;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
        private System.Windows.Forms.CheckBox checkBoxFill;
        private System.Windows.Forms.RadioButton radioButtonPickOut;
    }
}

