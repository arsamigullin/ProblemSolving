using System.Collections.Generic;
using System.Linq;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList.DetectingLoops
{
    [DisplayInfo("LinkedListSingly", "Detecting Loops: List revercing", typeof(List<string>))]
    public class RevercingCycledLinkedList
    {
        private List<ISinglyCell<string>> linkedList;
        public RevercingCycledLinkedList()
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
            linkedList[6].Next = linkedList[4];
        }

        public List<string> CheckIfLoopExists()
        {
            if (linkedList.First().Next==null) return new List<string> {"Linked list doesn't contain meaningful data"};
            var new_sentinel = Revertlist(linkedList.First());
            Revertlist(new_sentinel);
            if (new_sentinel == linkedList.First())
            {
                return new List<string> { "Linked list contains loop" };
            }
            return new List<string> { "Linked list doesn't contains loop" };
        }

        // sentinel->first->second->third->fourth->fifth->sixth:fourth - initial
        // sentinel<-first<-second<-third<-fourth<-fifth<-sixth:fourth - until fourth after loop
        // sentinel->first->second->third->fourth<-fifth<-sixth:fourth - eventually
        //reversed links in linked list
        private ISinglyCell<string> Revertlist(ISinglyCell<string> sentinel)
        {
            var currcell = sentinel;
            ISinglyCell<string> prev = null;
            while (currcell!=null)
            {
                ISinglyCell<string> next = currcell.Next;
                currcell.Next = prev;
                prev = currcell;
                currcell = next;
            }
            return prev;
        }
    }
}
