using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenGL.Object;

namespace OpenGL.Move
{
    class Rotate:BaseMove
    {
        private Point3D vectorRotate;
        private float angle;
        private int countTurn;

        public Rotate(Object3D moveable, Point3D vectorRotate, int speed, float angle, int countTurn) :
            base(moveable, speed)
        {
            this.vectorRotate = vectorRotate;
            this.angle = angle;
            this.countTurn = countTurn;

            this.completeTimer();
        }

        override internal void completeTimer(object sender = null, EventArgs eventCall = null)
        {
            if (this.moveable.getRotate() == false)
            {
                this.timer.Stop();

                if (this.countTurn == -1)
                {
                    this.moveable.startRotate(this.vectorRotate, this.speed, this.angle);
                    this.timer.Start();
                }
                else
                    if (this.countTurn > 0)
                    {
                        this.moveable.startRotate(this.vectorRotate, this.speed, this.angle);
                        this.timer.Start();
                        this.countTurn--;
                    }

            }

        }
    }
}
