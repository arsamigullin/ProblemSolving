using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    // Problem
    //Suppose there are two singly linked lists both of which intersect at some point and become a single linked list.
    //    The head or start pointers of both the lists are known, but the intersecting node is not known. 
    //    Also, the number of nodes in each of the lists before they intersect is unknown and may be different in each list.
    //    List1 may have n nodes before it reaches the intersection point, and List2 might have m nodes before it reaches the intersection 
    //    point where m and n may be m = n, m<n or m> n. Give an algorithm for finding the merging point.
    [DisplayInfo("LinkedListSingly", "Finding Intersecting Node of Two Intersecting LinkedList", typeof(List<string>))]
    class FindInterSectingNode
    {
        public List<string> Go()
        {
            // Create general tail for two linked lists
            ISinglyCell<int> intermediate = CreatingLinkedList.Create(new SinglyCell<int>(), 4, false);
            // Creat first linked list
            ISinglyCell<int> list1 = CreatingLinkedList.Create(new SinglyCell<int>(), 3, false);
            //set tail
            GetLatestCell(list1).Next=intermediate;
            // Create second Linked List
            ISinglyCell<int> list2 = CreatingLinkedList.Create(new SinglyCell<int>(), 4, false);
            // Set tail
            GetLatestCell(list2).Next = intermediate;
            //Find InterSection Node
            var res = FindIntersectingNode(list1, list2);
            return new List<string>();
        }

        ISinglyCell<int> GetLatestCell(ISinglyCell<int> head)
        {
            ISinglyCell<int> cell = head;
            ISinglyCell<int> prevCell = null;
            while (cell!=null)
            {
                prevCell = cell;
                cell = cell.Next;
            }
            return prevCell;
        }

        private ISinglyCell<int> FindIntersectingNode(ISinglyCell<int> list1, ISinglyCell<int> list2)
        {
            // Determine length of list1
            int l1 = 0;
            int l2 = 0;
            int dif = 0;
            ISinglyCell<int> head1 = list1;
            while (head1!=null)
            {
                l1++;
                head1 = head1.Next;
            }

            ISinglyCell<int> head2 = list2;
            while (head2 != null)
            {
                l2++;
                head2 = head2.Next;
            }

            if (l1 >= l2)
            {
                head1 = list1;
                head2 = list2;
                dif = l1 - l2;
            }
            else
            {
                head1 = list2;
                head2 = list1;
                dif = l2 - l1;
            }

            for (int i = 0; i < dif; i++)
            {
                head1 = head1.Next;
            }

            while (head1!=null && head2!=null)
            {
                if (head1 == head2) return head2;
                head1 = head1.Next;
                head2 = head2.Next;
            }
            return null;
        }
    }
}
