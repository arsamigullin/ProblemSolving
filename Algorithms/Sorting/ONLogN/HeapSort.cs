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
        public List<int> Sort()
        {
           // int[] array = new int[] { 456, 987651, 56, 32546513, 668, 5, 946, 8, 65496, 876 };
            int[] array = new int[] { 1,2,3,4,5,6,7,8,9,10 };
            //array = new int[] { 7,1,10,4,6,9,2,11,3,5,12,8 };
            // We need turn the array into the heap
            array = MakeHeap(array, array.Length);
            // there are two ways for heap sorting : 

            // 1-st way 
            for (int i = array.Length - 1; i > 0; i--)
            {
                int ret = RemoveTopItem(array, i+1);
                array[i] = ret;
            }

            // 2-nd way
            // turn array into the heap again
            array = new int[] { 456, 987651, 56, 32546513, 668, 5, 946, 8, 65496, 876 };
            array = MakeHeap(array, array.Length);
            for (int i = array.Length - 1; i > 0; i--)
            {

                //swap the root item and the last item
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                array = MakeHeap(array, i);

            }
            return array.ToList();
        }

        private int[] MakeHeap(int[] array, int length)
        {
           
            
            for (int i = 0; i < length; i++)
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
            
            return array;
        }

        private int RemoveTopItem(int[] array, int lenth)
        {
            // Save the top item to return later
            int result = array[0];
            // Move the last item to the root
            array[0] = array[lenth - 1];
            int arrLen = lenth;
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
