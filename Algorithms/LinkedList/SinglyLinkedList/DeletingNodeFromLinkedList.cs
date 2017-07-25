using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Deleting Node from Linked List", typeof(List<string>))]
    class DeletingNodeFromLinkedList
    {
        public List<int> Go()
        {
            ISinglyCell <int> head = CreatingLinkedList.Create(new SinglyCell<int>(), 10, false);
            return new List<int>();
        }
        // O(N)
        private ISinglyCell<int> DeleteNode(ISinglyCell<int> head, int position)
        {
            if (head == null) return head;
            if (position == 1)
            {
                return head.Next;
            }
            ISinglyCell<int> previouCell = head;
            ISinglyCell<int> nextCell = head;
            int k = 1;
            while (nextCell != null && k<position)
            {
                k++;
                previouCell = nextCell;
                nextCell = nextCell.Next;
            }

            if (nextCell == null)
            {
                return head;
            }

            previouCell.Next = nextCell.Next;
            return head;
        }
    }
}
