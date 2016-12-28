using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks
{
    [DisplayInfo("Anvanced Tasks", "HacherRank - Super Reduced String", typeof(List<string>))]
    class SuperReducingString
    {
        public List<string> Go()
        {
            string s = "acdqglrfkqyuqfjkxyqvnrtysfrzrmzlygfveulqfpdbhlqdqrrqdqlhbdpfqluevfgylzmrzrfsytrnvqyxkjfquyqkfrlacdqj";
            string distString = String.Join("", s.Distinct());
            string temp = "";
            bool whileBreak = false;
            while (true)
            {
                whileBreak = false;
                for (int j = 0; j < distString.Length; j++)
                {
                    s = s.Replace(distString[j].ToString() + distString[j], "");
                }
                for (int j = 0; j < distString.Length; j++)
                {
                    if (s.IndexOf(distString[j].ToString() + distString[j], StringComparison.Ordinal) >= 0)
                    {
                        whileBreak = true;
                        break;
                    }
                }
                if (!whileBreak)
                break;
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
