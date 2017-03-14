using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.TestingYourself.LinkedList.LinkedListSingly
{
    [DisplayInfo("Testing YourSelf - Singly Linked List", "Merging two sorted Linked List to one sorted", typeof(List<int>))]
    class MergingTwoLinkedListIntoOne
    {
        public List<int> Go()
        {
            SinglyLinkedListImpl imp = new SinglyLinkedListImpl();
            ILinkedNode<int> rootfirst = new LinkedNode<int>();
            ILinkedNode<int> rootsec = new LinkedNode<int>();
            imp.FillLinkedList(rootfirst, true);
            imp.FillLinkedListS(rootsec, true);
            //Merge(rootfirst, rootsec);
            ILinkedNode<int> merged = MergeLists(rootfirst, rootsec);
            return new List<int>();
        }














        /// <summary>
        /// More Efficient solution
        /// </summary>
        /// <param name="rootF"></param>
        /// <param name="rootS"></param>
        /// <returns></returns>
        ILinkedNode<int> MergeLists(ILinkedNode<int> rootF, ILinkedNode<int> rootS)
        {
            if (rootF == null) return rootS;
            if (rootS == null) return rootF;
            int res = rootF.CompareTo(rootS.Data);
            if (res<0)
            {
                rootF.Next = MergeLists(rootF.Next, rootS);
                return rootF;
            }
            rootS.Next = MergeLists(rootS.Next, rootF);
            return rootS;
        }

        void Merge(ILinkedNode<int> rootF, ILinkedNode<int> rootS)
        {
            ILinkedNode<int> merged = null;
            ILinkedNode<int> lastmerged = new LinkedNode<int>();
            ILinkedNode<int> first = rootF;
            ILinkedNode<int> second = rootS;
            while (first!=null || second!=null)
            {
                if (first == null)
                {
                    lastmerged = addValToGener(lastmerged, second);
                    second = second.Next;
                    continue;
                }
                if (second == null)
                {
                    lastmerged = addValToGener(lastmerged, first);
                    first = first.Next;
                    continue;
                }

                while (second!=null && first != null)
                {
                    int res = first.CompareTo(second.Data);
                    if (res >= 0)
                    {
                        ILinkedNode<int> nexts = second.Next;
                        lastmerged = addValToGener(lastmerged,  second);
                        second = nexts;
                    }
                    else if (res < 0)
                    {
                        ILinkedNode<int> nextf = first.Next;
                        lastmerged = addValToGener(lastmerged,  first);
                        first = nextf;
                    }
                }
            }
        }

        static ILinkedNode<int> addValToGener(ILinkedNode<int> lastAddedCell, ILinkedNode<int> toAdded1)
        {

            lastAddedCell.Next = toAdded1;
            return toAdded1;
        }
    }
}
