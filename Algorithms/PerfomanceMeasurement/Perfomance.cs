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

        public void DoMeasure(Action<int> action, int param)
        {
            Console.WriteLine("Start executing method " + action.Method.Name);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            action.Invoke(param);
            sw.Stop();
            Console.WriteLine("End executing method " + action.Method.Name + ". Elapsed time: " + sw.Elapsed);
        }
    }
}
