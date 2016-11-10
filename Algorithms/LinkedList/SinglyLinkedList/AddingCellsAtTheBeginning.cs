using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    // This algorithms suppose using sentinel
    [DisplayInfo("LinkedListSingly", "Adding Cells At the beginning", typeof(List<bool>))]
    public class AddingCellsAtTheBeginning
    {
        private List<ISinglyCell<string>> linkedList;

        public AddingCellsAtTheBeginning()
        {
            initializeLnkedList();

        }
        public List<bool> AddItemWithSentinels ()
        {
            ISinglyCell<string> cellAtTheBeginnig = new SinglyCell<string> {Value = "I must be at the beginning"};
            // get sentinel cell
            ISinglyCell<string> sentinelCell = linkedList.First();
            ISinglyCell<string> nextCell = sentinelCell.Next;
            sentinelCell.Next = cellAtTheBeginnig;
            cellAtTheBeginnig.Next = nextCell;
            linkedList.Add(cellAtTheBeginnig);
            //LinkedListNode<listItem> newcell = new LinkedListNode<listItem>(new listItem { Number = 2, Text = "text0" });
            // Microsoft LinkedList contains methods to add cells in any place of a linkedlist
            // and next code doesn't compile, because Next property is read only

            //newcell.Next = linklist.First.Next;
            //linklist.First.Next = newcell;

            return new List<bool>();
        }

        public List<bool> AddItemWithoutSentinels()
        {
            initializeLnkedList();
            ISinglyCell<string> cellAtTheBeginnig = new SinglyCell<string> { Value = "I must be at the beginning" };
            // get first cell
            ISinglyCell<string> sentinelCell = linkedList.First();
            cellAtTheBeginnig.Next = sentinelCell;
            linkedList.Add(cellAtTheBeginnig);
            return new List<bool>();
        }

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
