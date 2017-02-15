using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.Sorting.ONLogN
{
    [DisplayInfo("Sorting", "O(NLogN) - Quick Sort in Arrays", typeof(List<int>))]
    class QuickSort
    {
        public List<int> Sort()
        {
            int[] values = new[] {5,8,1,3,7,9,2};
            DoQuickSort(values,0, values.Length-1);
            return values.ToList();
        }

        private void DoQuickSort(int[] values, int start, int end)
        {
            // if the arrays has no more than one element, it is sorted
            if (start>= end) return;
            // use the first item as the dividing item.
            int divider = values[start];
            // Move items < divider to the front of the array and
            // items >= divider to the end of the array
            int lo = start;
            int hi = end;

            while (true)
            {
                // search the array from back to front starting at "hi"
                // to find the last item where value < "divider"
                // Move that item into the hole. The hole is now where
                // that item was
                while (values[hi] >= divider)
                {
                    hi = hi - 1;
                    if (hi <= lo)
                    {
                        break;
                    }
                }
                if (hi <= lo)
                {
                    // the left and right pieces have met in the middle
                    // so we're done. Put the divider here, and
                    // break out of the outer While loop
                    values[lo] = divider;
                    break;
                }
                // Move the value we found to the lower half
                values[lo] = values[hi];

                //Search the array from front to back starting at "lo"
                // to find the first item where value >= divider
                // Move that item into the hole. The hole is now where that item was
                lo++;
                while (values[lo]<divider)
                {
                    lo++;
                    if (lo >= hi)
                    {
                        break;
                    }
                }
                if (lo >= hi)
                {
                    // the left and right pieces have met in the middle
                    // so we are done. Put the divider here, and
                    // break out of the outer While loop
                    lo = hi;
                    values[hi] = divider;
                    break;
                }
                // Move the value we found to the upper half
                values[hi] = values[lo];
            }

            // Recursively sort the two halves
            DoQuickSort(values,start, lo-1);
            DoQuickSort(values, lo+1, end);
        }
    }
}
