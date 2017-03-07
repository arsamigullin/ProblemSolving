using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Search
{
    [DisplayInfo("Hackerrank - Search", "Gena playing Hanoi", typeof(List<long>))]
    class GenaPlayingHanoi
    {
        public List<long> Go()
        {
            ReadingTestCases.ReadAllText();
            int n = Int32.Parse(ReadingTestCases.ReadLine());
            int N = 10;
            int[] a = new int[2<<(2*N+1)];
            int[] b = new int[4];
            int K = 0;
            int t = 0;
            int[] values = Array.ConvertAll(ReadingTestCases.ReadLine().Split(' '), Int32.Parse);
            for (int i = 0; i < values.Length; i++)
            {
                K |= ((values[i] - 1) << (t*2));
                t++;
            }
            a[0] = 1;
            List<int> Q= new List<int>{0};
            int ind = 0;
            while (true)
            {
                int x = Q[ind];
                ind++;
                if (x == K)
                {
                    Console.WriteLine(a[x]-1);
                    return new List<long>();
                }
                for (int i = 0; i < b.Length; i++)
                {
                    b[i] = 1000;
                }
                for (int i = n-1; i >= 0; i--)
                {
                    b[(3&(x>>(i*2)))] = i;
                }
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (b[i] < b[j])
                        {
                            int y = x + ((j - i) << (b[i]*2));
                            if (a[y] == 0)
                            {
                                a[y] = a[x] + 1;
                                Q.Add(y);
                            }
                        }
                    }
                }
            }
            return new List<long>();
        }
    }
}
