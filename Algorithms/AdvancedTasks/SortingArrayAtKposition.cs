using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks
{
    [DisplayInfo("Anvanced Tasks", "Sorting Array at K position ", typeof(List<int>))]
    class SortingArrayAtKposition
    {

        private int[] harr;
        private int heap_size;

        #region Solving Task by heap sorting

        // Algorithm vetry simple to understand
        public List<int> SortWithHeap()
        {
            // we need determine 
            int k = 2; // step away from sorted oreder
            int[] arr = new[] { 2, 1, 4, 3, 7, 5, 8, 6 };
            int n = arr.Length; // len array
            harr = new int[k + 1]; // min heap array 

            // Store first k items to the heap array
            for (int i = 0; i <= k && i < n; i++) // i < n condition is needed when k > n
            {
                harr[i] = arr[i];
            }
            // Make min heap. This means that minimun value will be in the root of the heap
            heap_size = harr.Length;
            int j = (heap_size - 1) / 2;
            while (j >= 0)
            {
                MinHeapify(j);
                j--;
            }

            // As we have almost sorted array we alway can find next needed item in the min heap, because items in array stay at most k position from sorted order. 
            //And heap array has length k+1

            for (int i = k + 1, ti = 0; ti < n; i++, ti++)
            {
                // If there are remaining elements, then place
                // root of min heap at target index and add arr[i]
                // to Min Heap
                if (i < n)
                    arr[ti] = ReplaceMin(arr[i]);

                // Otherwise place root at its target index and
                // reduce heap size
                else
                    arr[ti] = ExtractMin();
            }
            return arr.ToList();
        }

        // Method to remove minimum element (or root) from min heap
        int ExtractMin()
        {
            // take root
            int root = harr[0];
            if (heap_size > 1)
            {
                // move last item from min heap to root
                harr[0] = harr[heap_size - 1];
                // reduce heap_size
                heap_size--;
                // rebuild min heap
                MinHeapify(0);
            }
            return root;
        }

        // Method to change root with given value x, and return the old root
        int ReplaceMin(int new_value)
        {
            int curentRoot = harr[0];
            harr[0] = new_value;
            if (curentRoot < new_value) // 
                // rebuild min heap
                MinHeapify(0);
            return curentRoot;
        }

        /// <summary>
        /// Create min heap
        /// </summary>
        /// <param name="index"></param>
        void MinHeapify(int index)
        {
            int l = 2 * index + 1;
            int r = 2 * index + 2;
            int smallest = index;
            if (l < heap_size && harr[l] < harr[index])
            {
                smallest = l;
            }
            if (r < heap_size && harr[r] < harr[smallest])
            {
                smallest = r;
            }
            if (smallest != index)
            {
                // swap
                int temp = harr[smallest];
                harr[smallest] = harr[index];
                harr[index] = temp;
                MinHeapify(smallest);
            }
        }
        #endregion

        #region Solving task by insertion sort
        //Given an array with condition: an item is staying at most at k positions away from sorted order.Please sort
        public List<int> SortWithInsertiont()
        {
            // We need to consider two situations:
            // k greater than 0
            // k less 0
            int z = 3;
            int[] A = new[] { 2, 1, 4, 3, 7, 5, 8, 6 };

            int i, key, j;
            for (i = 1; i < A.Length; i++)
            {
                key = A[i];
                j = i - 1;

                /* Move elements of A[0..i-1], that are greater than key, to one 
                   position ahead of their current position.
                   This loop will run at most k times */
                while (j >= 0 && A[j] > key)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = key;
            }

            return A.ToList();
        }
        #endregion
    }
}
