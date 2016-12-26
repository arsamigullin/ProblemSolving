using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.Sorting.ON2
{
    [DisplayInfo("Sorting", "O(N^2) - Bubble Sort in Arrays", typeof(List<int>))]
    class BubbleSort
    {
        public List<int> Sort()
        {
            int[] array = new int[] { 456, 987651, 56, 32546513, 668, 5, 946, 8, 65496, 876 };
            bool sorted = true;
            while (sorted)
            {
                sorted = false;
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (array[i + 1] < array[i])
                    {
                        int temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                        sorted = true;
                    }
                }
            }
            return array.ToList();
        }
    }
}
