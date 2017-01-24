using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.NumericalAlgorithms.Devisors
{
    [DisplayInfo("Numeric Algorithms", "GCD", typeof(List<long>))]
    class GCD
    {
        // O(logB) - Euclidian algorithm
        public List<long> CalculateGDC()
        {
            long number1 = 3;
            long number2 = 4;
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
