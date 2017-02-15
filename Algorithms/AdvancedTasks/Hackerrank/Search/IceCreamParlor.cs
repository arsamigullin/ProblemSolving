using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Search
{
    [DisplayInfo("Hackerrank - Search", "Ice Cream Parlor", typeof(List<int>))]
    class IceCreamParlor
    {
         // O(N2)
        public List<int> Go()
        {
            ReadingTestCases.ReadAllText();
            int t = Int32.Parse(ReadingTestCases.ReadLine());
            while (t > 0)
            {
                t--;
                int m = Int32.Parse(ReadingTestCases.ReadLine());
                int n = Int32.Parse(ReadingTestCases.ReadLine());
                int[] ar = Array.ConvertAll(ReadingTestCases.ReadLine().Split(' '), Int32.Parse);
                bool isInternalLoopBreak = false;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (ar[i] + ar[j] == m)
                        {
                            Console.WriteLine((i + 1) + " " + (j + 1));
                            isInternalLoopBreak = true;
                            break;
                        }
                    }
                    if (isInternalLoopBreak) break;
                }
            }
            return  new List<int>();
        }
        // O(N)
        public List<int> GoON()
        {
            ReadingTestCases.ReadAllText();
            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < d.Count; i++)
            {

            }
            int t = Int32.Parse(ReadingTestCases.ReadLine());
            while (t > 0)
            {
                t--;
                int m = Int32.Parse(ReadingTestCases.ReadLine());
                int n = Int32.Parse(ReadingTestCases.ReadLine());
                int[] ar = Array.ConvertAll(ReadingTestCases.ReadLine().Split(' '), Int32.Parse);
                IceCream [] icearr = new IceCream[n];
                for (int i = 0; i < n; i++)
                {
                    icearr[i] = new IceCream(ar[i],i);
                }

                Array.Sort(icearr);
                for (int i = 0; i < n-1; i++)
                {
                    int search = m - icearr[i].Cost;
                    if (search >= icearr[i].Cost)
                    {
                        int res = binarySearch(icearr, i+1, n - 1, search);
                        if (res != -1)
                        {
                            Console.WriteLine(Math.Min(icearr[i].Index+1, res+1)+ " "+ Math.Max(icearr[i].Index+1, res+1));
                            break;
                        }
                    }
                }
                
            }
            return new List<int>();
        }

        private int binarySearch(IceCream [] icearr, int min, int max, int target)
        {
            int mid = 0;
            if (icearr[min].Cost == target)
            {
                return icearr[min].Index;
            }
            if (icearr[max].Cost == target)
            {
                return icearr[max].Index;
            }
            while (min <= max)
            {
                mid = (max + min) / 2;
                // See if we need to search the left or right half.
                if (target > icearr[mid].Cost)
                {
                    min = mid + 1;
                }
                else if (target < icearr[mid].Cost)
                {
                    max = mid - 1;
                }
                else
                {
                    
                    return icearr[mid].Index;
                }
            }
            return -1;
        }
    }

    struct  IceCream : IComparable<IceCream>
    {
        public int Cost;
        public int Index;
        public IceCream(int cost, int index)
        {
            Cost = cost;
            Index = index;
        }

        public int CompareTo(IceCream other)
        {
            return this.Cost - other.Cost;
        }
    }
}
