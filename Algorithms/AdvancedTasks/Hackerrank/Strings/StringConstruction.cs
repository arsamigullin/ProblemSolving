using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Strings
{
    [DisplayInfo("Hackerrank - Strings", "Hackerrank - String Construction", typeof(List<string>))]
    class StringConstruction
    {
        public List<string> Go()
        {
            int l = (int)'l';
            ReadingTestCases.ReadAllText();
            int n = Convert.ToInt32(ReadingTestCases.ReadLine());
            for (int a0 = 0; a0 < n; a0++)
            {
                string s = ReadingTestCases.ReadLine();
                int count = 0;
                string p = "";
                for (int i = 0; i < s.Length;)
                {
                    int lenfin = 0;
                    int len = 0;
                    int lastindfin = 0;
                    int inc = 0;
                    for (int j = 0; j < p.Length; j++)
                    {
                        if (i + inc < s.Length)
                        {
                            if (p[j] == s[i + inc])
                            {

                                len++;
                                inc++;

                            }
                        }
                      
                        if (p[j] != s[i] || j == p.Length - 1 || i==s.Length-1 || i + inc<s.Length)
                        {
                            if (lenfin < len)
                            {
                                lenfin = len;
                                lastindfin = inc + i;
                                //    Console.WriteLine(i + " " + inc + " "+ lastindfin);
                                len = 0;
                                inc = 0;
                            }
                        }

                    }
                    //Console.WriteLine(i);
                    string part = "";
                    if (lenfin > 0)
                    {
                        i = lastindfin;
                        part = s.Substring(lastindfin - lenfin, lenfin);
                  
                        //Console.WriteLine(lastindfin + " " + lenfin);
                        // Console.WriteLine(part);
                    }
                    else
                    {
                        part = s[i].ToString();
                        i++;
                        count++;
                    }
               
                 //   Console.WriteLine(i);
                    p += part;
                    // Console.WriteLine(p);
                
                }
                Console.WriteLine(count);
            }
            return new List<string>();
        }
    }
}
