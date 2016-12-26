using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.NumericalAlgorithms.Devisors
{
    [DisplayInfo("Devisors", "Great Common Devisor", typeof(List<long>))]
    class GCD
    {
        // O(logB) - Euclidian algorithm
        public List<long> CalculateGDC()
        {
            long number1 = 4851;
            long number2 = 3003;
            long reminder; 
            while (number2!=0)
            {
                reminder = number1%number2;
                number1 = number2;
                number2 = reminder;
            }
            return new List<long> { number1 };
        }
         
    }
}
