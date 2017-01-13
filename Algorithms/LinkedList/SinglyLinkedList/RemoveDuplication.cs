using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Remove Duplication ", typeof(List<bool>))]
    class RemoveDuplication
    {
        public RemoveDuplication()
        {
            
        }

        public List<bool> Go()
        {
            ISinglyCell<int> cell1 = null;
            ISinglyCell<int> next = null;
            int i = 0;
            while (i<4)
            {
                if (cell1 == null)
                {
                    cell1 = new SinglyCell<int>();
                    cell1.Value = 1;
                    i++;
                    next = cell1;
                    continue;
                }
                ISinglyCell<int> cell = new SinglyCell<int>();
                cell.Value = 1;
                next.Next = cell;
                next = next.Next;
                i++;
            }
            ISinglyCell<int> outer = cell1;
            while (outer.Next != null )
            {
                if (outer.Value == outer.Next.Value)
                {
                    outer.Next = outer.Next.Next;
                }
            }

            return new List<bool>();
        }
    }
}
