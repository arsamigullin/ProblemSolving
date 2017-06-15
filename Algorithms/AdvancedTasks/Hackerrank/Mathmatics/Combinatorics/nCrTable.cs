using System.Collections.Generic;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Mathmatics.Combinatorics
{
    [DisplayInfo("Hackerrank - Math - Combinatorics", "nCrTable", typeof(List<int>))]
    class nCrTable
    {
        public List<int> Go()
        {
            int[,] arr = new int[1000001,1000001];

            for (int i = 0; i < 1000001; i++)
            {
                arr[i, i] = 1;
                arr[i, 0] = 1;
            }

            for (int i = 2; i < 1000001; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    arr[i, j] = (arr[i - 1, j - 1] + arr[i - 1, j]) % 1000000000;
                }
            }
            int p = 0;
            string s = "";
            while (arr[10,p]!=0)
            {
                s += arr[10, p] + " ";
                p++;
            }
            return new List<int>();
        }
    }
}
