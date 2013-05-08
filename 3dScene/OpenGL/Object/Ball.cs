using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace OpenGL
{
    namespace Object
    {
        class Ball : Object3D
        {
            private float radius;
            private const int SLICES = 50;
            private const int STACKS = 50;

            public Ball(Point3D coordinate, int codeTexture, float radius, Point3D color) :
                base(coordinate, codeTexture)
            {
                this.radius = radius;

                this.color = color;
            }

            public Ball(Point3D coordinate, int codeTexture, float radius) :
                base(coordinate, codeTexture)
            {
                this.radius = radius;

                this.randColor();
            }

            public override void draw()
            {
                if (this.visible)
                {
                    Gl.glPushMatrix();

                    Gl.glBindTexture(Gl.GL_TEXTURE_2D, this.codeTexture);

                    Gl.glTranslatef(this.coordinate.x, this.coordinate.y, this.coordinate.z);
                    Gl.glRotatef(this.angle, this.vectorRotate.x, this.vectorRotate.y, this.vectorRotate.z);

                    Gl.glColor3f(this.color.x, this.color.y, this.color.z);
                    Glu.GLUquadric quad = Glu.gluNewQuadric();
                    Glu.gluQuadricTexture(quad, this.codeTexture);
                    Glu.gluSphere(quad, this.radius, Ball.SLICES, Ball.STACKS);
                    Glu.gluDeleteQuadric(quad);

                    Gl.glFlush();//некая асинхронная команда, которая завершает функцию не ожидая дорисовки

                    Gl.glBindTexture(Gl.GL_TEXTURE_2D, this.codeTexture);

                    Gl.glPopMatrix();
                }
            }
        }
    }
}
