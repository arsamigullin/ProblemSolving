using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.PerfomanceMeasurement;
using Autofac;
using Autofac.Core;
using Autofac.Core.Registration;

namespace Algorithms.Modules
{
    public class RegisteringModules
    {
        public static IContainer Register() 
        {
            var containerBuilder= new ContainerBuilder();
            containerBuilder.RegisterType<Startup>();
            containerBuilder.RegisterType<Perfomance>();
            return containerBuilder.Build();
        }

    }
}
