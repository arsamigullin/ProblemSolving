using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Is Linked List Even", typeof(List<string>))]
    class IsLinkedListEven
    {
        public List<string> Go()
        {
            var res = IsLinkedListEvenGo(CreatingLinkedList.Create(new SinglyCell<int>(), 16, false));
            return new List<string>();
        }

        private bool IsLinkedListEvenGo(ISinglyCell<int> head)
        {
            ISinglyCell<int> cell = head;
            while (cell != null && cell.Next!=null)
            {
                cell = cell.Next.Next;
            }
            return cell == null;
        }
            
    }
}
