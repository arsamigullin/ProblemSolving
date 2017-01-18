using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks
{
    [DisplayInfo("Anvanced Tasks", "Cetiri ", typeof(List<string>))]
    public class Cetiri
    {
        public List<string> Go()
        {
            string line;
            int[] array = new int[0];
            while ((line = Console.ReadLine())!="")
            {
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            
                array = split.Select(Int32.Parse).ToArray(); 
                Array.Sort(array);
                int firstDif = array[1] - array[0];
                int secDif = array[2] - array[1];

                if (firstDif == secDif)
                {
                    if (array[2]+ firstDif<=100)
                    {
                        Console.WriteLine(array[2] + firstDif);
                        continue;
                    }
                    Console.WriteLine(array[0] - firstDif);
                    continue;
                }

                if (firstDif > secDif)
                {
                    Console.WriteLine(array[0] + secDif);
                    continue;
                }
                Console.WriteLine(array[1] + firstDif);
            }

            return new List<string>();
        }
    }
}
