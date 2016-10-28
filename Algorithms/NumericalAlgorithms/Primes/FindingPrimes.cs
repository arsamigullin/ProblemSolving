using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.NumericalAlgorithms.Primes
{
    class FindingPrimes
    {

        //sieve of Eratosthenes
        // Complexity O(N × log(log N))
        public static List<long> Go(long number)
        {
            bool [] isComposite= new bool[number+1];

            // cross out multiples of 2
            for (int i = 4; i < number; i=i+2)
            {
                isComposite[i] = true;
            }

            // cross out multiples of primes found so far
            int next_prime = 3;
            int stop_at = (int)Math.Sqrt(number);
            while (next_prime <= stop_at)
            {
                // "Cross out" multiples of this prime.
                // next_prime*2 helps exclude prime numbers itself
                for (int i = next_prime*2; i < number; i=i+next_prime)
                {
                    isComposite[i] = true;
                }

                // Move to the next prime, skipping the even numbers.
                next_prime = next_prime + 2;
                // if number already was marked as Composite, will cross out it
                while (next_prime<=number && isComposite[next_prime])
                {
                    next_prime = next_prime + 2;
                }
            }

            List<long> listPrimes= new List<long>();
            // Copy the primes into a list.
            for (int i = 2; i < number; i++)
            {
                if (!isComposite[i]) listPrimes.Add(i);
            }

            return listPrimes;
        }
    }
}
