using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Strings
{
    [DisplayInfo("Anvanced Tasks - Hackerrank", "Bigger Is Greater2", typeof(List<int>))]

    class BiggerIsGreater2
    {
        public List<int> start()
        {
            ReadingTestCases.ReadAllText();
             int n = Int32.Parse(ReadingTestCases.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                String s = ReadingTestCases.ReadLine();
                int start = -1;
                char[] chararr = s.ToCharArray();
                for (int j = 0; j < chararr.Length - 1; j++)
                {
                    if (chararr[j] < chararr[j + 1])
                    {
                        start = j;
                    }
                }
                if (start == -1)
                {
                    Console.WriteLine("no answer");
                    break;
                }
                int end = -1;
                for (int j = start + 1; j < chararr.Length; j++)
                {
                    if (chararr[start] < chararr[j])
                    {
                        end = j;
                    }
                }
                char temp = chararr[start];
                chararr[start] = chararr[end];
                chararr[end] = temp;
                char[] chararrcopy = new char[chararr.Length - (start + 1)];
                for (int j = start + 1, k = 0; j < chararr.Length; j++, k++)
                {
                    chararrcopy[k] = chararr[j];
                }

                Array.Sort(chararrcopy);
                for (int j = start + 1; j < chararr.Length; j++)
                {
                    chararr[j] = chararrcopy[j - start - 1];
                }
                Console.WriteLine(new string(chararr));
            }
            return new List<int>();
        }
    }
}
