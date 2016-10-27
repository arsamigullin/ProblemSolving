using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Primes
{
    class FindingPrimes
    {
        public static void FirstVariant(int number)
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
            Console.WriteLine();
        }

        public static void SecondVariant(int number)
        {
            List<int> factors = new List<int>();

            while (number%2==0)
            {
                factors.Add(2);
                number = number/2;
            }

            int i = 3;
            int max_factor = (int) Math.Sqrt(number);

            while (i<=max_factor)
            {
                while(number%i==0)
                {
                    factors.Add(i);
                    number = number / i;
                    max_factor = (int)Math.Sqrt(number);
                }
                

                i = i + 2;
            }

            if (number > 0) factors.Add(number);

            foreach (var f in factors)
            {
                Console.Write(f + " ");
            }
            Console.WriteLine();
        }


    }
}
