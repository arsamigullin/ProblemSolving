using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.DoublyLinkedList.DoublyCellDescription;

namespace Algorithms.LinkedList.DoublyLinkedList
{
    [DisplayInfo("LinkedListDoubly", "Insertionsort Linked List ", typeof(List<string>))]
    public class InsertionSortingDoubly
    {
        private List<IDoublyCell<int>> doublyLinkedList;
        public InsertionSortingDoubly()
        {
            doublyLinkedList = new List<IDoublyCell<int>>
            {
                new DoublyCell<int> {Value  = 9},
                new DoublyCell<int> {Value  = 5},
                new DoublyCell<int> {Value  = 6},
                new DoublyCell<int> {Value  = 87},
                new DoublyCell<int> {Value  = -5},
                new DoublyCell<int> {Value  = 20},
                new DoublyCell<int> {Value  = 118},

            };
            // Filling Next references
            for (int i = 0; i < doublyLinkedList.Count; i++)
            {
                if (i== doublyLinkedList.Count-1) break;
                doublyLinkedList[i].Next = doublyLinkedList[i + 1];
            }
            // Filling Previous references
            for (int i = doublyLinkedList.Count-1; i >= 0; i--)
            {
                if (i==0) break;
                doublyLinkedList[i].Previous= doublyLinkedList[i -1];
            }
        }

        public List<string> Sort()
        {
            // initial cell of the sorted Linked List
            IDoublyCell<int> sentinel = new DoublyCell<int>();
            sentinel.Next = null;
            sentinel.Previous = null;
            IDoublyCell<int> cell = doublyLinkedList.First();
            while (cell!=null)
            {
                IDoublyCell<int> nextCell = cell;
                // for moving cycle
                cell = cell.Next;
                IDoublyCell<int> afterMe = sentinel;
                while (afterMe.Next!=null && afterMe.Next.Value<nextCell.Value)
                {
                    afterMe = afterMe.Next;
                }
                // If afterMe.Next == null, means that we reached end of list
                if (afterMe.Next != null)
                {
                    // update Previous reference of the existing cell
                    afterMe.Next.Previous = nextCell;
                }
                // Update Previous reference of the new cell
                nextCell.Previous = afterMe;
                // Update Next reference of the new cell
                nextCell.Next = afterMe.Next;
                //update Next reference of the existing cell
                afterMe.Next = nextCell;
            }
            return  new List<string> { "DONE"};
        }
    }
}
