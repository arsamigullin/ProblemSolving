using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;


namespace Algorithms.AdvancedTasks.Hackerrank.Search
{
    [DisplayInfo("Hackerrank - Search", "Short Palindrome", typeof(List<long>))]
    class ShortPalindrome
    {
     
        public List<long> Go()
        {
            ReadingTestCases.ReadAllText();
            string s = ReadingTestCases.ReadLine();
            Dictionary<char, List<long>> dict = new Dictionary<char, List<long>>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]].Add(i);
                }
                else
                {
                    dict.Add(s[i], new List<long> { i });
                }
            }
            BigInteger total = 0;
            int p = 4;
            int mod = 1000000007;
            foreach (var kvp in dict)
            {
                int n = kvp.Value.Count;
                if (n <= 1) continue;
                BigInteger res = 0;
                if (n >= p)
                {
                    res = 1;
                    for (int i = 1; i <= p; i++)
                    {
                        res = res * (n - p + i) / i;
                    }
                }
                //total = (total%mod+ res%mod) % mod;
                var externalList = kvp.Value;
                foreach (var kvpIn in dict)
                {
                    if (kvpIn.Value.Count <= 1) continue;
                    //if (kvp.Key == kvpIn.Key) continue;
                    var internalList = kvpIn.Value;
                    Point[] arr = new Point[internalList.Count];
                    long firstExt = externalList[0];
                    long lastExt = externalList[externalList.Count - 1];
                    int start = 0;
                    int end = 0;
                    int prevInt = 0;
                    for (int i = 0; i < externalList.Count; i++)
                    {
                        if (i == 0)
                        {
                            // Determine start index for the second part of the palindrome
                            for (int j = 0; j < internalList.Count; j++)
                            {
                                if (firstExt > internalList[j]) continue;
                                start = j + 1;
                                break;
                            }
                            // Determine end index for the second part of the palindrome
                            for (int j = internalList.Count - 1; j >= 0; j--)
                            {
                                if (lastExt < internalList[j]) continue;
                                end = j;
                                break;
                            }
                            int lastIndexExt = externalList.Count - 1;
                            int prev = -1;

                            while (start <= end)
                            {
                                Point point = new Point();
                                while (lastIndexExt >= 0 && internalList[end] < externalList[lastIndexExt])
                                {
                                    point.cur++;
                                    lastIndexExt--;
                                }
                                if (prev > 0)
                                {
                                    point.cur = point.cur + arr[prev].cur;
                                    point.total = point.cur + arr[prev].total;
                                    point.tottot = point.total + arr[prev].tottot;
                                }
                                else
                                {
                                    point.total = point.cur;
                                    point.tottot = point.cur;
                                }
                                prev = end;
                                arr[end] = point;
                                end--;
                            }
                            prevInt = start == 0 ? 0 : start - 1;
                        }
                        long aftotal = 0;
                        if (externalList[i] > internalList[internalList.Count - 1])
                        {
                            continue;
                        }
                        for (int j = prevInt; j < internalList.Count - 1; j++)
                        {
                            if (externalList[i] > internalList[j])
                            {
                                continue;
                            }
                            prevInt = j;
                            aftotal = (aftotal  + arr[j + 1].tottot) % mod;
                            break;
                        }
                        total = (total + aftotal) % mod;
                    }

                }
            }
            Console.WriteLine(total%mod);
            return new List<long>();
        }

        public struct Point
        {
            public long cur;
            public long total;
            public long tottot;

            public Point(long cur, long total, long tottot)
            {
                this.cur = cur;
                this.total = total;
                this.tottot = tottot;
            }
        }
    }
}

