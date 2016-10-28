using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.NumericalAlgorithms.Primes;
using Algorithms.PerfomanceMeasurement;

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
            Perfomance.DoMeasure(FindingPrimes.Go, 6);
            Perfomance.DoMeasure(FindingPrimesFactors.FirstVariant, 156321665);
            Perfomance.DoMeasure(FindingPrimesFactors.SecondVariant, 125);
        }
    }
}
