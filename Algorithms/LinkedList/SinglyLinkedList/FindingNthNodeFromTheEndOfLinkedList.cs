using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Finding Nth Node From The End Of LinkedList", typeof(List<string>))]
    class FindingNthNodeFromTheEndOfLinkedList
    {
        public List<string> Go()
        {

            return new List<string>();
        }

        private ISinglyCell<int> GetNthNodeFromTheEnd(ISinglyCell<int> head, int NthNode)
        {
            ISinglyCell<int> tCell = head;
            ISinglyCell<int> pNthNodeCell = null;
            // Move first pointer from the head to NthNode node
            for (int count = 1; count < NthNode; count++)
            {
                if (tCell != null)
                {
                    tCell = tCell.Next;
                }
            }
            // tCell- node is 4 point far away from the begining
            // pNthNodeCell - node starting from the begining
            while (tCell!=null)
            {
                if (pNthNodeCell == null)
                {
                    pNthNodeCell = head;
                }
                else
                {
                    // They are both moves simultaneously 
                    // And after tCell reaches last cell, pNthNodeCell will contain node that is located from the End at N
                    pNthNodeCell = pNthNodeCell.Next;
                    tCell = tCell.Next;
                }
            }
            if (pNthNodeCell == null) return null;
            return pNthNodeCell;
        }
    }
}
