using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList.DetectingLoops
{
    [DisplayInfo("LinkedListSingly", "Detecting Loops: List Reacting", typeof(List<bool>))]
    public class ListRetracing
    {
        private List<ISinglyCell<string>> linkedList;
        public ListRetracing()
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
        // Return true if the list has a loop.
        // If the list has a loop, break it.
        public List<bool> FindLoop()
        {
            ISinglyCell<string> sentinel= linkedList.First();
            ISinglyCell<string> cell = linkedList.First();
            while (cell.Next!=null)
            {
                // See if we already visited the next cell.
                ISinglyCell<string> tracer = sentinel;
                while (tracer!=cell)
                {
                    if (tracer.Next == cell.Next)
                    {
                        // This is the start of a loop.
                        // Break the loop and return true.
                        return new List<bool> { true };
                    }
                    tracer = tracer.Next;
                }
                // Move to the next cell.
                cell = cell.Next;
            }
            return new List<bool> { false };
        }
    }
}
