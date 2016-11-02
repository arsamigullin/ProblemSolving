using System;
using System.Collections.Generic;
using System.ComponentModel;
using Algorithms.Attributes;

namespace Algorithms.NumericalAlgorithms.Primes
{
    // This algorithm based on Fermat's theorem. 
    // This one states that if p is prime and 1<=n<=p, then n^(p-1)%p=1
    // Note that it is possible for n^(p-1)%p=1 even if p is not prime. In that case value n is called a Fermat liar.
    //    It can be shown that, for a natural number p, at least half of the numbers n
    //between 1 and p are Fermat witnesses.In other words, if p is not prime and
    //    you pick a random number n between 1 and p, there is a 0.5 probability that n 
    //is a Fermat witness, so np–1 Mod p ≠ 1.
    [DisplayInfo("Primes", "Testing for primality", typeof(List<bool>))]
    public class TestingForPrimality
    {
        private int maxtests = 10;
        private int number = 46213;
        public List<bool> Go()
        {
            List<bool> resList = new List<bool>();
            Random r = new Random();
            for (int i = 1; i < maxtests; i++)
            {
                var random= r.Next(1, number);
                if (Math.Pow(random, number - 1)% number == 1) continue;
                resList.Add(false);
                return resList;
            }
            // The number is probably prime.
            // (There is a 1/2max_tests chance that it is not prime.)
            resList.Add(true);
            return resList;
        }
    }
}
