using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.Strings
{
    [DisplayInfo("Strings", "Knuth Morris Pratt KPMA lgo", typeof(List<int>))]
    class KnuthMorrisPrattKPMAlgo
    {
        public List<string> Go()
        {
            string T = "ddfgjasdf";
            string P = "fgjasd";
            var f = KMP(T, T.Length, P, P.Length);
            return new List<string>();
        }


        int KMP(string T, int n, string P, int m )
        {
            int i = 0, j = 0;
            int[] F = new int[P.Length];
            PrefixTable(F, P, m);
            while (i<n)
            {
                if (T[i] == P[j])
                {
                    if (j == m - 1)
                    {
                        return i - j;
                    }
                    else
                    {
                        i++;
                        j++;
                    }
                }
                else if (j>0)
                {
                    j = F[j - 1];
                }
                else
                {
                    i++;
                }
            }
            return -1;
        }

        void PrefixTable (int [] F, string P, int m)
        {
            int i = 1, j = 0; 
                F[0]=0;
            while (i<m)
            {
                if (P[i] == P[j])
                {
                    F[i] = j + 1;
                    j++;
                    i++;
                }
                else if (j > 0)
                {
                    j = F[j - 1];
                }
                else
                {
                    F[i] = 0;
                    i++;
                }
            }
        }
    }
}
