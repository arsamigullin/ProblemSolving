using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Search
{
    [DisplayInfo("Hackerrank - Search", "GrinLnad Mtro", typeof(List<int>))]
    class GridlandMetro
    {
        public static List<int> Go()
        {
            ReadingTestCases.ReadAllText();
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            long[] ar = Array.ConvertAll(ReadingTestCases.ReadLine().Split(' '), long.Parse);
            long n = ar[0];
            long m = ar[1];
            long k = ar[2];
            long totalTrainArea = 0;
            Dictionary<long, ColRange> dict = new Dictionary<long, ColRange>();
            while (k > 0)
            {
                k--;
                ar = Array.ConvertAll(ReadingTestCases.ReadLine().Split(' '), long.Parse);
                long r = ar[0];
                long start = ar[1];
                long end = ar[2];
                if (dict.ContainsKey(r))
                {
                    dict[r].updateRange(start, end);
                }
                else
                {
                    dict.Add(r, new ColRange(start, end));
                }
            }
            foreach (var kvp in dict)
            {
                totalTrainArea += kvp.Value.getTotalArea();
            }
            long totalAreaCity = m * n;
            //Console.WriteLine(totalTrainArea);
            Console.WriteLine(totalAreaCity - totalTrainArea);
            return  new List<int>();
        }

        class ColRange
        {
            List<ColSet> list;
            public ColRange(long start, long end)
            {
                list = new List<ColSet>();
                updateRange(start, end);
            }

            public void updateRange(long start, long end)
            {

                if (list.Count == 0)
                {
                    list.Add(new ColSet(start, end));
                    return;
                }
                ColSet cs = new ColSet(start, end);
                List<ColSet> updatedList = new List<ColSet>();
                bool isIsolatedFound = false;
                for (int i = 0; i < list.Count; i++)
                {

                    ColSet csint = list[i];
                    // 
                    // exist           -------                    --------
                    // input                    -----       ----
                    if (cs.Start > csint.End || cs.End < csint.Start)
                    {
                        updatedList.Add(csint);
                        //isIsolatedFound=true; 
                        continue;
                    }
                    // 
                    // exist           ------------------
                    // input                --------     
                    if (cs.Start >= csint.Start && cs.End <= csint.End)
                    {
                        cs = new ColSet(csint.Start, csint.End);
                        continue;
                    }
                    // 
                    // exist           ------------------
                    // input         ---------------------     
                    if (cs.Start < csint.Start && cs.End > csint.End)
                    {
                        cs = new ColSet(cs.Start, cs.End);
                        continue;
                    }
                    // 
                    // exist           ---------------
                    // input                       -----------    
                    if (cs.Start <= csint.End && cs.End > csint.End)
                    {
                        cs = new ColSet(csint.Start, cs.End);
                        continue;
                    }
                    // 
                    // exist           ---------------
                    // input    -----------   
                    if (cs.Start < csint.Start && cs.End >= csint.Start)
                    {
                        cs = new ColSet(cs.Start, csint.End);
                        continue;
                    }
                }
                updatedList.Add(cs);
                list = new List<ColSet>();
                list.AddRange(updatedList);
                Console.WriteLine(list.Count);
            }

            public long getTotalArea()
            {
                long total = 0;
                for (int i = 0; i < list.Count; i++)
                {

                    total += list[i].End - list[i].Start + 1;
                    Console.WriteLine(list.Count);

                }
                return total;
            }


        }
        struct ColSet
        {
            public long Start;
            public long End;
            public ColSet(long start, long end)
            {
                Start = start;
                End = end;
            }
        }
    }
}
