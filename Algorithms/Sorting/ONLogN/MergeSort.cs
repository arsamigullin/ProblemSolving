using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.Sorting.ONLogN
{
    [DisplayInfo("Sorting", "O(NLogN) - Merge Sort in Arrays", typeof(List<int>))]
    class MergeSort
    {
        public List<int> Sort()
        {
            int[] array = new int[] { 1, 1, 1, 2, 2 };
            DoMergeSort(array, new int[array.Length],0, array.Length-1);
            return array.ToList();
        }

        private void DoMergeSort(int[] values, int[] scratch, int start, int end)
        {
            // if the array contains only one item, it is already sorted
            if (start==end) return;
            // bread the array ino left and right halves
            int midpoint = (start + end)/2;

            // Call Merge sort to sort the two halves
            DoMergeSort(values,scratch, start, midpoint);
            DoMergeSort(values, scratch, midpoint+1, end);

            // Merge the two sorted halves
            int left_index = start;
            int right_index = midpoint + 1;
            int scratch_index = left_index;
            while (left_index<=midpoint && right_index <= end)
            {
                if (values[left_index] <= values[right_index])
                {
                    scratch[scratch_index] = values[left_index];
                    left_index++;
                }
                else
                {
                    scratch[scratch_index] = values[right_index];
                    right_index++;
                }
                scratch_index++;
            }

            // Finisch copying whichever half is not empty
            for (int i = left_index; i < midpoint; i++)
            {
                scratch[scratch_index] = values[i];
                scratch_index++;
            }
            for (int i = right_index; i < end; i++)
            {
                scratch[scratch_index] = values[i];
                scratch_index++;
            }

            // Copy the values back int the original value array
            for (int i = start; i < end; i++)
            {
                values[i] = scratch[i];
            }
        }
    }
}
