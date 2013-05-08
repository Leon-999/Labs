using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace OpenGL.Object
{
    class Cylinder:Object3D
    {
        private float baseRadius;
        private float topRadius;
        private float height;
        private const int SLICES = 50;
        private const int STACKS = 50;

        public Cylinder(Point3D coordinate, int codeTexture, float baseRadius, float topRadius, float height, Point3D color) :
            base(coordinate, codeTexture)
        {
            this.baseRadius = baseRadius;
            this.topRadius = topRadius;
            this.height = height;

            this.color = color;
        }

        public Cylinder(Point3D coordinate, int codeTexture, float baseRadius, float topRadius, float height) : //topRadius = 0 - конус
            base(coordinate, codeTexture)
        {
            this.baseRadius = baseRadius;
            this.topRadius = topRadius;
            this.height = height;

            this.randColor();
        }

        public override void draw()//цилиндр получается сквозной
        {
            if (this.visible)
            {
                Gl.glPushMatrix();

                Gl.glBindTexture(Gl.GL_TEXTURE_2D, this.codeTexture);

                Gl.glTranslatef(this.coordinate.x, this.coordinate.y, this.coordinate.z);
                Gl.glRotatef(-90, 1, 0, 0);
                Gl.glRotatef(this.angle, this.vectorRotate.x, this.vectorRotate.y, this.vectorRotate.z);

                Gl.glColor3f(this.color.x, this.color.y, this.color.z);
                Glu.GLUquadric quad = Glu.gluNewQuadric();
                Glu.gluQuadricTexture(quad, this.codeTexture);
                Glu.gluCylinder(quad, this.baseRadius, this.topRadius, this.height, Cylinder.SLICES, Cylinder.STACKS);
                Glu.gluDeleteQuadric(quad);

                Gl.glFlush();//некая асинхронная команда, которая завершает функцию не ожидая дорисовки

                Gl.glBindTexture(Gl.GL_TEXTURE_2D, this.codeTexture);

                Gl.glPopMatrix();
            }
        }

    }
}
