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
            List<int> list = new List<int>();
            int max = 0;
            check(0, 0, a, map, n, m, list, ref max);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine(max);
            return new List<int>();
        }
        void check(int se, int si, int[][] a, int[,] map, int n, int m, List<int> list, ref int max)
        {
            for (int i = se; i < n; i++)
            {
                for (int j = si; j < m; j++)
                {
                    if (a[i][j] == 0) continue;
                    if (i == se && j == si && map[i, j]==0)
                    {
                 
                    }
                    //map[i,j]++; 
                    int inci = i + 1;
                    int deci = i - 1;
                    int incj = j + 1;
                    int decj = j - 1;
                    bool isFound = false;
                    map[i, j]++;
                
                    if (inci < n && incj < m && a[inci][incj] != 0)
                    {
                        isFound = true;
                        // Did we marked that element
                        if (map[inci, incj] == 0)
                        {
                           
                            map[inci, incj] = ++max;
                            check(inci, incj, a, map, n, m, list, ref max);
                           
                        }
                    }
                    if (deci >= 0 && a[deci][j] != 0)
                    {
                        isFound = true;
                        if (map[deci, j] == 0)
                        {
                           
                            map[deci, j] = ++max;
                            check(deci, j, a, map, n, m, list, ref max);
                        

                        }
                    }
                    if (deci >= 0 && incj < m && a[deci][incj] != 0)
                    {
                        isFound = true;
                        if (map[deci, incj] == 0)
                        {
                            
                            map[deci, incj] = ++max;
                            check(deci, incj, a, map, n, m, list, ref max);
                          

                        }
                    }
                    if (decj >= 0 && a[i][decj] != 0)
                    {
                        isFound = true;
                        if (map[i, decj] == 0)
                        {
                           
                            map[i, decj] = ++max;
                            check(i, decj, a, map, n, m, list, ref max);
                         

                        }
                    }
                    if (incj < m && a[i][incj] != 0)
                    {
                        isFound = true;
                        if (map[i, incj] == 0)
                        {
                            map[i, incj] = ++max;
                            check(i, incj, a, map, n, m, list, ref max);
                           
                        }
                    }
                    if (decj >= 0 && inci < n && a[inci][decj] != 0)
                    {
                        isFound = true;
                        if (map[inci, decj] == 0)
                        {
                            map[inci, decj] = ++max;
                            check(inci, decj, a, map, n, m, list, ref max);
                        
                        }

                    }
                    if (inci < n && a[inci][j] != 0)
                    {
                        isFound = true;
                        if (map[inci, j] == 0)
                        {
                            
                            map[inci, j] = ++max;
                            check(inci, j, a, map, n, m, list, ref max);
                       
                        }

                    }
                    if (decj >= 0 && deci >= 0 && a[deci][decj] != 0)
                    {
                        isFound = true;
                        if (map[deci, decj] == 0)
                        {

                            map[deci, decj] = ++max;
                            check(deci, decj, a, map, n, m, list, ref max);
                            
                        }

                    }
                    if (!isFound)
                    {
                        max++;
                        if (max != 0) list.Add(max);
                      //  Console.WriteLine(i + " " + j + " " + max);
                        max = 0;
                        map[i, j]++;
                        /* if (max<map[i,j])
                         {
                            max=map[i,j];
                          }*/

                        //max = 0;
                    }
                    else
                    {
                        max++;
                    }
                    


                }
            }
        }
    }
}
