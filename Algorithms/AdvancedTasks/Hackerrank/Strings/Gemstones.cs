using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Strings
{
    [DisplayInfo("Hackerrank - Strings", "Hackerrank - Gemstones", typeof(List<string>))]
    class Gemstones
    {
        public List<string> Go()
        {
            string s = "0";
            char c = Convert.ToChar(s);
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string[] list = new string[5];
            list[0] = "wlqdbbmrbbca";
            list[1] = "fndlpcyisdcosxjrglsyracbbqaebwdmbkdofeexoqphwfgacdlnxkmprxrljpdy";
            list[2] = "dzxxhqjophycwuccrwrhbekczqrqiifjbcqkxszhtqvabfncsalkvffcbaxsapnpmohk";
            list[3] = "tootcndrwusguhbdbxkluagaxeobzyeddacdwngrwmbchqplu";
            list[4] = "jihcqygidhsfoyvabxajuvlphluzomo";
            bool isContains = true;
            int cntSymbols = 0;

            string first = String.Join("", list[0].Distinct());
            for (int j = 0; j < first.Length; j++)
            {
                isContains = true;
                for (int i = 1; i < list.Length; i++)
                {

                    if (!list[i].Contains(first[j].ToString()))
                    {
                        
                        isContains = false;
                        break;
                    }
                }
                if (isContains) cntSymbols++;
            }
            return new List<string> {cntSymbols.ToString()};
        }
    }
}

