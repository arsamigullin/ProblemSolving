using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.Sorting.ONLogN
{
    [DisplayInfo("Sorting", "O(NLogN) - Heap Sort in Arrays", typeof(List<int>))]
    class HeapSort
    {
        public List<int> MakeHeap()
        {
            int[] array = new int[] { 456, 987651, 56, 32546513, 668, 5, 946, 8, 65496, 876 };
            
            for (int i = 0; i < array.Length-1; i++)
            {
                int index = i;
                while (index != 0)
                {
                    // find the parent index
                    int parent = (index - 1)/2;

                    // if child  <= parent, we're done, so
                    // break out of the While loop
                    if (array[index] <= array[parent])
                    {
                        break;
                    }
                    // swap parent and child
                    int temp = array[index];
                    array[index] = array[parent];
                    array[parent] = temp;
                    // Move to the parent
                    index = parent;
                }
            }
            RemoveTopItem(array);
            return array.ToList();
        }

        private int RemoveTopItem(int[] array)
        {
            // Save the top item to return later
            int result = array[0];
            // Move the last item to the root
            array[0] = array[array.Length - 1];
            int arrLen = array.Length;
            int index = 0;
            // restore the heap property
            while (true)
            {
                // find the child indicies
                int child1 = 2*index + 1;
                int child2 = 2 * index + 2;
                // If the child index is off the end of the tree.
                // use the parent's index
                if (child1 >= arrLen) child1 = index;
                if (child2 >= arrLen) child2 = index;

                // if the heap property is satisfied,
                // we're done, so break out of the while loop
                if (array[index] >= array[child1] && array[index] >= array[child2])
                {
                    break;
                }
                 
                // get the index of the child with the larger value
                int swap_child;
                if (array[child1] > array[child2])
                {
                    swap_child = child1;
                }
                else
                {
                    swap_child = child2;
                }

                // Swap with the larger child
                int temp = array[index];
                array[index] = array[swap_child];
                array[swap_child] = temp;

                // Move to the child node
                index = swap_child;
            }
            return result;
        }
    }
}
