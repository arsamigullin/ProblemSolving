using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Primes
{
    class FindingPrimes
    {
        public static void Go(int number)
        {
            List<int> factors= new List<int>();
            int i = 2;
            while (i<number)
            {
                while (number%i==0)
                {
                    factors.Add(i);
                    number = number/i;
                }

                i++;
            }

            if (number>0) factors.Add(number);

            foreach (var f in factors)
            {
                Console.Write(f+ " ");
            }
        }
    }
}
