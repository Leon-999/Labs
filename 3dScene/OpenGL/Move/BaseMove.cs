using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenGL.Object;
using System.Timers;

namespace OpenGL.Move
{
    abstract class BaseMove
    {
        protected Object3D moveable;
        protected int speed;

        protected Timer timer;

        protected const int TIMER_INTERVAL = 33; //меньше 20 уставливать не стоит

        protected BaseMove(Object3D moveable, int speed)
        {
            this.timer = new Timer();
            this.timer.Elapsed += new ElapsedEventHandler(this.completeTimer);
            this.timer.Interval = BaseMove.TIMER_INTERVAL;

            this.moveable = moveable;
            this.speed = speed;
        }

        abstract internal void completeTimer(object sender = null, EventArgs eventCall = null);
    }
}
