using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Search
{
    [DisplayInfo("Hackerrank - Search", "Hackerland Radio Transmitters", typeof(List<int>))]
    class Hackerland_Radio_Transmitters
    {
        public List<int> Go()
        {
            ReadingTestCases.ReadAllText();
            string[] tokens_n = ReadingTestCases.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] x_temp = ReadingTestCases.ReadLine().Split(' ');
            int[] x = Array.ConvertAll(x_temp, Int32.Parse);
            Array.Sort(x);
            int range = k * 2;
            int count = 0;
            for (int i = 0; i < x.Length;)
            {
                int h = x[i];
                int ind = i + 1;
                bool isExists = false;
                while (ind < x.Length && x[ind] - h <= k)
                {
                    isExists = true;
                    ind++;
                }
                count++;
                if (ind < x.Length && isExists)
                {
                    h = x[--ind];
                    ind++;
                    while (ind < x.Length && x[ind] - h <= k)
                    {
                        //isExists=true;
                        ind++;
                    }
                }
                i = ind;
                //Console.WriteLine(ind);
            }
            Console.WriteLine(count);
            return new List<int>();
        }
    }
}
