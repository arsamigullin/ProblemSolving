using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.LinkedList.DoublyLinkedList.DoublyCellDescription;

namespace Algorithms.LinkedList.DoublyLinkedList.DoublyCellDescription
{
    class DoublyCell<T>: IDoublyCell<T>
    {
        public IDoublyCell<T> Next { get; set; }
        public IDoublyCell<T> Previous { get; set; }
        public T Value { get; set; }

    }
}
