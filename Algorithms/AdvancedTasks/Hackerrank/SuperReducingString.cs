using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks
{
    [DisplayInfo("Anvanced Tasks", "Hackerrank - Super Reduced String", typeof(List<string>))]
    class SuperReducingString
    {
        public List<string> Go()
        {
            string s = "acdqglrfkqyuqfjkxyqvnrtysfrzrmzlygfveulqfpdbhlqdqrrqdqlhbdpfqluevfgylzmrzrfsytrnvqyxkjfquyqkfrlacdqj";
            string distString = String.Join("", s.Distinct());
                for (int j = 0; j < distString.Length; j++)
                {
                    if (s.IndexOf(distString[j].ToString() + distString[j], StringComparison.Ordinal) >= 0)
                    {
                        s = s.Replace(distString[j].ToString() + distString[j], "");
                        j = -1;
                    }
                    
                }


               
            
            if (String.IsNullOrEmpty(s))
            {
                return new List<string> { "String Empty" };
            }
            return new List<string> {s};
            //acdqgacdqj
        }
    }
}
