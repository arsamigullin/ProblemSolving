using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Search
{
    [DisplayInfo("Hackerrank - Search", "Tower of Hanoi 3 Rods", typeof(List<long>))]
    class TowerOfHanoi3Rods
    {
        public List<long> DoMoving()
        {
            Stack<int> from_peg = new Stack<int>();
            from_peg.Push(10);
            from_peg.Push(9);
            from_peg.Push(8);
            from_peg.Push(7);
            from_peg.Push(6);
            from_peg.Push(5);
            from_peg.Push(4);
            from_peg.Push(3);
            from_peg.Push(2);
            from_peg.Push(1);
            Stack<int> to_peg = new Stack<int>();
            Stack<int> other_peg = new Stack<int>();
            hanoi(from_peg, to_peg, other_peg, 10);
            return new List<long>();
        }

        private void hanoi(Stack<int> from_peg, Stack<int> to_peg , Stack<int> another_peg, int n)
        {
            if (n > 1)
            {
                hanoi(from_peg,another_peg,to_peg,n-1);
            }
            to_peg.Push(from_peg.Pop());
            if (n > 1)
            {
                hanoi(another_peg, to_peg, from_peg, n - 1);
            }
        }
    }
}
