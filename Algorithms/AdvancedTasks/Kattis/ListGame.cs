using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks
{
    [DisplayInfo("Anvanced Tasks", "List Games ", typeof(List<string>))]
    class ListGame
    {
        public List<string> Go()
        {
            string line;
            List<string> resList = new List<string>();
            long number;
            List<long> factors = new List<long>();
            while ((line = Console.ReadLine()) != "")
            {
                number = long.Parse(line);
               
                // you only need to check divisibility by 2 and

                while (number % 2 == 0)
                {
                    factors.Add(2);
                    number = number / 2;
                }

                //then by odd numbers instead of by all possible factors.Doing so cuts the
                //run time in half.
                long i = 3;
                // all prime factor would be less than Sqrt(number)
                // 
                long max_factor = (long)Math.Sqrt(number);

                while (i <= max_factor)
                {
                    while (number % i == 0)
                    {
                        if (i==1) continue;
                        factors.Add(i);
                        number = number / i;
                        // note that we must update max_factor
                        max_factor = (long)Math.Sqrt(number);
                    }
                    i = i + 2;
                }
                if (number > 1) factors.Add(number);
            }
            Console.WriteLine(factors.Count);
            return resList;
        }
    }
}
