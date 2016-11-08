using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Iterating Over Singly Linked List", typeof(List<listItem>))]
    public class IteratingOverTheList
    {
        public class listItem
        {
            public int Number { get; set; }
            public string Text { get; set; }
        }

        LinkedList<listItem> linklist = new LinkedList<listItem>();

        public IteratingOverTheList ()
        {
            linklist.AddLast(new listItem { Number = 3, Text = "text1" });
            linklist.AddLast(new listItem { Number = 4, Text = "text2" });
            linklist.AddLast(new listItem { Number = 5, Text = "text3" });
            linklist.AddLast(new listItem { Number = 6, Text = "text4" });
            linklist.AddLast(new listItem { Number = 7, Text = "text5" });
            linklist.AddLast(new listItem { Number = 8, Text = "text6" });

        }
        // Complexity O(N)
        public List<listItem> Iterate ()
        {
            List<listItem> resList = new List<listItem>();
            LinkedListNode<listItem> cell = linklist.First;
            while (cell != null)
            {
                resList.Add(cell.Value);
                cell = cell.Next;
            }
            return resList;
        }
    }
}
