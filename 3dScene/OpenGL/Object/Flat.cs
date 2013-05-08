using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace OpenGL
{
    namespace Object
    {
        class Flat:Object3D
        {
            private float width;
            private float lenght;

            public Flat(Point3D coordinate, int codeTexture, float width, float lenght, Point3D color) :
                base(coordinate, codeTexture)
            {
                this.width = width;
                this.lenght = lenght;

                this.color = color;
            }

            public Flat(Point3D coordinate, int codeTexture, float width, float lenght) :
                base(coordinate, codeTexture)
            {
                this.width = width;
                this.lenght = lenght;

                this.randColor();
            }

            public Flat(Point3D coordinate, int codeTexture, float size) :
                base(coordinate, codeTexture)
            {
                this.width = size;
                this.lenght = size;

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
                        Gl.glTexCoord2f(0, 0); Gl.glVertex3f(-this.lenght / 2, 0, -this.width / 2);
                        Gl.glTexCoord2f(0, 1); Gl.glVertex3f(+this.lenght / 2, 0, -this.width / 2);
                        Gl.glTexCoord2f(1, 1); Gl.glVertex3f(+this.lenght / 2, 0, this.width / 2);
                        Gl.glTexCoord2f(1, 0); Gl.glVertex3f(-this.lenght / 2, 0, this.width / 2);
                    }
                    Gl.glEnd();

                    Gl.glBindTexture(Gl.GL_TEXTURE_2D, this.codeTexture);

                    Gl.glPopMatrix();
                }
            }
        }
    }
}
