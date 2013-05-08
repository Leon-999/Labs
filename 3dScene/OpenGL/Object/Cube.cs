using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace OpenGL
{
    namespace Object
    {
        public class Cube : Object3D
        {
            private float width;
            private float lenght;
            private float height;

            public Cube(Point3D coordinate, int codeTexture, Point3D sizesWLH, Point3D color) :
                base(coordinate, codeTexture)
            {
                this.width = sizesWLH.x;
                this.lenght = sizesWLH.y;
                this.height = sizesWLH.z;

                this.color = color;
            }

            public Cube(Point3D coordinate, int codeTexture, float width, float lenght, float height) :
                base(coordinate, codeTexture)
            {
                this.width = width;
                this.lenght = lenght;
                this.height = height;

                this.randColor();
            }

            public Cube(Point3D coordinate, int codeTexture, float size) :
                base(coordinate, codeTexture)
            {
                this.width = size;
                this.lenght = size;
                this.height = size;

                this.randColor();
            }


            public override void draw()
            {
                if (this.visible)
                {
                    Gl.glPushMatrix();
                    Gl.glTranslatef(this.coordinate.x, this.coordinate.y, this.coordinate.z);
                    Gl.glRotatef(this.angle, this.vectorRotate.x, this.vectorRotate.y, this.vectorRotate.z);

                    Gl.glColor3d(this.color.x, this.color.y, this.color.z);

                    Gl.glBindTexture(Gl.GL_TEXTURE_2D, this.codeTexture);

                    Gl.glBegin(Gl.GL_QUADS);
                    {
                        // левая грань
                        Gl.glTexCoord2f(0, 0); Gl.glVertex3f(-this.lenght / 2, -this.height / 2, -this.width / 2);
                        Gl.glTexCoord2f(0, 1); Gl.glVertex3f(-this.lenght / 2, this.height / 2, -this.width / 2);
                        Gl.glTexCoord2f(1, 1); Gl.glVertex3f(-this.lenght / 2, this.height / 2, this.width / 2);
                        Gl.glTexCoord2f(1, 0); Gl.glVertex3f(-this.lenght / 2, -this.height / 2, this.width / 2);
                        // правая грань
                        Gl.glTexCoord2f(0, 0); Gl.glVertex3f(+this.lenght / 2, -this.height / 2, this.width / 2);
                        Gl.glTexCoord2f(0, 1); Gl.glVertex3f(+this.lenght / 2, this.height / 2, this.width / 2);
                        Gl.glTexCoord2f(1, 1); Gl.glVertex3f(+this.lenght / 2, this.height / 2, -this.width / 2);
                        Gl.glTexCoord2f(1, 0); Gl.glVertex3f(+this.lenght / 2, -this.height / 2, -this.width / 2);
                        // нижняя грань
                        Gl.glTexCoord2f(0, 0); Gl.glVertex3f(-this.lenght / 2, -this.height / 2, -this.width / 2);
                        Gl.glTexCoord2f(0, 1); Gl.glVertex3f(+this.lenght / 2, -this.height / 2, -this.width / 2);
                        Gl.glTexCoord2f(1, 1); Gl.glVertex3f(+this.lenght / 2, -this.height / 2, this.width / 2);
                        Gl.glTexCoord2f(1, 0); Gl.glVertex3f(-this.lenght / 2, -this.height / 2, this.width / 2);
                        // верхняя грань
                        Gl.glTexCoord2f(0, 0); Gl.glVertex3f(-this.lenght / 2, this.height / 2, this.width / 2);
                        Gl.glTexCoord2f(0, 1); Gl.glVertex3f(-this.lenght / 2, this.height / 2, -this.width / 2);
                        Gl.glTexCoord2f(1, 1); Gl.glVertex3f(+this.lenght / 2, this.height / 2, -this.width / 2);
                        Gl.glTexCoord2f(1, 0); Gl.glVertex3f(+this.lenght / 2, this.height / 2, this.width / 2);
                        // задняя грань
                        Gl.glTexCoord2f(0, 0); Gl.glVertex3f(+this.lenght / 2, -this.height / 2, -this.width / 2);
                        Gl.glTexCoord2f(0, 1); Gl.glVertex3f(+this.lenght / 2, this.height / 2, -this.width / 2);
                        Gl.glTexCoord2f(1, 1); Gl.glVertex3f(-this.lenght / 2, this.height / 2, -this.width / 2);
                        Gl.glTexCoord2f(1, 0); Gl.glVertex3f(-this.lenght / 2, -this.height / 2, -this.width / 2);
                        // передняя грань
                        Gl.glTexCoord2f(0, 0); Gl.glVertex3f(-this.lenght / 2, -this.height / 2, this.width / 2);
                        Gl.glTexCoord2f(0, 1); Gl.glVertex3f(+this.lenght / 2, -this.height / 2, this.width / 2);
                        Gl.glTexCoord2f(1, 1); Gl.glVertex3f(+this.lenght / 2, this.height / 2, this.width / 2);
                        Gl.glTexCoord2f(1, 0); Gl.glVertex3f(-this.lenght / 2, this.height / 2, this.width / 2);
                    }
                    Gl.glEnd();

                    Gl.glBindTexture(Gl.GL_TEXTURE_2D, this.codeTexture);

                    Gl.glPopMatrix();
                }
            }

        }
    }
}
