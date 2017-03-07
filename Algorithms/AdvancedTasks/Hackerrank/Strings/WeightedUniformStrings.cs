using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Strings
{
    
    [DisplayInfo("Hackerrank - Strings", "Weighted Uniform Strings", typeof(List<string>))]
    class WeightedUniformStrings
    {
        public  List<string> Go()
        {
            ReadingTestCases.ReadAllText();
            string s = ReadingTestCases.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            char prev = s[0];
            Point prevPoint = new Point(s[0] - 96, s[0]);
            List<Point> lp = new List<Point>();
            if (s.Length == 1)
            {
                lp.Add(prevPoint);
            }
            else
            {
                for (int i = 1; i < s.Length; i++)
                {
                    if (prev == s[i])
                    {
                        prevPoint.Sum += s[i] - 96;
                    }
                    else
                    {
                        lp.Add(prevPoint);
                        prevPoint = new Point(s[i] - 96, s[i]);
                        prev = s[i];
                        if (i == s.Length - 1)
                        {
                            lp.Add(prevPoint);
                        }
                    }
                }
            }

            int n = Convert.ToInt32(ReadingTestCases.ReadLine());
            for (int a0 = 0; a0 < n; a0++)
            {
                int x = Convert.ToInt32(ReadingTestCases.ReadLine());
                bool isYes = false;
                foreach (var p in lp)
                {
                    int dif = p.Sum - x;
                    if (dif < 0) continue;
                    if (dif == 0 || dif % ((int)p.Charp - 96) == 0)
                    {
                        ReadingTestCases.WriteLine("Yes");
                        isYes = true;
                        break;
                    }
                    //  Console.WriteLine(p.Charp+ " "+ p.Sum);

                }

                if (isYes) continue;
                ReadingTestCases.WriteLine("No");
                // your code goes here
            }
            return  new List<string>();
        }
        struct Point
        {
            public int Sum;
            public char Charp;
            public Point(int sum, char charp)
            {
                Charp = charp;
                Sum = sum;
            }
        }
    }
}
