using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using vectorEditor.Object;

namespace vectorEditor
{
    class ItemList
    {
        public Object2D object2d;
	    public ItemList next;

        public ItemList(Object2D newObject)
        {
			this.object2d = newObject;
		}

    }

    class ListObject
    {
        private ItemList head;
        private ItemList tail;

        public ListObject(){}

        public void Add(Object2D newObject)
        {
            if (head == null)
            {
                this.head = new ItemList(newObject);
                this.tail = this.head;
            }
            else
            {
                this.tail.next = new ItemList(newObject);
                this.tail = this.tail.next;
            }
        }

        public ItemList getHead() { return this.head; }
        public ItemList getTail() { return this.tail; }

    }
}
