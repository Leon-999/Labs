using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenGL.Object;
using OpenGL.Move;

namespace OpenGL
{
    class ManagerMoves
    {
        public ManagerMoves() { this.moves = new BaseMove[100]; }

        private BaseMove[] moves;


        public void oscillatoryMove(Object3D moveable, Point3D secondPoint,int speed, int countOscillation = -1)
        {
            this.moves[this.moves.Length - 1] = new OscillatoryMove(moveable, secondPoint, speed, countOscillation);
        }

        public void rotate(Object3D moveable, Point3D vectorRotate, int speed, float angle = 360, int countTurn = -1)
        {
            this.moves[this.moves.Length - 1] = new Rotate(moveable, vectorRotate, speed, angle, countTurn);
        }

        public void circleWise(Object3D moveable,float radius, bool sunwise, int speed, int countTurn = -1)
        {
            this.moves[this.moves.Length - 1] = new CircleWise(moveable, radius, sunwise, speed, countTurn);
        }

    }
}
