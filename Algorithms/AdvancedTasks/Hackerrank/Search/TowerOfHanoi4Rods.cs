using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Search
{
    [DisplayInfo("Hackerrank - Search", "Tower of Hanoi 4 Rods", typeof(List<long>))]
    class TowerOfHanoi4Rods
    {
        public List<long> DoMoving()
        {
            Peg from_peg = new Peg("PEG_FROM");
            //from_peg.Rod.Push(10);
            //from_peg.Rod.Push(9);
            //from_peg.Rod.Push(8);
            //from_peg.Rod.Push(7);
            //from_peg.Rod.Push(6);
            from_peg.Rod.Push(5);
            from_peg.Rod.Push(4);
            from_peg.Rod.Push(3);
            from_peg.Rod.Push(2);
            from_peg.Rod.Push(1);
            Peg to_peg = new Peg("PEG_TO");
           // to_peg.Rod.Push(5);
            Peg dev_peg = new Peg("PEG_DEV");
           // dev_peg.Rod.Push(3);
            Peg aux_peg = new Peg("PEG_AUX");
            //aux_peg.Rod.Push(1);

            Dictionary<int, int> dict = new Dictionary<int, int>();

            dict.Add(0, 0);
            dict.Add(1, 0);
            dict.Add(2, 1);
            dict.Add(3, 1);
            dict.Add(4, 2);
            dict.Add(5, 3);
            dict.Add(6, 3);
            dict.Add(7, 4);
            dict.Add(8, 5);
            dict.Add(9, 7);
            dict.Add(10, 6);
            dict.Add(11, 7);
            int count = 0;
            hanoi(from_peg.Rod.Count, from_peg, to_peg, dev_peg, aux_peg, dict, ref count);
            return new List<long>();

        }

        private void hanoi(int n, Peg source_peg , Peg goal_peg, Peg dev_peg, Peg axiul_peg, Dictionary<int, int> dict, ref int count)
        {
            if (n !=0)
            {
                int m = dict[n];
                hanoi(m,source_peg,dev_peg, goal_peg, axiul_peg, dict, ref count);
                FS3(n - m, m + 1, source_peg, goal_peg, axiul_peg, ref count);
                hanoi(m, dev_peg, goal_peg, source_peg, axiul_peg, dict, ref count);
            }
         
            
        }

        private void FS3(int n, int d, Peg source_peg, Peg goal_peg, Peg auxil_peg, ref int count)
        {
            if (n != 0)
            {
                FS3(n-1,d,source_peg, auxil_peg, goal_peg, ref count);
                //if (goal_peg.Rod.Count == 2 && goal_peg.Rod.Contains(2) && goal_peg.Rod.Contains(4))
                //{

                //}
                goal_peg.Rod.Push(source_peg.Rod.Pop());

                Console.WriteLine(source_peg.Name+ "--->"+goal_peg.Name);
                count++;
                FS3(n - 1, d, auxil_peg, goal_peg, source_peg, ref count);
            }
        }

        public class Peg
        {
            public Stack<int> Rod = new Stack<int>();
            public string Name;

            public Peg(string name)
            {
                Name = name;
            }
            public void push(int val)
            {
                Rod.Push(val);
            }

            public int pop()
            {
                return Rod.Pop();
            }
        }
    }
}
