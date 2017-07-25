using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
   public static class CreatingLinkedList
    {
        public static ISinglyCell<int> Create(ISinglyCell<int> head, int length, bool needToBeSorted)
        {
            Random r = new Random();
            int[] arr = new int[length];
            arr = arr.Select(x => r.Next(10000)).ToArray();
            if (needToBeSorted) Array.Sort(arr);
            ISinglyCell<int> next = head;
            for (int i = 0; i < arr.Length; i++)
            {
                next.Value = arr[i];
                if (i != arr.Length - 1)
                {
                    next.Next = new SinglyCell<int>();
                    next = next.Next;
                }
            }

            return head;
        }
    }
}
