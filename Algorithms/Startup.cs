using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
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
            List<TypeDTO> typeslist= new List<TypeDTO>();
            AppDomain curDomain = AppDomain.CurrentDomain;
            foreach (var assembly in curDomain.GetAssemblies())
            {
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.GetCustomAttributes(typeof(DisplayInfoAttribute), true).Length > 0)
                    {
                        DisplayInfoAttribute attribute= (DisplayInfoAttribute) Attribute.GetCustomAttribute(type, typeof(DisplayInfoAttribute));
                        typeslist.Add(new TypeDTO {NameAlgorithm = attribute.NameAlgorithm, NameTypeAlgotrithms = attribute.NameTypeAlgorithms, Type = type, ReturnedType = attribute.ReturnType});
                    }
                }
            }

            var orderedTypedList = typeslist.GroupBy(x => x.NameTypeAlgotrithms);
            int order = 1;
            foreach (var grouptype in orderedTypedList)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(grouptype.Key);
                Console.ResetColor();
                Console.Write("\n");

                foreach (var typeItem in grouptype)
                {
                    typeItem.Order = order;
                    Console.WriteLine(order+" - "+typeItem.NameAlgorithm);
                    order++;
                }
            }

            string key= Console.ReadLine();
            int res;
            while (!Int32.TryParse(key, out res))
            {
                Console.WriteLine("You must eneter number");
                key = Console.ReadLine();
            }

            while (typeslist.All(x => x.Order != res))
            {
                Console.WriteLine("Algorithm not found");
                key = Console.ReadLine();
            }

            TypeDTO typeDto = typeslist.First(x => x.Order == res);
            var instance = Activator.CreateInstance(typeDto.Type);

            var miarr = typeDto.Type.GetTypeInfo().DeclaredMethods;

            foreach (var mi in miarr)
            {
                Perfomance.DoMeasure( mi, instance, typeDto);
            }

            Console.ReadLine();

            // Perfomance.DoMeasure(FindingPrimes.Go,22);
            //  Perfomance.DoMeasure(FindingPrimesFactors.FirstVariant, 156321665);
            // Perfomance.DoMeasure(FindingPrimesFactors.SecondVariant, 125);
        }
    }
}
