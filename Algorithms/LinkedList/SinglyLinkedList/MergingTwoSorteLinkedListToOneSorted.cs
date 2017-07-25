using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Merging two sorted linked list to one sorted : Recursive, Iterative", typeof(List<string>))]
    class MergingTwoSorteLinkedListToOneSorted
    {
        public List<string> Go()
        {
            ISinglyCell<int> list1 = CreatingLinkedList.Create(new SinglyCell<int>(), 4, true);
            ISinglyCell<int> list2 = CreatingLinkedList.Create(new SinglyCell<int>(), 3, true);
            var res = RecursiveMerging(list2, list1);
            return new List<string>();
        }

        private ISinglyCell<int> RecursiveMerging(ISinglyCell<int> list1, ISinglyCell<int> list2)
        {
            ISinglyCell<int> result = null;
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            if (list1.Value <= list2.Value)
            {
                result = list1;
                result.Next = RecursiveMerging(list1.Next, list2);
            }
            else
            {
                result = list2;
                result.Next = RecursiveMerging(list2.Next, list1);
            }
            return result;
        }
    }
}
