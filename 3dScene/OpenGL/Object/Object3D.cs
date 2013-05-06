using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;
using System.Timers;

namespace OpenGL
{
    namespace Object
    {
        public struct Point3D
        {
            //обычно координаты находятся в центре объекта
            public float x;
            public float y;
            public float z;

            public Point3D(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }

        //public struct 

        public abstract class Object3D
        {
            protected Point3D coordinate;
            protected float angle;
            protected Point3D color;
            protected int codeTexture;
            protected Timer timerMove;
            protected Timer timerRotate;

            protected bool visible;

            protected Random radomizer;
            protected Random seedRandomizer;
            protected int seed;

            protected const int TIMER_INTERVAL = 33; //меньше 20 уставливать не стоит

            //штуки для движения
            protected const float WIDTH_STEP = 0.001f;

            protected int countSteps;
            protected Point3D newCoordinate;
            protected bool move;

            //штуки для вращения
            protected const float DEG_STEP = 0.001f;

            protected int countRotates;
            protected Point3D vectorRotate;
            protected float newAngle;
            protected bool rotate;


            protected Object3D(Point3D coordinate, int codeTexture)
            {
                this.coordinate = coordinate;
                this.angle = 0;
                this.vectorRotate = new Point3D(0, 0, 0);
                this.visible = true;

                this.codeTexture = codeTexture;

                this.radomizer = new Random();
                //this.seed = this.radomizer.Next();
                //this.seedRandomizer = new Random(this.seed);

                this.timerMove = new Timer(Object3D.TIMER_INTERVAL);
                this.timerMove.Elapsed += new ElapsedEventHandler(this.nextStep);
                this.move = false;

                this.timerRotate = new Timer(Object3D.TIMER_INTERVAL);
                this.timerRotate.Elapsed += new ElapsedEventHandler(this.nextRotate);
                this.rotate = false;
            }

            abstract public void draw();

            

            public void startMove(Point3D newCoordinate, int speed) //speed = 1 - самая медленная скорость
            {
                this.newCoordinate = newCoordinate;

                Point3D distance;
                distance.x = this.newCoordinate.x - this.coordinate.x;
                distance.y = this.newCoordinate.y - this.coordinate.y;
                distance.z = this.newCoordinate.z - this.coordinate.z;

                Point3D countSteps;
                countSteps.x = Math.Abs((float)(int)(distance.x / (Object3D.WIDTH_STEP * speed)));
                countSteps.y = Math.Abs((float)(int)(distance.y / (Object3D.WIDTH_STEP * speed)));
                countSteps.z = Math.Abs((float)(int)(distance.z / (Object3D.WIDTH_STEP * speed)));

                int maxCountSteps = -1;

                if (countSteps.x > maxCountSteps) maxCountSteps = (int)countSteps.x;
                if (countSteps.y > maxCountSteps) maxCountSteps = (int)countSteps.y;
                if (countSteps.z > maxCountSteps) maxCountSteps = (int)countSteps.z;

                this.countSteps = maxCountSteps;
                this.move = true;
                this.timerMove.Start();
            }

            public void startRotate(Point3D vectorRotate, int speed, float newAngle)
            {
                this.vectorRotate = vectorRotate;
                this.newAngle = this.angle + newAngle;

                float dxAngle = this.newAngle - this.angle;
                this.countRotates = Math.Abs((int)(dxAngle / (Object3D.DEG_STEP * speed)));
                this.rotate = true;
                this.timerRotate.Start();

            }

            public Point3D getCoordinate() { return this.coordinate; }
            public void setCoordinate(Point3D newCoordinate) { this.coordinate = newCoordinate; } 

            public bool getMove() { return this.move; }

            public bool getRotate() { return this.rotate; }

            public int getCodeTexture() { return this.codeTexture; }

            public void toggleVisible()
            {
                if (this.visible)
                    this.visible = false;
                else
                    this.visible = true;
            }


            protected void randColor()//беда с цветами
            {
                int countMultiplication;
                for (int i = 0; i < 3; ++i)
                {
                    countMultiplication = (this.radomizer.Next()%2);
                    countMultiplication++;
                    int multiplication = 1;
                    for (int j = 0; j < countMultiplication; ++j)
                    {
                        multiplication *= (this.radomizer.Next()*(this.radomizer.Next(this.radomizer.Next()) % 1000)) % 100;
                        multiplication = multiplication % 100;
                    }
                    multiplication = Math.Abs(multiplication);
                    if (i == 0)
                        this.color.x = (float)(multiplication % 100) / 100;
                    else if (i == 1)
                        this.color.y = (float)(multiplication % 100) / 100;
                    else if (i == 2)
                        this.color.z = (float)(multiplication % 100) / 100;
                }
               /* this.color.x = (float)((this.radomizer.Next() * this.radomizer.Next() * this.radomizer.Next()) % 100) / 100;
                this.color.y = (float)((this.radomizer.Next() * this.radomizer.Next()) % 100) / 100;
                this.color.z = (float)((this.radomizer.Next()) % 100) / 10;*/
            }

            private void nextStep(object sender, EventArgs eventCall)
            {
                Point3D distance;
                distance.x = this.newCoordinate.x - this.coordinate.x;
                distance.y = this.newCoordinate.y - this.coordinate.y;
                distance.z = this.newCoordinate.z - this.coordinate.z;

                Point3D slip = new Point3D(0, 0, 0);
                if (this.countSteps != 0)
                {
                    slip.x = distance.x / this.countSteps;
                    slip.y = distance.y / this.countSteps;
                    slip.z = distance.z / this.countSteps;

                    this.countSteps--;
                }

                this.coordinate.x += slip.x;
                this.coordinate.y += slip.y;
                this.coordinate.z += slip.z;

                if (this.countSteps == 0)
                {
                    this.coordinate = this.newCoordinate;
                    this.timerMove.Stop();
                    this.move = false;
                }

            }

            private void nextRotate(object sender, EventArgs eventCall)
            {
                float dxAngle = this.newAngle - this.angle;

                if (this.countRotates != 0)
                {
                    float slip;
                    slip = dxAngle / this.countRotates;
                    this.angle += slip;

                    this.countRotates--;
                }

                if (this.countRotates == 0)
                {
                    this.angle = this.newAngle;
                    this.timerRotate.Stop();
                    this.rotate = false;
                }
            }

        }
    }
}
