using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Insertionsort Linked List ", typeof(List<string>))]
    public class InsertionSortingSingly
    {
        private List<ISinglyCell<int>> firstOrderedLinkedList;
        public InsertionSortingSingly()
        {
            firstOrderedLinkedList = new List<ISinglyCell<int>>
            {
               // new SinglyCell<int> {Value = -1},
                new SinglyCell<int> {Value = 8},
                new SinglyCell<int> {Value = 3},
                new SinglyCell<int> {Value = 6},
                new SinglyCell<int> {Value = 18},
                new SinglyCell<int> {Value = 9},
                new SinglyCell<int> {Value = 0},
                new SinglyCell<int> {Value = 157},
            };

            for (int i = 0; i < firstOrderedLinkedList.Count - 1; i++)
            {
                firstOrderedLinkedList[i].Next = firstOrderedLinkedList[i + 1];
            }
        }

        public List<string> Sort()
        {
            List<string> resList = new List<string>();

            ISinglyCell<int> cell = firstOrderedLinkedList.First();
            ISinglyCell<int> sentinel = new SinglyCell<int>();
            sentinel.Next = null;
            while (cell!=null)
            {
                // Get the next cell to add to the list.
                ISinglyCell<int> nextCell = cell;
                // Move input to input.Next for the next trip through the loop.
                cell = cell.Next;
                // See where to add the next item in the sorted list.
                ISinglyCell<int> afterMe = sentinel;
                while (afterMe.Next != null && afterMe.Next.Value < nextCell.Value)
                {
                    afterMe = afterMe.Next;
                }

                // Insert the item in the sorted list.
                nextCell.Next = afterMe.Next;
                afterMe.Next = nextCell;
            }

            return resList;
        }
    }
}
