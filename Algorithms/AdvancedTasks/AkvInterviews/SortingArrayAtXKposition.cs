using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks
{
    [DisplayInfo("Anvanced Tasks", "Sorting Array at X*K position ", typeof(List<int>))]
    class SortingArrayAtXKposition
    {
        //Given an array and K with condition: an item is staying at x* K(for some x) positions away from sorted order.Please sort
        public List<int> Sort()
        {
            // We need to consider two situations:
            // k greater than 0
            // k less 0
            int k = 3;
            int[] array = new[] { 6, 7, 8, 1, 2, 3, 4, 5 };
            //  k = -3;
            //  array = new[] { 4,5,6,7,8,1,2,3 };
            int[] sotedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                // Calculate new position
                int newPosition = i - k;
                // for k > 0  it may be possible new position will be < 0
                if (newPosition < 0)
                {
                    newPosition = array.Length + newPosition;
                }
                // for k < 0 it may be possible new position > array.Length-1
                if (newPosition > array.Length - 1)
                {
                    newPosition = newPosition - array.Length;
                }
                sotedArray[newPosition] = array[i];
            }
            return sotedArray.ToList();
        }
    }
}
