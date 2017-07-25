using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Reversing LinkedList", typeof(List<bool>))]
    class ReversingLinkedList
    {
        public List<bool> Go()
        {
            ISinglyCell<int> cell = CreatingLinkedList.Create(new SinglyCell<int>(), 10, false);
            var f =  Reverse(cell);
            return new List<bool>();
        }

        private ISinglyCell<int> Reverse(ISinglyCell<int> head)
        {
            ISinglyCell<int> prev = null;
            while (head != null)
            {
                ISinglyCell<int> next = head.Next;
                head.Next = prev;
                prev = head;
                head = next;
            }
            // !!!! Don't forget we have to return prev instead of head
            return prev;
        }
    }
}
