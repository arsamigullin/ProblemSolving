using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Search
{
    [DisplayInfo("Hackerrank - Search", "Beautiful Quadruples", typeof(List<int>))]
    class BeautifulQuadruples
    {
        public List<int> Go()
        {

            ReadingTestCases.ReadAllText();
            int[] arr = Array.ConvertAll(ReadingTestCases.ReadLine().Split(' '), Int32.Parse);
            long total = 0;
            long[] totarr = new long[3010];
            Array.Sort(arr);
            int A = arr[0];
            int B = arr[1];
            int C = arr[2];
            int D = arr[3];
            int[,] cnt = new int[3010,4200];

            int xor = 0;
            //Count number of different pair {a,b} such that, a <= b and within limit
            for (int f = 1; f <= A; f++)
            {
                for (int s = f; s <= B; s++)
                {
                    totarr[s]++;
                }
            }
            //Create cumulative sum, such that, total[B] gives number of pair {a,b}, where b <= B
            for (int i = 1; i <= 3000; i++)
            {
                totarr[i] += totarr[i - 1];
            }
            //Count number of pairs {a,b} whose xor value, a^b is x. Store it in cnt[b][x]
            for (int f = 1; f <= A; f++)
            {
                for (int s = f; s <= B; s++)
                {
                    int x = f ^ s;
                    cnt[s,x]++;
                }
            }
            for (int f = 1; f <= 3000; f++)
            {
                for (int s = 0; s <= 4100; s++)
                {
                    cnt[f,s] += cnt[f - 1,s];
                }
            }
            long res = 0;
            for (int i = 1; i <= C; i++)
            {
                for (int j = i; j <= D; j++)
                {
                    int y = i ^ j;
                    res += totarr[i] - cnt[i,y];
                }
            }

            //Create cumulative array, so that, cnt[B][x] gives all pairs {a,b}, where b <= B and a^b = x.
            Console.WriteLine(res);
            return new List<int>();
        }

        public struct Point
        {
            public long val;
            public bool isSt;
            public Point(long val, bool isSt)
            {
                this.val = val;
                this.isSt = isSt;
            }
        }
    }
}
