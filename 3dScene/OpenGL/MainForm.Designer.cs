namespace OpenGL
{
    partial class MainForm
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
            this.GlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // GlControl
            // 
            this.GlControl.AccumBits = ((byte)(0));
            this.GlControl.AutoCheckErrors = false;
            this.GlControl.AutoFinish = false;
            this.GlControl.AutoMakeCurrent = true;
            this.GlControl.AutoSwapBuffers = true;
            this.GlControl.BackColor = System.Drawing.Color.Black;
            this.GlControl.ColorBits = ((byte)(32));
            this.GlControl.DepthBits = ((byte)(16));
            this.GlControl.Location = new System.Drawing.Point(13, 16);
            this.GlControl.Name = "GlControl";
            this.GlControl.Size = new System.Drawing.Size(514, 445);
            this.GlControl.StencilBits = ((byte)(0));
            this.GlControl.TabIndex = 0;
            this.GlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.openGlControl_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 473);
            this.Controls.Add(this.GlControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl GlControl;
    }
}

