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

        public void addObject(Object2D newObject)
        {
            this.listObject.Add(newObject);
        }

        public void drawLatest(System.Windows.Forms.PictureBox canvas)
        {
            this.listObject.getTail().object2d.draw(canvas);
        }

    }
}
