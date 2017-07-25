using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Printing Linked List Data From The End ", typeof(List<string>))]
    class PrintingLinkedListDataFromTheEnd
    {
        public List<string> Go()
        {
            ISinglyCell<int> cell = CreatingLinkedList.Create(new SinglyCell<int>(), 10, false);
            Print(cell);
            return new List<string>();
        }

        private void Print(ISinglyCell<int> head)
        {
            if (head==null) return;
            Print(head.Next);
            Console.Write(head.Value);
        }
    }
}
