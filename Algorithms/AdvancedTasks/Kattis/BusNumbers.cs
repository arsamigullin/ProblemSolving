using System;
using System.Collections.Generic;
using System.Linq;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks
{
    [DisplayInfo("Anvanced Tasks", "Bus Numbers ", typeof(List<string>))]
    public class BusNumbers
    {

        public List<string> Go()
        {
            string line;
            List<string> resList = new List<string>();
            int countNumbers;
            int[] numbersOfBuses = new int[0];
            bool start = false;
            while ((line = Console.ReadLine()) != "")
            {
                if (!start)
                {
                    countNumbers = Int32.Parse(line);
                    start = true;
                    continue;
                }
                string[] split = line.Split(new char[] {' '}, StringSplitOptions.None);
                numbersOfBuses = Array.ConvertAll(split, int.Parse);

                Array.Sort(numbersOfBuses);
                List<int> continiousList = new List<int>();
 
                for (int i = 0; i < numbersOfBuses.Length; i++)
                {
                    if (numbersOfBuses.Length - 1 != i)
                    {
                        if (numbersOfBuses[i + 1] - numbersOfBuses[i] == 1)
                        {
                            continiousList.Add(numbersOfBuses[i]);
                            continue;
                        }
                    }
                    if (continiousList.Count == 0)
                    {
                        resList.Add(numbersOfBuses[i].ToString());
                        continue;
                    }
                    if (continiousList.Count < 2)
                    {
                        foreach (var val in continiousList)
                        {
                            resList.Add(val.ToString());
                        }
                        resList.Add(numbersOfBuses[i].ToString());
                        continiousList.Clear();
                    }
                    if (continiousList.Count >= 2)
                    {

                        continiousList.Add(numbersOfBuses[i]);
                        resList.Add(continiousList.First() + "-" + continiousList.Last());
                        continiousList.Clear();
                    }
                }
                var result = String.Join(" ", resList);
                Console.WriteLine(result);
            }
            return resList;

        }
    }
}
