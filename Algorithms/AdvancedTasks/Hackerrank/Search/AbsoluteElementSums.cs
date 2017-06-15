using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Search
{
    [DisplayInfo("Hackerrank - Search", "Absolute Element Sums", typeof(List<int>))]
    class AbsoluteElementSums
    {
        public List<int> Go()
        {
            ReadingTestCases.ReadAllText();
            int N = Int32.Parse(ReadingTestCases.ReadLine());
            long[] array = Array.ConvertAll(ReadingTestCases.ReadLine().Split(' '), long.Parse);
            int Q = Int32.Parse(ReadingTestCases.ReadLine());
            long[] queries = Array.ConvertAll(ReadingTestCases.ReadLine().Split(' '), long.Parse);
            IEnumerable<long> ar = array;
            for (int i = 0; i < Q; i++)
            {
                var i1 = i;
                ar = ar.Select(x => x + queries[i1]).AsParallel();
                //long res = ar.Su;
                Console.WriteLine(ar);
            }
            return new List<int>();
        }
    }
}
