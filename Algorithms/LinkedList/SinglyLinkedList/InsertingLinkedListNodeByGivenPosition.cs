using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Inserting Node by Given Position", typeof(List<string>))]
    class InsertingLinkedListNodeByGivenPosition
    {
        private ISinglyCell<int> head;

        public InsertingLinkedListNodeByGivenPosition()
        {
            head = CreatingLinkedList.Create(new SinglyCell<int>(), 10, false);
        }
        public List<int> Go()
        {
            var res = InsertNodeAtPosition(head, 1, 78);
            res = InsertNodeAtPosition(head, 4, 78);
            return new List<int>();
        }
        // O(N)
        private ISinglyCell<int> InsertNodeAtPosition(ISinglyCell<int> head, int position, int value)
        {
            SinglyCell<int> newNode = new SinglyCell<int> {Value = value};
            if (head == null)
            {
                head = newNode;
            }
            if (position == 1)
            {
                newNode.Next = head;
                return newNode;
            }
            int k = 1;
            ISinglyCell<int> prevNode=head;
            ISinglyCell<int> nextNode = head;
            while (nextNode!=null && k<position)
            {
                k++;
                prevNode = nextNode;
                nextNode = nextNode.Next;
            }
            prevNode.Next = newNode;
            newNode.Next = nextNode;
            return head;
        }
    }
}
