using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.Searching
{
    [DisplayInfo("Searching", "Interpolation search - search in sorted array", typeof(List<int>))]
    public class InterpolationSearch
    {

        readonly int[] arr = new int[1000];
        private int key = 8013;
        public InterpolationSearch()
        {
            string s = "194729";
            bool t = s.Contains("4729");
            ReadingTestCases.ReadAllText();
            arr = ReadingTestCases.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            Array.Sort(arr);
         
           /* Random rnd = new Random();
            values = values.Select(x => rnd.Next()).ToArray();
            int index = rnd.Next(0, 1000);
            values[index] = target;
            values = values.OrderBy(x => x).ToArray();*/
        }
        // Log2(Log2N)
        public int Search()
        {
            int min = 0;
            int max = arr.Length - 1;
            int mid;
            while (arr[max] != arr[min] && key >= arr[min] && key <= arr[max])
            {

                mid = min + ((key - arr[min]) * (max - min) / (arr[max] - arr[min]));
                if (arr[mid] < key)

                    min = mid + 1;

                else if (key < arr[mid])

                    max = mid - 1;
                else

                    return mid;
            }

            if (key == arr[min])

                return min;
            else
                return -1;

        }
    }
}
