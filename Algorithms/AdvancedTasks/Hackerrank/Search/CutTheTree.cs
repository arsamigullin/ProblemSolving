using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.AdvancedTasks.Hackerrank.Tree;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Search
{
    [DisplayInfo("Hackerrank - Search", "Cut The Tree", typeof(List<int>))]
    class CutTheTree
    {
        public List<int> Go()
        {
            ReadingTestCases.ReadAllText();
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = Int32.Parse(ReadingTestCases.ReadLine());
            long[] arr = Array.ConvertAll(ReadingTestCases.ReadLine().Split(' '), long.Parse);
            long total = arr.Sum();
            List<string> nodesStr = new List<string>();
            Dictionary<long, List<long>> dataind = new Dictionary<long, List<long>>();
            int count = n;
            while (n>1)
            {
                n--;
                nodesStr.Add(ReadingTestCases.ReadLine());
            }
            long min = -1;
            long prev = 0;
            List<long> list = new List<long>();
            for (int i = 0; i < count-1; i++)
            {
                long[] nodarr = Array.ConvertAll(nodesStr[i].Split(' '), long.Parse);
                list.Add(nodarr[0]);
                list.Add(nodarr[1]);

                if (dataind.ContainsKey(nodarr[0]))
                {
                    dataind[nodarr[0]].Add(prev++);
                }
                else
                {
                    dataind.Add(nodarr[0], new List<long> {prev++});
                    
                }

                if (dataind.ContainsKey(nodarr[1]))
                {
                    dataind[nodarr[1]].Add(prev++);
                }
                else
                {
                    dataind.Add(nodarr[1], new List<long> { prev++ });
                }
            }

            load(dataind, list,arr, 1, -1, ref min,total);
            Console.WriteLine(min);
            return new List<int>();
        }
        
        long load(Dictionary<long, List<long>> dictind, List<long> list, long[] arr, long root, long depindex, ref long min, long total)
        {
            if (root == 1)
            {
                min = total - 2*arr[0];
            }
            long sum = 0;
            if (dictind[root].Count == 1 && dictind[root][0]==depindex)
            {
                sum = arr[root- 1];
            }
            else
            {
                for (int i = 0; i < dictind[root].Count; i++)
                {
                    long index = dictind[root][i];
                    if (index == depindex) continue;
                    long deprIndex;
                    if (index % 2 == 0)
                    {
                        deprIndex = index + 1;
                    }
                    else
                    {
                        deprIndex = index - 1;
                    }
                    sum += load(dictind, list, arr, list[(int)deprIndex], deprIndex, ref min, total);
                }
                sum += arr[root - 1];
            }
           
          
            long dif = Math.Abs(total - 2 * sum);
            if (min > dif || min == -1)
            {
                min = dif;
            }
            return sum;
        }
        
      
    }
}
