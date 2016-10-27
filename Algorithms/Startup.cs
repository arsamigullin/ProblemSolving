using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.PerfomanceMeasurement;
using Algorithms.Primes;

namespace Algorithms
{
    public class Startup
    {
        Perfomance Perfomance { get; set; }

        public Startup(Perfomance perfomance)
        {
            Perfomance = perfomance;
        }
        public void Go()
        {
            Perfomance.DoMeasure(FindingPrimes.FirstVariant, 156321665);
            Perfomance.DoMeasure(FindingPrimes.SecondVariant, 156321665);

        }
    }
}
