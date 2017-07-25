using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Stack
{
    [DisplayInfo("Anvanced Tasks - Hackerrank", "Maximum Element", typeof(List<int>))]
    class MaximumElement
    {
        public List<int> Go()
        {
            ReadingTestCases.ReadAllText();
            int N = Convert.ToInt32(ReadingTestCases.ReadLine());
            Stack<int> stack = new Stack<int>();
            int curMax = Int32.MinValue;
            Stack<int> stackMax = new Stack<int>();
            while (N-- > 0)
            {
                string query = ReadingTestCases.ReadLine().Trim();


                if (query.Length > 1)
                {
                    string[] arr = query.Split(' ');
                    int val = Convert.ToInt32(arr[1]);
                    stack.Push(val);
                    if (val > curMax)
                    {
                        curMax = val;
                        stackMax.Push(curMax);
                    }
                }
                else
                {
                    if (query == "2")
                    {
                        int popVal = stack.Pop();
                        if (popVal == curMax)
                        {
                            if (stackMax.Count > 0)
                            {
                                stackMax.Pop();
                                if (stackMax.Count > 0)
                                {
                                    curMax = stackMax.Peek();
                                }
                                else
                                {
                                    curMax = Int32.MinValue;
                                }
                            }
                            else
                            {
                                curMax = Int32.MinValue;
                            }
                        }
                    }
                    else
                    {
                        ReadingTestCases.WriteLine(curMax.ToString());
                    }
                }
            }
            return new List<int>();
        }
    }
}
