using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
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

        public void DoMeasure(Func<List<long>> function, long param)
        {
            Console.WriteLine("Start executing method " + function.Method.Name);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<long> results = function.Invoke();
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
            Console.Write("\nElapsed time of executing method ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(function.Method.Name);
            Console.ResetColor();
            Console.Write(" : " + sw.Elapsed+ "\n\n");
        }

        public void DoMeasure(MethodInfo mi, object instance)
        {
            Console.WriteLine("Start executing method " + mi.Name);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<long> results = (List<long>) mi.Invoke(instance, BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public, null, null, CultureInfo.InvariantCulture);
            sw.Stop();
            Console.Write("Results: ");
            foreach (var res in results)
            {
                Console.Write(res + "; ");
            }
            if (results.Count == 0)
            {
                Console.Write("No Results");
            }
            Console.Write("\nElapsed time of executing method ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(mi.Name);
            Console.ResetColor();
            Console.Write(" : " + sw.Elapsed + "\n\n");
        }
    }
}
