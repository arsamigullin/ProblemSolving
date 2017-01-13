using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Strings
{
    [DisplayInfo("Anvanced Tasks", "Hackerrank - MakingAnagrams", typeof(List<string>))]
    class MakingAnagrams
    {
        public List<int> Go()
        {
            string a = "cde";
            string b = "abc";
            int count = 0;

            count = a.Count(x => !b.Contains(x));
            count += b.Count(x => !a.Contains(x));

            string dista = String.Join("", a.Where(b.Contains).Distinct());

            for (int i = 0; i < dista.Length; i++)
            {
                int cnta = a.Count(x => x == dista[i]);
                int cntb = b.Count(x => x == dista[i]);
                count += Math.Abs(cnta - cntb);
            }

          return new List<int>();
        }
    }
}
