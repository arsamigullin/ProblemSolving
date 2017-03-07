using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Algorithms
{
    public class ReadingTestCases
    {
        private static Queue<string> queue = new Queue<string>();
        private static List<string> list = new List<string>();
        public static void ReadAllText()
        {
            
            list =File.ReadAllText(@"C:\projects\ProblemSolving\test.txt").Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
            foreach (var l in list)
            {
                queue.Enqueue(l);
            }
           // queue.Enqueue(" ");
        }

        public static string ReadLine()
        {
            return queue.Dequeue();
        }

        public static void WriteLine(string res)
        {
            File.AppendAllText(@"C:\projects\ProblemSolving\results.txt", res+ "\n");
        }
    }
}