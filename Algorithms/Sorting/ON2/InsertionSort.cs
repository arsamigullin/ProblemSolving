using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.Sorting.ON2
{
    [DisplayInfo("Sorting", "O(N^2) - Insertion Sort in Arrays", typeof(List<int>))]
    class InsertionSort
    {
        // That sort pretty simple and don't need additional memory
        // This algorithm is good for small arrays (arrays holding 5-10 items)
        public List<int> Sort()
        {
            int[] array = new int[] { 456, 987651, 56, 32546513, 668, 5, 946, 8, 65496, 876 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i+1; k < array.Length; k++)
                {
                    if (array[k] < array[i])
                    {
                        int item = array[k];
                        array[k] = array[i];
                        array[i] = item;
                    }
                }
            }
            return array.ToList();
        }

        public List<int> InsertionSortFromInternet()
        {
            int[] intArray = new int[] { 456, 987651, 56, 32546513, 668, 5, 946, 8, 65496, 876 };
         

            int temp, j;
            for (int i = 1; i < intArray.Length; i++)
            {
                temp = intArray[i];
                j = i - 1;

                while (j >= 0 && intArray[j] > temp)
                {
                    intArray[j + 1] = intArray[j];
                    j--;
                }

                intArray[j + 1] = temp;
            }
            return intArray.ToList();
        }
    }
}
