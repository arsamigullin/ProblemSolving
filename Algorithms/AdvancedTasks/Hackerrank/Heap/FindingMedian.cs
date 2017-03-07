using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.AdvancedTasks.Hackerrank.Heap.HeapDescription;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Heap
{
    [DisplayInfo("Anvanced Tasks Hackerrank", "Heap : Finding Median", typeof(List<bool>))]
    class FindingMedian
    {
        public List<bool> Go()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MinHeap minHeap = new MinHeap(10);
            MaxHeap maxHeap = new MaxHeap(10);
            double m=0;
            
            for (int i = 0; i < array.Length; i++)
            {
               // minHeap.add(array[i]);
              //  maxHeap.add(array[i]);
               m = getMedian(array[i], m,  maxHeap, minHeap);
                Console.WriteLine(m);
            }
            return new List<bool>();
        }
        // Greater and Smaller are used as comparators
        bool Greater(int a, int b)
        {
            return a > b;
        }

        bool Smaller(int a, int b)
        {
            return a < b;
        }

        double Average(double a, double b)
        {
            return ((double)(a + b)) / 2;
        }

        // Signum function
        // = 0  if a == b  - heaps are balanced
        // = -1 if a < b   - left contains less elements than right
        // = 1  if a > b   - left contains more elements than right
        int Signum(int a, int b)
        {
            if (a == b)
                return 0;

            return a < b ? -1 : 1;
        }

        // Function implementing algorithm to find median so far.
        double getMedian(int e, double m, HeapDescription.Heap l, HeapDescription.Heap r)
        {
            // Are heaps balanced? If yes, sig will be 0
            int sig = Signum(l.getSize(), r.getSize());
            switch (sig)
            {
                case 1: // There are more elements in left (max) heap

                    if (e < m) // current element fits in left (max) heap
                    {
                        // Remore top element from left heap and
                        // insert into right heap
                        r.add(l.poll());

                        // current element fits in left (max) heap
                        l.add(e);
                    }
                    else
                    {
                        // current element fits in right (min) heap
                        r.add(e);
                    }

                    // Both heaps are balanced
                    m = Average(l.peek(), r.peek());

                    break;

                case 0: // The left and right heaps contain same number of elements

                    if (e < m) // current element fits in left (max) heap
                    {
                        l.add(e);
                        m = l.peek();
                    }
                    else
                    {
                        // current element fits in right (min) heap
                        r.add(e);
                        m = r.peek();
                    }

                    break;

                case -1: // There are more elements in right (min) heap

                    if (e < m) // current element fits in left (max) heap
                    {
                        l.add(e);
                    }
                    else
                    {
                        // Remove top element from right heap and
                        // insert into left heap
                        l.add(r.poll());

                        // current element fits in right (min) heap
                        r.add(e);
                    }

                    // Both heaps are balanced
                    m = Average(l.peek(), r.peek());

                    break;
            }

            // No need to return, m already updated
            return m;
        }
    }
}
