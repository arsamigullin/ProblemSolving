using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.Sorting.ON2
{
    // That sort pretty simple and don't need additional memory
    // This algorithm is good for small arrays (arrays holding 5-10 items)
    [DisplayInfo("Sorting", "O(N^2) - Selection Sort in Arrays", typeof(List<int>))]
    class SelectionSort
    {
        public List<int> Sort()
        {
            double d=4.0;
            string s = "7";
            double b = d + Double.Parse(s);
            Console.WriteLine(b.ToString("N1"));
            int[] array = new int[] { 456, 987651, 56, 32546513, 668, 5, 946, 8, 65496, 876 };
            var minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                minIndex = i;
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[k] < array[minIndex])
                    {
                        minIndex = k;
                    }
                }

                if (minIndex != i)
                {
                    int item = array[minIndex];
                    array[minIndex] = array[i];
                    array[i] = item;
                }
            }
            return array.ToList();
        }
    }
}
