using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Finding Elements Singly Linked List", typeof(List<string>))]
    public class FindingCells
    {
        private List<ISinglyCell<string>> linkedList;

        public FindingCells()
        {
            initializeLnkedList();

        }

        // For implementing search the best way is to add sentinel cell that doesn't contain meaningful data
        public List<string> DoFind()
        {
            string valueToFind = "sixth";
            ISinglyCell<string> cell = linkedList.First();
            while (cell.Next!=null)
            {
                if (cell.Next.Value == valueToFind)
                {
                    break;
                }
                cell = cell.Next;
            }
            return new List<string> {"Finding ended"};
        }
        //you may fi nd one situation where 
        //it fails.If the fi rst cell in the linked list contains the target value, there is no
        //cell before that one, so the algorithm cannot return it.The fi rst value that the
        //algorithm examines is in the list’s second cell, and it never looks back.
        //public List<listItem> FindingWithoutSentinel()
        //{
        //    List<listItem> resList = new List<listItem>();
        //    resList.Add(findwithoutsentinel(linklist.First, linklist.Last.Value));
        //    return resList;
        //}

        //private listItem findwithoutsentinel (LinkedListNode<listItem> top, listItem target)
        //{
        //    if (top == null) return new listItem();
        //    LinkedListNode<listItem> cell= top;
        //    while (cell.Next!=null)
        //    {
        //        if (cell.Next.Value == target) return cell.Next.Value;
        //        cell = cell.Next;
        //    }
        //    // If we get this far, the target is not in the list.
        //    return new listItem();
        //}
        ////A sentinel is a cell that is part of the linked list but that doesn’t contain any meaningful
        ////It is used only as a placeholder so that algorithms can refer to a cell that comes before the first cell.
        //public List<listItem> FindingWithSentinel()
        //{
        //    linklist.AddLast(new listItem { Number = -1, Text = "sentinel" });
        //    List<listItem> resList = new List<listItem>();
        //    resList.Add(findwithsentinel(linklist.First, linklist.First.Value));
        //    return resList;
        //}

        //private listItem findwithsentinel(LinkedListNode<listItem> top, listItem target)
        //{
        //    LinkedListNode<listItem> cell = top;
        //    while (cell.Next != null)
        //    {
        //        if (cell.Next.Value == target) return cell.Next.Value;
        //        cell = cell.Next;
        //    }
        //    // If we get this far, the target is not in the list.
        //    return new listItem();
        //}

        private void initializeLnkedList()
        {
            // Initialize our linked list
            linkedList = new List<ISinglyCell<string>>
            {
                new SinglyCell<string> {Value = "sentinel"},
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

    }
}
