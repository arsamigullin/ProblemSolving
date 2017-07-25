using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.Strings
{
    [DisplayInfo("Strings", "Reverse string", typeof(List<int>))]
    class ReverseString
    {
        public List<int> Go()
        {
            string s = "dslkfjhfahsdf";
            char[] charArrForReverse = s.ToCharArray();
            for (int i = 0, j = s.Length - 1; i <= j; i++, j--)
            {
                char ch = charArrForReverse[i];
                charArrForReverse[i] = charArrForReverse[j];
                charArrForReverse[j] = ch;
            }
            string res = new string(charArrForReverse);
            return new List<int>();
        }
    }
}
