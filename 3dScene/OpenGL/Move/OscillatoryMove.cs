using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenGL.Object;

namespace OpenGL.Move
{
    class OscillatoryMove : BaseMove
    {
        private Point3D firstPoint;
        private Point3D secondPoint;
        private int countOscillation;
        private bool flag;

        public OscillatoryMove(Object3D moveable, Point3D secondPoint, int speed, int countOscillation) :
            base(moveable, speed)
        {
            this.firstPoint = moveable.getCoordinate();
            this.secondPoint = secondPoint;
            this.countOscillation = countOscillation;
            this.flag = true;

            this.completeTimer();
        }

        override internal void completeTimer(object sender = null, EventArgs eventCall = null)
        {
            if (this.moveable.getMove() == false)
            {
                this.timer.Stop();

                if (this.countOscillation == -1)
                {
                    this.choiceCourse();
                    this.timer.Start();
                }
                else
                    if (this.countOscillation > 0)
                    {
                        this.choiceCourse();
                        this.timer.Start();
                        this.countOscillation--;
                    }

            }

        }

        private void choiceCourse()
        {
            if (this.flag)
            {
                this.moveable.startMove(this.secondPoint, this.speed);
                this.flag = false;
            }
            else
            {
                this.moveable.startMove(this.firstPoint, this.speed);
                this.flag = true;
            }
        }

    }
}
