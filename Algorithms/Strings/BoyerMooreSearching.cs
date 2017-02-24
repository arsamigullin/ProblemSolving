using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.Strings
{

    [DisplayInfo("Strings", "Matching Parentheses", typeof(List<int>))]
    public class BoyerMooreSearching
    {
        private string target = "sdfsdg";
        private string findee = "sdg";

        struct Point
        {
            public int I;
            public int J;
        }


        public List<int> search()
        {
          List<char[]> lp = new List<char[]>();
            lp.Add("00".ToCharArray());

            long[][] M = new long[3][];
            var y = M[4][5];
            if (target.Length<findee.Length)
                return new List<int>();
            int targetLen = target.Length;
            int moving = findee.Length-1;
            int findeeLen = findee.Length;
            int indexf = findee.Length - 1;
            while (moving<targetLen)
            {
                if (target[moving] != findee[indexf])
                {
                    moving = moving+ findeeLen;
                    continue;
                }
                int indexTarget = moving;
                bool isnot = false;
                for (int i = findeeLen-2; i >=0; i--, indexTarget--)
                {
                    if (target[indexTarget]==target[i]) continue;
                    isnot = true;
                    break;
                }
            }
            return  new List<int>();
            
        }
    }
}
