using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Merging two sorted linked list to one sorted", typeof(List<string>))]
    public class MergingTwoSortedLinkedListToOneSorted
    {
        private List<ISinglyCell<int>> firstOrderedLinkedList;
        private List<ISinglyCell<int>> secondOrderedLinkedList;
        LinkedListResultDisplaying displaying = new LinkedListResultDisplaying();

        public MergingTwoSortedLinkedListToOneSorted()
        {
            firstOrderedLinkedList = new List<ISinglyCell<int>>
            {
               // new SinglyCell<int> {Value = -1},
                new SinglyCell<int> {Value = 0},
                new SinglyCell<int> {Value = 6},
                new SinglyCell<int> {Value = 8},
                new SinglyCell<int> {Value = 9},
                new SinglyCell<int> {Value = 15},
                new SinglyCell<int> {Value = 17},
                new SinglyCell<int> {Value = 20},
            };

            for (int i = 0; i < firstOrderedLinkedList.Count - 1; i++)
            {
                firstOrderedLinkedList[i].Next = firstOrderedLinkedList[i + 1];
            }

            secondOrderedLinkedList = new List<ISinglyCell<int>>
            {
               // new SinglyCell<int> {Value = -1},
                new SinglyCell<int> {Value = 3},
                new SinglyCell<int> {Value = 4},
                new SinglyCell<int> {Value = 7},
                new SinglyCell<int> {Value = 10},
                new SinglyCell<int> {Value = 11},
                new SinglyCell<int> {Value = 18},
                new SinglyCell<int> {Value = 21},
            };

            for (int i = 0; i < secondOrderedLinkedList.Count - 1; i++)
            {
                secondOrderedLinkedList[i].Next = secondOrderedLinkedList[i + 1];
            }
        }

        public List<string> Merge()
        {
            // We must take first cell from both linked lists
            ISinglyCell<int> cellfromFirst = firstOrderedLinkedList.First();
            ISinglyCell<int> cellfromSecond = secondOrderedLinkedList.First();
            List<ISinglyCell<int>> mergedList = new List<ISinglyCell<int>>();
            // We must save last inserted cell to general list for updating his Next reference
            ISinglyCell<int> lastInserted = null;
            while (cellfromFirst!=null )
            {
                // if second linked list shorter of first linked list
                // we just insert values from first single list
                if (cellfromSecond == null)
                {
                    lastInserted = insert(cellfromFirst,  lastInserted, mergedList);
                    cellfromFirst = cellfromFirst.Next;
                    continue;
                }

                while (cellfromSecond!=null)
                {

                    if (cellfromFirst==null || cellfromFirst.Value >= cellfromSecond.Value)
                    {
                        lastInserted = insert(cellfromSecond,  lastInserted, mergedList);
                        cellfromSecond = cellfromSecond.Next;
                    }
                    else
                    {
                        lastInserted = insert( cellfromFirst,  lastInserted, mergedList);
                        cellfromFirst = cellfromFirst.Next;
                    }
                }
              
            }
            return displaying.DisplayResult(mergedList);
        }

        private ISinglyCell<int> insert(ISinglyCell<int> first,  ISinglyCell<int> lastinserted, List<ISinglyCell<int>> mergedList )
        {
            if (lastinserted != null)
            {
                lastinserted.Next = first;
            }
            mergedList.Add(first);
            return first;
        }

    }
}
