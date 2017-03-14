using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.TestingYourself
{
    [DisplayInfo("Testing YourSelf - Singly Linked List", "Linked List Determining", typeof(List<int>))]
    class SinglyLinkedListImpl
    {
        //public List<int> Go()
        //{

        //    LinkedNode<int> rootFirst = new LinkedNode<int>();
        //    FillLinkedList(rootFirst);
        //    LinkedNode<int> rootSec = new LinkedNode<int>();
        //    FillLinkedList(rootSec);

        //    return new List<int>();
        //}
        public void FillLinkedList(ILinkedNode<int> root, bool needToBeSorted = false)
        {
            Random r = new Random();
            int[] arr = new int[4];
            arr = arr.Select(x => r.Next(10000)).ToArray();
            if (needToBeSorted) Array.Sort(arr);
            ILinkedNode<int> next = root;
            for (int i = 0; i < arr.Length; i++)
            {
                next.Data = arr[i];

                if (i != arr.Length - 1)
                {
                    next.Next = new LinkedNode<int>();
                    next = next.Next;
                }
            }
        }

        public void FillLinkedListS(ILinkedNode<int> root, bool needToBeSorted = false)
        {
            Random r = new Random();
            int[] arr = new int[4];
            arr = arr.Select(x => r.Next(10000)).ToArray();
            if (needToBeSorted) Array.Sort(arr);
            ILinkedNode<int> next = root;
            for (int i = 0; i < arr.Length; i++)
            {
                next.Data = arr[i];

                if (i != arr.Length - 1)
                {
                    next.Next = new LinkedNode<int>();
                    next = next.Next;
                }
            }
        }
    }



    class LinkedNode<T> :ILinkedNode<T> where T : IComparable<T>
    {

        public T Data { get; set; }
        public ILinkedNode<T> Next { get; set; }
        public int CompareTo(T other)
        {
            return Data.CompareTo(other);
        }
    }

    interface ILinkedNode<T> : IComparable<T>
    {
        T Data { get; set; }
        ILinkedNode<T> Next { get; set; }
    }

    
}
