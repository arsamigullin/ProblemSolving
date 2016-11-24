using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.LinkedList.DoublyLinkedList;

namespace Algorithms.LinkedList.DoublyLinkedList.DoublyCellDescription
{
    public interface IDoublyCell<T>
    {
        IDoublyCell<T> Next { get; set; }
        IDoublyCell<T> Previous { get; set; }
        T Value { get; set; }
    }
}
