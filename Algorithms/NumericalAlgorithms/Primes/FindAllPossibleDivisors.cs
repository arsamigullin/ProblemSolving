using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.NumericalAlgorithms.Primes
{
    [DisplayInfo("Primes", "Finding All Possibel Divisors", typeof(List<long>))]
    class FindAllPossibleDivisors
    {
        public List<long> Go()
        {
            int num = Int32.Parse(Console.ReadLine());
            int i = 2;
            List<long> listdivisors = new List<long>();
            while ((i<=Math.Sqrt(num)))
            {
                if (num%i == 0)
                {
                   // if (i != num/i)
                   // {
                        listdivisors.Add(num/i);
                       listdivisors.Add(i);
                    // }
                }
                i++;
            }
            return listdivisors;
        }
    }
}
