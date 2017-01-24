using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks
{
    [DisplayInfo("Anvanced Tasks", " Boyer Moore Serching Entries Algorithm", typeof(bool[]))]
    class BoyerMooreSearchingEntriesString
    {
        public bool[] Go()
        {
            string source="fnhgdlk";
            // TODO: !!!not work if target length equal 2
            string target="gdl";
            if (source.Length < target.Length)
                return new[] {false};
            int ti = target.Length-1;
            int si = ti;

            while (si<=source.Length)
            {
                while (target[ti]==source[si])
                {
                    if (ti == 0)  return new[] {true};
                    ti--;
                    si--;
                }
                if (ti == target.Length - 1)
                {
                    
                }
                 ti = target.Length;
                int index = target.IndexOf(source[si], 0, target.Length - 1 - ti);
                // Check if char source[si] contains in target string and get index
                if ( index== -1)
                {
                    si = 2*(target.Length - 1) - ti;
                }
                else
                {
                    si = ti - index;
                }
            }
            return new[] { false };
        }
    }
}
