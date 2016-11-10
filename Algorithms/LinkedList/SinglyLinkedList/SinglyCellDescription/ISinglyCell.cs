using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.LinkedList.DoublyLinkedList;

namespace Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription
{
    interface ISinglyCell<T>
    {
        ISinglyCell<T> Next { get; set; }
        T Value { get; set; }
    }
}
