using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vectorEditor.Object
{
    class Group : Object2D
    {
        ListObject listObject;

        public Group(ListObject newListObject, PictureBox canvas) :
            base(newListObject.getHead().object2d.getCoordinate(), false, canvas)
        {
            this.listObject = newListObject;
        }

        public Group(PictureBox canvas) :
            base(new Point2D(0, 0), false, canvas)
        {
            this.listObject = new ListObject();
        }


        protected override void draw(System.Drawing.Color color)
        {
            if (color != MainForm.COLOR_BACKGROUND)
                for (ItemList i = this.listObject.getHead(); i != null; i = i.next)
                {
                    i.object2d.draw();
                }
            else
                for (ItemList i = this.listObject.getHead(); i != null; i = i.next)
                {
                    i.object2d.clear();
                }
        }

        public override bool inTheArea(Point2D coordinateArea, int widthArea, int heightArea)
        {
            bool answer = false;

            for (ItemList i = this.listObject.getHead(); i != null; i = i.next)
                if (!i.object2d.inTheArea(coordinateArea, widthArea, heightArea))
                {
                    answer = false;
                    break;
                }

            return answer;
        }

        public void addObject(Object2D newObject)
        {
            this.listObject.Add(newObject);
        }

    }
}
