using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList
{
    public class LinkedListResultDisplaying
    {
        public List<string> DisplayResult<T>(List<ISinglyCell<T>> list, bool hasSentinel=false)
        {
            if (list.Count == 0)
            {
                return  new List<string>{"There is no data for displaying"};
            }
            List<string> resList = new List<string>();
            if (hasSentinel)
            {
                ISinglyCell<T> cell = list.First();
                while (cell.Next != null)
                {
                    resList.Add("Value: "+ cell.Value+ ", Next Value: "+(cell.Next==null?"null":(cell.Next.Value==null?"null": cell.Next.Value.ToString()))+ "\n");
                    cell = cell.Next;
                }
            }
            else
            {
               // list.Insert(0, new SinglyCell<T>());
                ISinglyCell<T> cell = list.First();
                while (cell != null)
                {
                    resList.Add("Value: " + cell.Value + ", Next Value: " + (cell.Next == null ? "null" : (cell.Next.Value == null ? "null" : cell.Next.Value.ToString()))+ "\n");
                    cell = cell.Next;
                }
            }
            return resList;
        }
    }
}
