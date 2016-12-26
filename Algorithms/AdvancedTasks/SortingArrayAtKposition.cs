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

        //Given an array with condition: an item is staying at most at k positions away from sorted order.Please sort
        public List<int> SortWithInsertiont()
        {
            // We need to consider two situations:
            // k greater than 0
            // k less 0
            int z = 3;
            int[] A = new[] {2,1,4,3,7,5,8,6};

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
    }
}
