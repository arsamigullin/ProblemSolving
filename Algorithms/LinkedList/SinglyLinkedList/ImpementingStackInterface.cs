using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList
{
    [DisplayInfo("LinkedListSingly", "Implementing Stack Interface", typeof(List<string>))]
    public class ImpementingStackInterface
    {
        public List<string> Stack()
        {
            StackFromLinkedList<int> stackLinkedList = new StackFromLinkedList<int>();
            stackLinkedList.Push(4);
            stackLinkedList.Push(5);
            stackLinkedList.Push(6);

            var popres = stackLinkedList.Pop();
            popres = stackLinkedList.Pop();
            popres = stackLinkedList.Pop();
            return new List<string>();
        }
    }
    // Custom Stack Interface
    public interface StackInterface<T>
    {
        void Push(T value);
        T Pop();
    }

    // Custom Stack interface implementation
    // FIFO
    public class StackFromLinkedList<T> : StackInterface<T>
    {
        private ISinglyCell<T> initialCell;

        // First input
        public void Push(T value)
        {
            if (initialCell == null)
            {
                initialCell = new SinglyCell<T>();
                initialCell.Value = value;
                return;
            }
            ISinglyCell<T> newCell = new SinglyCell<T>();
            newCell.Value = value;
            newCell.Next = initialCell;
            initialCell = newCell;
        }
        // Last output
        public T Pop()
        {
            if (initialCell == null)
            {
                return default(T);
            }
            ISinglyCell<T> popedCell = initialCell;
            initialCell = popedCell.Next;
            return popedCell.Value;
        }
    }

}
