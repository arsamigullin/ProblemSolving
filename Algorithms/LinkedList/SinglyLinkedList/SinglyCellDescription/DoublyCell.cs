using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.LinkedList.DoublyLinkedList.DoublyCellDescription;

namespace Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription
{
    class SinglyCell<T>: ISinglyCell<T>
    {
            public ISinglyCell<T> Next { get; set; }
            public T Value { get; set; }
        
    }
}
