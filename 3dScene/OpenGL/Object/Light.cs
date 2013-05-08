using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace OpenGL.Object
{

    class Light:Object3D
    {

        private int number;
        private Point3D ambient;//цвет фонового освещения
        private Point3D diffuse;//цвет дифузного отражения
        private Point3D specular;//цвет зеркального отражения
        private float spotExponent;//сфокусированность от 0 до 126
        private float spotCutoff;//угол разброса от 0 до 90 или 180 - рассеяный свет
        private Point3D spotDirection;//направление
        private Object3D covering;


        public Light(int number, Point3D ambient, Point3D diffuse, Point3D specular, float spotExponent, float spotCutoff,
                     Object3D covering) :
            base(covering.getCoordinate(), covering.getCodeTexture())
        {
            this.number = number;
            this.ambient = ambient;
            this.diffuse = diffuse;
            this.specular = specular;
            this.spotExponent = spotExponent;
            this.spotCutoff = spotCutoff;
            this.covering = covering;

            Gl.glEnable(this.number);

            Gl.glLightfv(this.number, Gl.GL_AMBIENT, new float[] { this.ambient.x, this.ambient.y, this.ambient.z});
            Gl.glLightfv(this.number, Gl.GL_DIFFUSE, new float[] { this.diffuse.x, this.diffuse.y, this.diffuse.z });
            Gl.glLightfv(this.number, Gl.GL_SPECULAR, new float[] { this.specular.x, this.specular.y, this.specular.z });
            Gl.glLightfv(this.number, Gl.GL_SPOT_EXPONENT, new float[] { this.spotExponent });
            Gl.glLightfv(this.number, Gl.GL_SPOT_CUTOFF, new float[] { this.spotCutoff });
            //Gl.glLightfv(this.number, Gl.GL_SPOT_DIRECTION, new float[] { 0.0f, 0.0f, -15.0f, 1 });
            Gl.glLightfv(this.number, Gl.GL_POSITION, new float[] { this.coordinate.x, this.coordinate.y, this.coordinate.z, 1 });
        }

        override public void draw()
        {
            if (this.visible)
            {
                Gl.glDisable(Gl.GL_LIGHTING);
                this.covering.setCoordinate(this.coordinate);
                this.covering.draw();
                Gl.glEnable(Gl.GL_LIGHTING);
            }
        }
    }
}
