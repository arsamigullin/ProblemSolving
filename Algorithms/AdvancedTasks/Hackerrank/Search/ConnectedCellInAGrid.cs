using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Search
{
    [DisplayInfo("Hackerrank - Search", "Connected Cell In A Grid", typeof(List<int>))]
    class ConnectedCellInAGrid
    {
       public List<int> Go()
       {
           double d = 2.5%(1000000000+7);
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            ReadingTestCases.ReadAllText();
            int n = Int32.Parse(ReadingTestCases.ReadLine());
            int m = Int32.Parse(ReadingTestCases.ReadLine());
            int[][] a = new int[n][];
            int row = 0;
            while (row < n)
            {
                a[row] = Array.ConvertAll(ReadingTestCases.ReadLine().Split(' '), Int32.Parse);
                row++;
            }
            int[,] map = new int[n, m];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int key = 0;
            check(a, map, 0, 0, n, m, dict, ref key);
            Console.WriteLine(dict.Values.Max());
            return new List<int>();
        }
        void check(int[][] a, int[,] map, int si, int sj, int n, int m , Dictionary<int, int> dict, ref int key )
        {
            int bigMax = 0;
            int max = 0;
            for (int i = si; i < n; i++)
            {
                for (int j = sj; j < m; j++)
                {
                    if (a[i][j] == 0) continue;
                    int inci = i + 1;
                    int deci = i - 1;
                    int incj = j + 1;
                    int decj = j - 1;
                    int count = 0;
                    int internalKey = getKeyFromMap(a, map, i, j, m, n, ref key);
                    if (map[i, j] == 0)
                    {
                        map[i, j] = internalKey;
                        count++;
                    }

                    if (inci < n && incj < m && a[inci][incj] != 0)
                    {
                        if (map[inci, incj]==0)
                        {
                            map[inci, incj]= internalKey;
                            count++;
                            check(a, map, inci, incj, n, m, dict, ref key);
                        }
                    }
                    if (deci >= 0 && a[deci][j] != 0)
                    {
                        if (map[deci, j]==0)
                        {
                            map[deci, j] = internalKey;
                            count++;
                            check(a, map, deci, j, n, m, dict, ref key);
                        }
                   
                    }
                    if (deci >= 0 && incj < m && a[deci][incj] != 0)
                    {

                        if (map[deci, incj]==0)
                        {
                            map[deci, incj] = internalKey;
                            count++;
                            check(a, map, deci, incj, n, m, dict, ref key);
                        }
                    }
                    if (decj >= 0 && a[i][decj] != 0)
                    {

                        if (map[i, decj] == 0)
                        {
                            map[i, decj] = internalKey;
                            count++;
                            check(a, map, i, decj, n, m, dict, ref key);
                        }
                    }
                    if (incj < m && a[i][incj] != 0)
                    {
                        if (map[i, incj] == 0)
                        {
                            map[i, incj] = internalKey;
                            count++;
                            check(a, map, i, incj, n, m, dict, ref key);
                        }
                    }
                    if (decj >= 0 && inci < n && a[inci][decj] != 0)
                    {
                        if (map[inci, decj] == 0)
                        {
                            map[inci, decj] = internalKey;
                            count++;
                            check(a, map, inci, decj, n, m, dict, ref key);
                        }
                    }
                    if (inci < n && a[inci][j] != 0)
                    {
                        if (map[inci, j] == 0)
                        {
                            map[inci, j] = internalKey;
                            count++;
                            check(a, map, inci, j, n, m, dict, ref key);
                        }
                    }
                    if (decj >= 0 && deci >= 0 && a[deci][decj] != 0)
                    {
                        if (map[deci, decj] == 0)
                        {
                            map[deci, decj] = internalKey;
                            count++;
                            check(a, map, deci, decj, n, m, dict, ref key);
                        }
                    }

                    if (dict.ContainsKey(internalKey))
                    {
                        dict[internalKey] += count;
                    }
                    else
                    {
                        dict.Add(internalKey,count);
                    }
                }
            }
        }

        int getKeyFromMap(int[][] a, int[,] map, int i, int j, int m, int n, ref int key)
        {
            int inci = i + 1;
            int deci = i - 1;
            int incj = j + 1;
            int decj = j - 1;
            if (map[i, j] > 0)
            {
                return map[i, j];
            }
            if (inci < n && incj < m && a[inci][incj] != 0)
            {
                if (map[inci, incj] > 0) return map[inci, incj];
            }
            if (deci >= 0 && a[deci][j] != 0)
            {
                if (map[deci, j] > 0) return map[deci, j];
            }
            if (deci >= 0 && incj < m && a[deci][incj] != 0)
            {
                if (map[deci, incj] > 0) return map[deci, incj];

            }
            if (decj >= 0 && a[i][decj] != 0)
            {
                if (map[i, decj] > 0) return map[i, decj];
            }
            if (incj < m && a[i][incj] != 0)
            {
                if (map[i, incj] > 0) return map[i, incj];
            }
            if (decj >= 0 && inci < n && a[inci][decj] != 0)
            {
                if (map[inci, decj] > 0) return map[inci, decj];
            }
            if (inci < n && a[inci][j] != 0)
            {
                if (map[inci, j] > 0) return map[inci, j];
            }
            if (decj >= 0 && deci >= 0 && a[deci][decj] != 0)
            {
                if (map[deci, decj] > 0) return map[deci, decj];
            }

            return ++key;
        }
    }
}
