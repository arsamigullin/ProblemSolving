using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList.DetectingLoops
{
    [DisplayInfo("LinkedListSingly", "Loop in Linked List: 1.Determine existing 2.Getting FirstElement of Loop 3.Getting length of Loop ", typeof(List<string>))]
    class DoesLinkedListHasALoop
    {
        public List<string> Go()
        {
            ISinglyCell<int> head = CreatingLinkedList.Create(new SinglyCell<int>(), 10, false);
            ISinglyCell<int> cell = head;
            ISinglyCell<int> givenCell=null;
            ISinglyCell<int> previousCell=null;
            int k = 1; // To create loop the end.Next will point to the k-th node from the begining. 
            while (cell!=null) 
            {
                if (k == 4)
                {
                    givenCell = cell;
                }
                previousCell = cell;
                cell = cell.Next;
                k++;
            }
            previousCell.Next = givenCell;
            var res = DoesLLhasALoop(head);
            return new List<string>();
        }

        //Determine existing
        private bool DoesLLhasALoop(ISinglyCell<int> head)
        {
            ISinglyCell<int> slPointer = head;
            ISinglyCell<int> fastPointer = head;
            // The Hare and Tortoise principle. This approach was found out by Floyd. 
            while (slPointer!=null && fastPointer!=null && fastPointer.Next!=null)
            {
                slPointer = slPointer.Next; // slow pointer will point to the next
                fastPointer = fastPointer.Next.Next; // slow pointer will point over one point
                if (slPointer == fastPointer) return true;
            }
            return false;
        }
        // Getting FirstElement of Loop
        private ISinglyCell<int> FingBeginOfLoop(ISinglyCell<int> head)
        {
            ISinglyCell<int> slowPointer = head;
            ISinglyCell<int> fastPointer = head;
            bool isCycleExists = false;
            while (slowPointer!=null && fastPointer!=null && fastPointer.Next!=null)
            {
                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next.Next;
                if (slowPointer == fastPointer)
                {
                    isCycleExists = true;
                    break;
                }
            }
            if (!isCycleExists) return null;
            // Reseting slowPointer
            slowPointer = head;
            // Further slow and fast Pointers will move the same speed.
            while (slowPointer!=fastPointer)
            {
                fastPointer = fastPointer.Next;
                slowPointer = slowPointer.Next;
            }
            return slowPointer;
        }

        //Getting length of Loop
        int FindLoopLength(ISinglyCell<int> head)
        {
            ISinglyCell<int> slowPointer = head;
            ISinglyCell<int> fastPointer = head;
            bool isCycleExists = false;
            while (slowPointer != null && fastPointer != null && fastPointer.Next != null)
            {
                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next.Next;
                if (slowPointer == fastPointer)
                {
                    isCycleExists = true;
                    break;
                }
            }
            if (!isCycleExists) return 0;
            int counter = 0;
            // Reseting slowPointer
            fastPointer = fastPointer.Next;
            // Further slow and fast Pointers will move the same speed.
            while (slowPointer != fastPointer)
            {
                counter++;
                fastPointer = fastPointer.Next;
            }
            return counter;
        }

    }
}
