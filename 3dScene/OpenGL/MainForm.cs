using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;


namespace OpenGL
{
    public partial class MainForm : Form
    {
        private ManagerScene managerScene;

        public MainForm()
        {
            this.InitializeComponent();
            this.GlControl.InitializeContexts();

            MainForm.Resize(GlControl.Width, GlControl.Height);

            this.managerScene = new ManagerScene(this);
        }

        new private static void Resize(int width, int height)
        {
            if (height == 0)
            {
                height = 1;
            }
            Gl.glClearColor(0, 0, 0, 1);
            Gl.glViewport(0, 0, width, height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            //Gl.glFrustum(-1, 1, -0.9, 0.9, 2.4, 9); //установка перспективы через границы
            Glu.gluPerspective(45, width / (double)height, 0.1, 200); //установка перспективы через иные переменные
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }

        public void clearScene()
        {
           GlControl.Invalidate();
        }

        private void openGlControl_Paint(object sender, PaintEventArgs e)
        {
            this.managerScene.draw();
        }
    }
}
