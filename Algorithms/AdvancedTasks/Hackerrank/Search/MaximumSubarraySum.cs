using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.AdvancedTasks.DataStructure.Trees.BST;
using Algorithms.Attributes;
using Algorithms.Trees;

namespace Algorithms.AdvancedTasks.Hackerrank.Search
{
    [DisplayInfo("Hackerrank - Search", "Maximum Subarray Sum", typeof(List<int>))]
    class MaximumSubarraySum
    {
        public List<int> Go()
        {
            ReadingTestCases.ReadAllText();
            int q = Int32.Parse(ReadingTestCases.ReadLine());
            StringBuilder sb = new StringBuilder();
            while (q-->0)
            {
                long[] arr = Array.ConvertAll(ReadingTestCases.ReadLine().Split(' '), long.Parse);
                long n = arr[0];
                long m = arr[1];
                LowerBoundSortedSet<long> root = new LowerBoundSortedSet<long>();
                arr = Array.ConvertAll(ReadingTestCases.ReadLine().Split(' '), long.Parse);
                long max = long.MinValue;

                long prefix = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    prefix = (prefix%m  + arr[i]%m ) % m;
                    long a = root.FindLowerBound(prefix+1);
                    max = Math.Max((prefix - a + m)%m, max);
                    root.Add(prefix);
                }
                Console.WriteLine(max);
                //sb.AppendLine(max.ToString()); //109391481

            }
          //  ReadingTestCases.WriteLine(sb.ToString());
            return new List<int>();
        }
    }

    public class LowerBoundSortedSet<T> : SortedSet<T>
    {

        private ComparerDecorator<T> _comparerDecorator;

        private class ComparerDecorator<T> : IComparer<T>
        {

            private IComparer<T> _comparer;

            public T LowerBound { get; private set; }

            private bool _reset = true;

            public void Reset()
            {
                _reset = true;
            }

            public ComparerDecorator(IComparer<T> comparer)
            {
                _comparer = comparer;
            }

            public int Compare(T x, T y)
            {
                int num = _comparer.Compare(x, y);
                if (_reset)
                {
                    LowerBound = y;
                }
                if (num <= 0)
                {
                    LowerBound = y;
                    _reset = false;
                }
                return num;
            }
        }

        public LowerBoundSortedSet()
            : this(Comparer<T>.Default)
        {
            
        }

        public LowerBoundSortedSet(IComparer<T> comparer)
            : base(new ComparerDecorator<T>(comparer))
        {
            _comparerDecorator = (ComparerDecorator<T>)this.Comparer;
        }

        public T FindLowerBound(T key)
        {
            _comparerDecorator.Reset();
            this.Contains<T>(key);
            return _comparerDecorator.LowerBound;
        }
    }
}
