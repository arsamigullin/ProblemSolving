using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.Searching
{
    [DisplayInfo("Searching", "Binary search - search in sorted array", typeof(List<long>))]
    public class BinarySearch
    {
         int[] initarr = new int[1000];
        private int target = 8312;
        public BinarySearch()
        {
            ReadingTestCases.ReadAllText();
            initarr = ReadingTestCases.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            Array.Sort(initarr);
            /* Random rnd = new Random();
             initarr = initarr.Select(x => rnd.Next()).ToArray();
             int index = rnd.Next(0, 1000);
             initarr[index] = target;
             initarr= initarr.OrderBy(x => x).ToArray();*/
        }

        // Find the target item's index in the sorted array.
        // If the item isn't in the array, return -1.
        // Log2(N)
        public List<long> Go()
        {

            List<long> list = new List<long>();

            int min = 0;
            int max = initarr.Length-1;
            int mid = 0;
            if (initarr[min] == target || initarr[max] == target)
            {
                list.Add(min);
                return list;
            }
            while (min<=max)
            {
                 mid = (max+min) / 2;
                // See if we need to search the left or right half.
                if (target > initarr[mid])
                {
                    min=mid+1;
                }
                else if (target < initarr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    list.Add(mid);
                    return list;
                }
            }
            return new List<long>();
            
        }
    }
}
