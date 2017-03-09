using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.NumericalAlgorithms.Devisors
{
    [DisplayInfo("Numeric Algorithms", "LCM", typeof(List<long>))]
    class LCM
    {

        public List<long> Go()
        {
            int [] arr = new int [] {165,135};
            int lc = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                lc = this.lcm(lc, arr[i]);
            }
            return  new List<long> {lc};
        }

        int lcm(int a, int b)
        {
            return a*b/gcd(a, b);
        }

        int gcd(int a, int b)
        {
            while (b != 0)
            {
                var reminder = a % b;
                a = b;
                b = reminder;
            }
            return a;
        }
    }
}
