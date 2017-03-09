using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms
{
    [DisplayInfo("Primes", "Finding Primes Factors", typeof(List<long>))]
    public class FindingPrimesFactors
    {
        private long num = 104775;
        // Complexity O(N)
        public List<long> FirstVariant()
        {
            long number = num;
            List<long> factors= new List<long>();
            // 2 is first prime number
            int i = 2;
            while (i<number)
            {
                while (number%i==0)
                {
                    factors.Add(i);
                    // Don't forget devide to i
                    number = number/i;
                }
                i++;
            }
            if (number>0) factors.Add(number);
            return factors;
        }

        // This methos based on theorem:
        // If positive number n is coposite then n has prime devisor p^2<=n
        // Complexity O(sqrt(N))
        public List<long> SecondVariant()
        {
            long number = num;
            List<long> factors = new List<long>();
            // you only need to check divisibility by 2 and
        
            while (number%2==0)
            {
                factors.Add(2);
                number = number/2;
            }

            //then by odd numbers instead of by all possible factors.Doing so cuts the
            //run time in half.
            int i = 3;
            // all prime factor would be less than Sqrt(number)
            // 
            int max_factor = (int) Math.Sqrt(number);

            while (i<=max_factor)
            {
                while(number%i==0)
                {
                    factors.Add(i);
                    number = number / i;
                    // note that we must update max_factor
                    max_factor = (int)Math.Sqrt(number);
                }
                i = i + 2;
            }
            if (number > 0) factors.Add(number);
            return factors;
        }


    }
}
