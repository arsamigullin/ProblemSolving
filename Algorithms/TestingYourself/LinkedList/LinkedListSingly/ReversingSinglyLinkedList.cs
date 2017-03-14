using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.TestingYourself.LinkedList.LinkedListSingly
{
    [DisplayInfo("Testing YourSelf - Singly Linked List", "Reversing Linked List", typeof(List<int>))]
    class ReversingSinglyLinkedList
    {
        public List<int> Go()
        {
            SinglyLinkedListImpl imp = new SinglyLinkedListImpl();
            ILinkedNode<int>  root = new LinkedNode<int>();
            imp.FillLinkedList(root);
            rev(root);
            //  Reverse(root);
            return new List<int>();
        }

        private void rev(ILinkedNode<int> root)
        {
            ILinkedNode<int> prev = null;
            ILinkedNode<int> cell = root;
            while (cell != null)
            {
                ILinkedNode<int> Next = cell.Next;
                cell.Next = prev;
                prev = cell;
                cell = Next;
            }
        }





















        private void Reverse(ILinkedNode<int> root)
        {
            if (root==null) return;
            ILinkedNode<int> cur = root;
            ILinkedNode<int> prev = null;
            while (cur!=null)
            {
                ILinkedNode<int> next = cur.Next;
                cur.Next = prev;

                prev = cur;
                cur = next;
            }
        }
    }
}
