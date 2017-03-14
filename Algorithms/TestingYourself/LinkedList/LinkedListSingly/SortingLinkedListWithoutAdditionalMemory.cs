using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.TestingYourself.LinkedList.LinkedListSingly
{
    [DisplayInfo("Testing YourSelf - Singly Linked List", "Sorting Linked List Without Additional Memory", typeof(List<int>))]
    class SortingLinkedListWithoutAdditionalMemory
    {
        public List<int> Go()
        {
            SinglyLinkedListImpl imp = new SinglyLinkedListImpl();
            ILinkedNode<int> root = new LinkedNode<int>();
            imp.FillLinkedList(root);
            Sort(root);
            return new List<int>();
        }

        //private ILinkedNode<int> SortRecurs(ILinkedNode<int> root, int cmpr)
        //{
        //    if (root == null) return null;
        //   // if (root.Next == null) return root;
        //    ILinkedNode<int> maxNode = null;
        //    if (root.Data.CompareTo(root.Next.Data) >= 0)
        //    {
        //        maxNode = root;
        //    }
        //    else
        //    {
        //        maxNode = root.Next;
        //    }
        //    int min = Math.Min(root.Data, cmpr);
        //    ILinkedNode<int> node = SortRecurs()

        //}

        private void Sort(ILinkedNode<int> root)
        {
            ILinkedNode<int> cell = root;
            ILinkedNode<int> sorted = new LinkedNode<int>();
            while (cell!=null)
            {
                ILinkedNode<int> next = cell.Next;
                cell = cell.Next;
                ILinkedNode<int> after_me = sorted;
                while (after_me != null && after_me.Data<next.Data)
                {
                    after_me = after_me.Next;
                }
              
                next.Next = after_me;
                after_me.Next = next;
            }
        }
    }
}
