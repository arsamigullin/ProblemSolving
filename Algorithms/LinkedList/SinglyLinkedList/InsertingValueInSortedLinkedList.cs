using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Inserting Node In Sorted Linked List", typeof(List<string>))]
    class InsertingValueInSortedLinkedList
    {
        public List<string> Go()
        {
            ISinglyCell<int> cell = CreatingLinkedList.Create(new SinglyCell<int>(), 10, true);
            ISinglyCell<int> givenNode = new SinglyCell<int>();
            givenNode.Value = 5465;
            ISinglyCell<int> res = InsertIntoSortingLinkedList(cell, givenNode);
            return new List<string>();
        }
        // O(N)
        private ISinglyCell<int> InsertIntoSortingLinkedList(ISinglyCell<int> head, ISinglyCell<int> givenNode)
        {
            if (head == null) return head;
            ISinglyCell<int> nextNode = head;
            ISinglyCell<int> previousNode = head;

            // Keep track previous Node and next Node. 
            while (nextNode!=null && nextNode.Value < givenNode.Value)
            {
                previousNode = nextNode;
                nextNode = nextNode.Next;
            }
            // Given Node will be inserted between those values.
             previousNode.Next = givenNode;
            givenNode.Next = nextNode;
            return head;
        }
    }
}
