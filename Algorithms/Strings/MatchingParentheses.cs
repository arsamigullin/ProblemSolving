using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.Strings
{
    [DisplayInfo("Strings", "Matching Parentheses", typeof(List<int>))]
    class MatchingParentheses
    {
        public List<int> Find()
        {
            int count = 0;
            string s = "((()(()(()";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(') count++;
                if (s[i] == ')') count--;
            }
            // if count was set to 0, parentheses are nested properly
            return new List<int> {count};
        }
    }
}
