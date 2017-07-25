using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Finding The Middle Of LinkedList", typeof(List<string>))]
    class FindingTheMiddleOfLinkedList
    {
        public List<string> Go()
        {
            ISinglyCell<int> head = CreatingLinkedList.Create(new SinglyCell<int>(), 5, false);
            ISinglyCell<int> middle = FindTheMiddle(head);
            return new List<string>();
        }

        private ISinglyCell<int> FindTheMiddle(ISinglyCell<int> cell )
        {
            ISinglyCell<int> slowPointer = cell;
            ISinglyCell<int> fastPointer = cell;
            int i = 0;
            while (fastPointer!=null && fastPointer.Next!=null)
            {
                fastPointer = fastPointer.Next.Next;
                slowPointer = slowPointer.Next;
            }
            return slowPointer;
        }
    }
}
