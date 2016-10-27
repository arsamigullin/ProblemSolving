using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Modules;
using Algorithms.PerfomanceMeasurement;
using Autofac;

namespace Algorithms
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            Container = RegisteringModules.Register();
            Startup startup = Container.Resolve<Startup>();
            startup.Go();
            Console.ReadLine();
        }
    }
}
