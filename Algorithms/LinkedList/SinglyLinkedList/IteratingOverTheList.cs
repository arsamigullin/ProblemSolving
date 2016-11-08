using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Iterating Over Singly Linked List", typeof(List<long>))]
    public class IteratingOverTheList
    {
        LinkedList<int> linklist = new LinkedList<int>();

        public IteratingOverTheList ()
        {
            linklist.AddLast(1);
            linklist.AddLast(4);
            linklist.AddLast(8);
            linklist.AddLast(10);
            linklist.AddLast(12);
            linklist.AddLast(17);

        }
        public List<long> Iterate ()
        {
            List<long> resList = new List<long>();
            LinkedListNode<int> cell = linklist.First;
            while (cell != null)
            {
                resList.Add(cell.Value);
                cell = cell.Next;
            }
            return resList;
        }
    }
}
