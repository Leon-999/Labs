using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vectorEditor.Object
{
    class Group : Object2D
    {
        ListObject listObject;

        public Group(ListObject newListObject) :
            base(newListObject.getHead().object2d.getCoordinate(), false)
        {
            this.listObject = newListObject;
        }

        public Group() :
            base(new Point2D(0, 0), false)
        {
            this.listObject = new ListObject();
        }


        protected override void draw(System.Windows.Forms.PictureBox canvas, System.Drawing.Color color)
        {
            if (color != MainForm.COLOR_BACKGROUND)
                for (ItemList i = this.listObject.getHead(); i != null; i = i.next)
                {
                    i.object2d.draw(canvas);
                }
            else
                for (ItemList i = this.listObject.getHead(); i != null; i = i.next)
                {
                    i.object2d.clear(canvas);
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

        public void drawLatest(System.Windows.Forms.PictureBox canvas)
        {
            this.listObject.getTail().object2d.draw(canvas);
        }

        public Group selectObjectsFromArea(Point2D coordinateArea, int widthArea, int heightArea)
        {
            Group newGroup = new Group();

            for (ItemList i = this.listObject.getHead(); i != null; i = i.next)
                if (i.object2d.inTheArea(coordinateArea, widthArea, heightArea))
                    newGroup.addObject(i.object2d);

            return newGroup;
        }

    }
}
