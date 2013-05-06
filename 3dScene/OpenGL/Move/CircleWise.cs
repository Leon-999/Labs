using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenGL.Object;

namespace OpenGL.Move
{
    class CircleWise:BaseMove
    {
        private const int DEFAULT_SPEED = 100;
        private const float STEP = 0.001f;

        private float radius;
        private int sunwise;
        private float time;
        private Point3D startCoordinate;
        private Point3D newCoordinate;
        private int countTurn;

        public CircleWise(Object3D moveable, float radius, bool sunwise, int speed, int countTurn):
            base(moveable, speed)
        {
            this.radius = radius;
            if (sunwise)
                this.sunwise = 1;
            else
                this.sunwise = -1;
            this.time = 0;
            this.startCoordinate = this.moveable.getCoordinate();
            this.countTurn = countTurn;

            this.completeTimer();
        }

        override internal void completeTimer(object sender = null, EventArgs eventCall = null)
        {
            if (this.moveable.getMove() == false)
            {
                this.timer.Stop();

                float argument = this.sunwise * this.time * CircleWise.STEP * this.speed;
                this.newCoordinate.x = (float)(this.radius * Math.Sin(argument));
                this.newCoordinate.y = this.startCoordinate.y;
                this.newCoordinate.z = (float)(this.radius * Math.Cos(argument));

                if (this.countTurn == -1)
                {
                    this.moveable.setCoordinate(this.newCoordinate);
                    this.timer.Start();
                }
                else
                    if (Math.Abs((int)(argument / Math.PI)) < this.countTurn )
                    {
                        this.moveable.setCoordinate(this.newCoordinate);
                        this.timer.Start();
                    }

            }
            this.time +=0.1f;
        }

    }
}
