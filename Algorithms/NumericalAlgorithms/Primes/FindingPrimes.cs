﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.NumericalAlgorithms.Primes
{
    [DisplayInfo("Primes", "Finding Primes", typeof(List<long>))]
    class FindingPrimes
    {
        private int number = 100;
        //sieve of Eratosthenes
        // Complexity O(N × log(log N))
        public List<long> Go()
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
            long total = 1;
            for (int i = 0; i < listPrimes.Count; i++)
            {
                total *= listPrimes[i];
            }
            return listPrimes;
        }
    }
}
