using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks
{
    [DisplayInfo("Hackerrank - Strings", "Hackerrank - Two Characters", typeof(List<int>))]
    class TwoCharacters
    {
        public List<int> Go()
        {

            string s = Console.ReadLine();        
            string disStr = String.Join("", s.Distinct());
            int[] results = new int[disStr.Length];
            results[0] = 0;
            for (int i = 0; i < disStr.Length - 1; i++)
            {
                for (int j = i + 1; j < disStr.Length; j++)
                {
                    int result = IsGood(s, disStr[i], disStr[j]);

                    if (result > 0)
                    {
                        results[j] = result;
                    }
                }
            }
            return new List<int> { results.Max() };

        }
        int IsGood(string s, char firs, char second)
        {
            string temp = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == firs || s[i] == second)
                {
                    temp += s[i];
                }
            }
            if (temp.Length <= 1) return 0;
            char last = temp[0];
            for (int i = 1; i < temp.Length; i++)
            {
                if (temp[i] == last)
                {
                    return 0;
                }
                last = temp[i];
            }
            return temp.Length;
        }
    }
}
