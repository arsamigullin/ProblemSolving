using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Finding Elements Singly Linked List", typeof(List<listItem>))]
    public class FindingCells
    {
        public class listItem
        {
            public int Number { get; set; }
            public string Text { get; set; }
        }

        LinkedList<listItem> linklist = new LinkedList<listItem>();

        public FindingCells()
        {
            linklist.AddLast(new listItem { Number = 3, Text = "text1" });
            linklist.AddLast(new listItem { Number = 4, Text = "text2" });
            linklist.AddLast(new listItem { Number = 5, Text = "text3" });
            linklist.AddLast(new listItem { Number = 6, Text = "text4" });
            linklist.AddLast(new listItem { Number = 7, Text = "text5" });
            linklist.AddLast(new listItem { Number = 8, Text = "text6" });

        }
        //you may fi nd one situation where 
        //it fails.If the fi rst cell in the linked list contains the target value, there is no
        //cell before that one, so the algorithm cannot return it.The fi rst value that the
        //algorithm examines is in the list’s second cell, and it never looks back.
        public List<listItem> FindingWithoutSentinel()
        {
            List<listItem> resList = new List<listItem>();
            resList.Add(findwithoutsentinel(linklist.First, linklist.Last.Value));
            return resList;
        }

        private listItem findwithoutsentinel (LinkedListNode<listItem> top, listItem target)
        {
            if (top == null) return new listItem();
            LinkedListNode<listItem> cell= top;
            while (cell.Next!=null)
            {
                if (cell.Next.Value == target) return cell.Next.Value;
                cell = cell.Next;
            }
            // If we get this far, the target is not in the list.
            return new listItem();
        }
        //A sentinel is a cell that is part of the linked list but that doesn’t contain any meaningful
        //It is used only as a placeholder so that algorithms can refer to a cell that comes before the first cell.
        public List<listItem> FindingWithSentinel()
        {
            linklist.AddLast(new listItem { Number = -1, Text = "sentinel" });
            List<listItem> resList = new List<listItem>();
            resList.Add(findwithsentinel(linklist.First, linklist.First.Value));
            return resList;
        }

        private listItem findwithsentinel(LinkedListNode<listItem> top, listItem target)
        {
            LinkedListNode<listItem> cell = top;
            while (cell.Next != null)
            {
                if (cell.Next.Value == target) return cell.Next.Value;
                cell = cell.Next;
            }
            // If we get this far, the target is not in the list.
            return new listItem();
        }

    }
}
