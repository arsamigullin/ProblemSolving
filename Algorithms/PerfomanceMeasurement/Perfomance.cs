using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.PerfomanceMeasurement
{
    public class Perfomance
    {
        public void DoMeasure(Action action)
        {
            Console.WriteLine("Start executing method "+ action.Method.Name);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            action.Invoke();
            sw.Stop();
            Console.WriteLine("End executing method "+ action.Method.Name+". Elapsed time: "+ sw.Elapsed);
        }

        public void DoMeasure(Func<long, List<long>> function, long param)
        {
            Console.WriteLine("Start executing method " + function.Method.Name);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<long> results = function.Invoke(param);
            sw.Stop();
            Console.Write("Results: ");
            foreach (var res in results)
            {
                Console.Write(res+"; ");
            }
            if (results.Count == 0)
            {
                Console.Write("No Results");
            }
            Console.WriteLine("\nEnd executing method " + function.Method.Name + ". Elapsed time: " + sw.Elapsed+"\n");
        }
    }
}
