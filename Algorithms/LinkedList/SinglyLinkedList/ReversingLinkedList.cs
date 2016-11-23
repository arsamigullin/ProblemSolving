using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Reversing list", typeof(List<string>))]
    public class ReversingLinkedList
    {
        private List<ISinglyCell<string>> linkedList;
        LinkedListResultDisplaying displaying = new LinkedListResultDisplaying();
        public ReversingLinkedList()
        {
            // Initialize our linked list
            linkedList = new List<ISinglyCell<string>>
            {
               // new SinglyCell<string> {Value = "sentinel"},
                new SinglyCell<string> {Value = "fist"},
                new SinglyCell<string> {Value = "second"},
                new SinglyCell<string> {Value = "third"},
                new SinglyCell<string> {Value = "fourth"},
                new SinglyCell<string> {Value = "fifth"},
                new SinglyCell<string> {Value = "sixth"},
            };

            for (int i = 0; i < linkedList.Count - 1; i++)
            {
                linkedList[i].Next = linkedList[i + 1];
            }

        }

        //// Basically we must move three marks:
        ////prev, cur, next
        //public List<string> Reverse()
        //{
        //    ISinglyCell<string> curCell = linkedList.First();
        //    ISinglyCell<string> prev = null;
        //    while (curCell!=null)
        //    {
        //        ISinglyCell<string> next = curCell.Next;
        //        curCell.Next = prev;

        //        prev = curCell;
        //        curCell = next;
        //    }
        //    return new List<string> { "DONE reversing manual linked list" };
        //}

        // Basically we must move three marks:
        //prev, cur, next
        public List<string> ReverseWithoutSentinel()
        {
            ISinglyCell<string> curCell = linkedList[0];
            ISinglyCell<string> prev = null;
            while (curCell!=null)
            {
                ISinglyCell<string> nextCell = curCell.Next;
                curCell.Next = prev;

                prev = curCell;
                curCell = nextCell;
            }
            return displaying.DisplayResult(linkedList);
        }
    }
}
