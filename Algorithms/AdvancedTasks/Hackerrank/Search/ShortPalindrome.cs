using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Search
{
    [DisplayInfo("Hackerrank - Search", "Short Palindrome", typeof(List<long>))]
    class ShortPalindrome
    {
        public List<long> Go()
        {
            int n = 3;
            int k = 4;
            double res = 1;
            for (int i = 1; i <= k; ++i)
                res = res * (n - k + i) / i;
            var r =(long)(res + 0.01);
            return new List<long> {r};
        }
    }
}
