using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;


namespace Algorithms.LinkedList.DoublyLinkedList
{
    [DisplayInfo("DoublyLinkedList", "Reverse list", typeof(List<string>))]
    public class ReverseList
    {
        LinkedList<listItem> microsoftlinklist = new LinkedList<listItem>();
        List<ICell<string>> manualLinkedList = new List<ICell<string>>();

        public class listItem
        {
            public int Number { get; set; }
            public string Text { get; set; }
        }
        public ReverseList()
        {

            createMicrosoftLinkedList();
            createManualLinkedList();

        }


        public List<string> ReverseMicrosoftLinkedList()
        {
            LinkedList<listItem> reversedLinkedList = new LinkedList<listItem>();
            LinkedListNode<listItem> curcell = microsoftlinklist.Last;
            LinkedListNode<listItem> prevcell = microsoftlinklist.Last;
            while (microsoftlinklist.First != curcell)
            {
                prevcell = microsoftlinklist.First;
                microsoftlinklist.Remove(microsoftlinklist.First);
                microsoftlinklist.AddLast(prevcell);
            }
            return new List<string> {"DONE reversing microsoft linked list"}; 
        }

        public List<string> ReverseMyselfList()
        {
            // we must find latest cell
            ICell<string> sentinel = manualLinkedList.First();
            ICell<string> curCell = sentinel;
            ICell<string> prevCell = null;
            while (curCell != null)
            {
                var nextCell = curCell.Next;
                curCell.Next = prevCell;
                prevCell = curCell;
                curCell = nextCell;
            }
            return new List<string> { "DONE reversing manual linked list" };
        }

        private void createManualLinkedList()
        {
            manualLinkedList = new List<ICell<string>>
            {
                new Cell<string> {Value = "sentinel"},
                new Cell<string> {Value = "fist"},
                new Cell<string> {Value = "second"},
                new Cell<string> {Value = "third"},
                new Cell<string> {Value = "fourth"},
                new Cell<string> {Value = "fifth"},
                new Cell<string> {Value = "sixth"},
            };

            for (int i = 0; i < manualLinkedList.Count-1; i++)
            {
                manualLinkedList[i].Next = manualLinkedList[i + 1];
            }

        }
        public class Cell<T>: ICell<T>
        {
            public ICell<T> Next { get; set; }
            public T Value { get; set; }
        }

        public interface ICell<T>
        {
            ICell<T> Next { get; set; }
            T Value { get; set; }
        }

        private void createMicrosoftLinkedList()
        {
            microsoftlinklist.AddLast(new listItem { Number = -1, Text = "sentinel" });
            microsoftlinklist.AddLast(new listItem { Number = 3, Text = "text1" });
            microsoftlinklist.AddLast(new listItem { Number = 4, Text = "text2" });
            microsoftlinklist.AddLast(new listItem { Number = 5, Text = "text3" });
            microsoftlinklist.AddLast(new listItem { Number = 6, Text = "text4" });
            microsoftlinklist.AddLast(new listItem { Number = 7, Text = "text5" });
            microsoftlinklist.AddLast(new listItem { Number = 8, Text = "text6" });
        }
    }
}
