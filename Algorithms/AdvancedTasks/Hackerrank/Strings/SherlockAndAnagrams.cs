using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Strings
{
    [DisplayInfo("Hackerrank - Strings", "Hackerrank - Sherlock And Anagrams", typeof(List<string>))]
    class SherlockAndAnagrams
    {
        public List<string> Go()
        {
            ReadingTestCases.ReadAllText();
            int T = Int32.Parse(ReadingTestCases.ReadLine());
            while (T > 0)
            {
                T--;
                string s = ReadingTestCases.ReadLine();
                int totalCount = 0;

                for (int i = 0; i < s.Length-1; i++)
                {
                     
                    for (int j = i+1; j < s.Length; j++)
                    {
                        int[] first = new int[26];
                        int[] second = new int[26];
                        int bindleft = i;
                        int bindright = j;
                        while (bindright < s.Length)
                        {

                            first[s[bindleft] - 97]++;
                            second[s[bindright] - 97]++;
                            bindleft++;
                            bindright++;
                            if (compare(first, second))
                            {
                                totalCount++;
                            }
                        }
                    }
                    
                }
                Console.WriteLine(totalCount);
            }
            return new List<string>();
        }

        static bool compare(int[] first, int[] second)
        {
            for (int i = 0; i < 26; i++)
            {
                if (first[i] != second[i]) return false;
            }
            return true;
        }
    }
}
