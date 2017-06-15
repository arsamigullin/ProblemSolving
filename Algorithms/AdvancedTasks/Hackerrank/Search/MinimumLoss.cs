using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Search
{
    [DisplayInfo("Hackerrank - Search", "Minimum Loss", typeof(List<long>))]
    public class MinimumLoss
    {
        public List<long> Go()
        {
            ReadingTestCases.ReadAllText();
            int n = Int32.Parse(ReadingTestCases.ReadLine());
            long[] arr = Array.ConvertAll(ReadingTestCases.ReadLine().Split(' '), Int64.Parse);
            Point[] arrp = new Point[n];
            for (int i = 0; i < n; i++)
            {
                arrp[i] = new Point(arr[i], i);
            }
            long min = long.MaxValue;
            Array.Sort(arrp);
            for (int i = n-1; i >=1; i--)
            {
                for (int j = i-1; j >=0; j--)
                {
                    if (arrp[i].index > arrp[j].index)  continue;
                    long dif =  arrp[i].val - arrp[j].val;
                    if (dif<0) continue;
                    min = Math.Min(min, dif);
                    break;
                }
            }
            Console.Write(min);
            return new List<long>();
        }
        public struct Point :  IComparable<Point>
        {
            public long val;
            public int index;
            public Point(long val, int index)
            {
                this.val = val;
                this.index = index;
            }

            public int CompareTo(Point other)
            {
                var valComparison = val.CompareTo(other.val);
                if (valComparison != 0) return valComparison;
                return index.CompareTo(other.index);
            }
        }
    }
}
