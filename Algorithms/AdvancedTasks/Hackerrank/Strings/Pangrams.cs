using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank
{
    [DisplayInfo("Anvanced Tasks", "Hackerrank - Pangrams", typeof(List<string>))]
    class Pangrams
    {
        public List<string> FindPangrams()
        {
            string s = "We promptly judged antique ivory buckles for the next prize";
            string letters = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsWhiteSpace(s[i])) continue;
                if (letters.Contains(s[i])) continue;
                letters += s[i];
            }
            string result = letters.Length == 26 ? "pangram" : "not pangram";
            return new List<string> {result};
        }
    }
}
