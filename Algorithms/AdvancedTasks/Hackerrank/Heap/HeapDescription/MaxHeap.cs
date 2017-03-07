using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AdvancedTasks.Hackerrank.Heap.HeapDescription
{
    class MaxHeap : Heap
    {
        public MaxHeap(int capacity) : base(capacity)
        {
            
        }

        public override void heapifyDown()
        {
            int index = 0;
            while (hasLeftChild(index))
            {
                int smallerChildIndex = getLeftChildIndex(index);

                if (hasRightChild(index)
                    && rightChild(index) > leftChild(index)
                )
                {
                    smallerChildIndex = getRightChildIndex(index);
                }

                if (items[index] > items[smallerChildIndex])
                {
                    break;
                }
                else
                {
                    swap(index, smallerChildIndex);
                }
                index = smallerChildIndex;
            }
        }

        public override void heapifyUp()
        {
            int index = size - 1;

            while (hasParent(index)
                 && parent(index) < items[index]
                )
            {
                swap(getParentIndex(index), index);
                index = getParentIndex(index);
            }
        }
    }
}
