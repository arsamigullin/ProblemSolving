using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks
{
    [DisplayInfo("Anvanced Tasks", "Checking For Correctness", typeof(List<int>))]
    public class CheckingForCorrectness
    {
        public List<string> Go()
        {
            string line;
            int i = 0;
            long num1=0;
            long num2 =0;
            decimal d1;
            decimal d2;
            while ((line = Console.ReadLine()) != "")
            {
                //if (i == 0 || i % 3 == 3)
                //{
                string[] split = line.Split(new char[] { '+', '*', '^' }, StringSplitOptions.None);

                // i++;
                string res = "";
                if (line.Contains("+"))
                {
                    num1 = long.Parse(split[0]);
                    num2 = long.Parse(split[1]);

                    res = (num1 + num2).ToString();
                }
                else if (line.Contains("*"))
                {
                    // Multiplication between two Int32.Max-1 is wrong
                    // It is reason why we use decimal here
                    // Multiplication with decimal is correct
                    d1 = decimal.Parse(split[0]);
                    d2 = decimal.Parse(split[1]);
                    res = (d1 * d2).ToString();
                }
                else
                {

                    num1 = long.Parse(split[0]);
                    num2 = long.Parse(split[1]);
                    
                    if (num2 == 0)
                    {
                        Console.WriteLine("1");
                        continue;
                    }
                    // count of meaningful bits
                    var bits = (long)(Math.Log10(num2) / Math.Log10(2)) + 1;
                    var currentnum = num2;
                    // Converting number to binary represent
                    bool[] numOfBits = new bool[bits];
                    for (var j = bits-1; j >= 0; j--)
                    {
                        numOfBits[j] = currentnum % 2==1;
                        currentnum = currentnum / 2;
                    }
                    // As we need last four digit of powering operation 
                    // We have to use modulo 10000
                    res = calcMod(num1, num2, 10000, numOfBits).ToString();
                }
                if (res.Length >4)
                {
                    res = res.Substring(res.Length - 4, 4);
                }
                int stind=0;
                int len=0;
                // Remove leading zeros except last zero
                for (int j = 0; j < res.Length - 1; j++)
                {
                    if (res[j] != '0' && j == 0)
                    {
                        break;
                    }
                    if (res[j] == '0')
                    {
                        stind = j+1;
                        len = res.Length -j-1;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(stind > 0 ?res.Substring(stind, len):res); 
               

            }
            return new List<string>();
        }
        // Calculate Modulo

        private long calcMod(long A, long B, long C, bool[] bitsB)
        {
            long product = 0;
            long [] AtoBmodC = new long[bitsB.Length];
            for (int i = 0; i < bitsB.Length; i++)
            {
                if (i == 0)
                {
                    AtoBmodC[0] = myMod(A, C);
                }
                else
                {
                    AtoBmodC[i] = myMod(AtoBmodC[i - 1] * AtoBmodC[i - 1], C);
                }

                if (bitsB[bitsB.Length - 1 - i])
                {
                    if (product == 0)
                    {
                        product = AtoBmodC[i];
                    }
                    else
                    {
                        product *= AtoBmodC[i];
                    }
                    product = myMod(product, C);
                }
            }
            return myMod(product, C);
        }

        private long myMod(long A, long B)
        {
            //A=B*Q+R, where  0 <= R < B
            //A mod B = R
            //R= A-B*Q, Q=floor(A/B)
            return A - (long)((A / B) * B);
        }
    }
}
