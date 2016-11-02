using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.Searching
{
    [DisplayInfo("Searching", "Interpolation search - search in sorted array", typeof(List<int>))]
    public class InterpolationSearch
    {

        readonly int[] values = new int[1000];
        private int target = 8312645;
        public InterpolationSearch()
        {
            Random rnd = new Random();
            values = values.Select(x => rnd.Next()).ToArray();
            int index = rnd.Next(0, 1000);
            values[index] = target;
            values = values.OrderBy(x => x).ToArray();
        }
        public List<int> Go()
        {
            List<int> list = new List<int>();
            int min = 0;
            int max = values.Length - 1;

            while (min<=max)
            {
                double diftar = (target - values[min]);
                double difvalminmax = (values[max] - values[min]);
                double difminmax = (max - min);

                double dmid = (double)min + difminmax * diftar / difvalminmax;
                int mid = (int) dmid;
                if (values[mid] == target)
                {
                    list.Add(mid);
                    return list;
                }

                if (target < values[mid])
                {
                    max = mid - 1;
                }

                if (target > values[mid])
                {
                    min = mid + 1;
                }
            }

            return new List<int>();
        }
    }
}
