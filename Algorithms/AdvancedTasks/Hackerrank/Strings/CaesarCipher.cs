using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Strings
{
    [DisplayInfo("Hackerrank - Strings", "Hackerrank - Caesar Cipher", typeof(List<string>))]
    class CaesarCipher
    {
        public List<string> Go(int [][] arr)
        {
            var t =arr[5][6];
            int[,] rotatedarr = new int[4,5];

            int strLen = 11;
            string s = "middle-Outz";
            int k = 2;
            k = k % 26;
            String encriptString = "";
            //The English alphabet contains characters with ascii values 65 to 90 for A to Z, and 97 to 122 for a to z. 
            //48 - 57 is for numbers (0 to 9).
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '-')
                {
                  
                    encriptString += s[i];
                    continue;
                }
                int numVal = 0;
                int lastIndLetter = 0;
                if (Char.IsLower(s[i]))
                {
                    lastIndLetter = 122;
                }
                if (Char.IsUpper(s[i]))
                {
                    lastIndLetter = 90;
                }
                numVal = s[i] + k;
                if (numVal > lastIndLetter)
                {
                    numVal = numVal - 26;
                }
                encriptString+=Char.ConvertFromUtf32((int)numVal);
            }
            //okffng-Qwvb
            return  new List<string>();
        }
    }
}
