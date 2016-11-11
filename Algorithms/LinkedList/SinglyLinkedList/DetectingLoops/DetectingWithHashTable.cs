using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList.DetectingLoops
{
    [DisplayInfo("LinkedListSingly", "Detecting Loops: Detecting with Hash Table", typeof(List<bool>))]
    public class DetectingWithHashTable
    {
        private List<ISinglyCell<string>> linkedList;
        public DetectingWithHashTable()
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
                new SinglyCell<string> {Value = "seventh"},
            };

            for (int i = 0; i < linkedList.Count - 1; i++)
            {
                linkedList[i].Next = linkedList[i + 1];
            }
            linkedList[7].Next = linkedList[4];
        }
        public List<bool> CheckIfLinkedListContainsLoop()
        {
            bool isContainsLoop = false;
            IDictionary<ISinglyCell<string>,int> dictionary = new ConcurrentDictionary<ISinglyCell<string>, int>();
            ISinglyCell<string> cell = linkedList.First();
            while (cell != null)
            {
                if (dictionary.ContainsKey(cell))
                {
                    isContainsLoop = true;
                    break;
                }
                dictionary.Add(cell,0);
                cell = cell.Next;
            }


            return new List<bool> {isContainsLoop};
        }
    }
}
