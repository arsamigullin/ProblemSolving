using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks
{
    [DisplayInfo("Anvanced Tasks", "Devisors Prime Factors in array", typeof(List<int>))]
    class DevisorsPrimeFactors
    {
        private int[] array = new int[16];
        public DevisorsPrimeFactors()
        {
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(16);
            }
        }
       // Given an array of integers, please find all divizors for each number (variants: (b) each prime divizors, (c) cound of prime factors etc)
        public List<int> Calculate()
        {
            List<int>[] devisors = new List<int>[16];
            for (int i = 0; i < array.Length; i++)
            {
                if (devisors[array[i]] == null)
                {
                    devisors[array[i]] = new List<int>();
                }
                SecondVariant(array[i], devisors);
            }

            return new List<int>();
        }

        private void SecondVariant(int num , List<int>[] devisors)
        {
            int number = num;
            List<int> factors = new List<int>();
            // you only need to check divisibility by 2 and

            while (number % 2 == 0)
            {
                devisors[num].Add(2);
                int nextNum = number / 2;
                if (devisors[nextNum]!= null && devisors[nextNum].Count != 0)
                {
                    devisors[num].AddRange(devisors[nextNum]);
                    return;
                }
                number = nextNum;
            }
            if (devisors[number] != null && devisors[number].Count != 0)
            {
                devisors[num].AddRange(devisors[number]);
                return;
            }
            //then by odd numbers instead of by all possible factors.Doing so cuts the
            //run time in half.
            int i = 3;
            // all prime factor would be less than Sqrt(number)
            // 
            int max_factor = (int)Math.Sqrt(number);

            while (i <= max_factor)
            {
                while (number % i == 0)
                {
                    //factors.Add(i);
                    number = number / i;
                    if (devisors[number] != null && devisors[number].Count != 0)
                    {
                        devisors[num].AddRange(devisors[number]);
                        return;
                    }
                    else
                    {
                        devisors[num].Add(i);
                    }
                    // note that we must update max_factor
                    max_factor = (int)Math.Sqrt(number);
                }
                i = i + 2;
            }
            if (number > 0)
            {
                if (devisors[number] != null && devisors[number].Count != 0)
                {
                    devisors[num].AddRange(devisors[number]);
                    return;
                }
                else
                {
                    devisors[num].Add(number);
                }
            }
            return;
        }
    }
}
