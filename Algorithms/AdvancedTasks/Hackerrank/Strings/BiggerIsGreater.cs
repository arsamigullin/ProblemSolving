using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Strings
{
    [DisplayInfo("Anvanced Tasks - Hackerrank", "Bigger Is Greater", typeof(List<int>))]
    class BiggerIsGreater
    {
        public List<int> main()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */

            ReadingTestCases.ReadAllText();
            int n = Int32.Parse(ReadingTestCases.ReadLine());

            for (int i = 0; i < n; i++)
            {
                String s = ReadingTestCases.ReadLine();
                sortNext(s);
            }
            return new List<int>();
        }

        void sortNext(String s)
        {
            char[] strArr = s.ToCharArray();

            if (s.Length == 1)
            {
                Console.WriteLine("no answer");
                return;
            }
            bool swap = false;
            for (int i = 0; i < strArr.Length; i++)
            {

                if (i + 1 < strArr.Length && strArr[i + 1] > strArr[i])
                {
                    continue;
                }
                else if (i + 1 < strArr.Length && strArr[i + 1] <= strArr[i])
                {
                    int g = strArr.Length - 2;
                    while (!swap && g >= 0)
                    {
                        swap = swapdo(strArr, g);

                        g--;
                    }
                    if (swap == false)
                    {
                        Console.WriteLine("no answer");
                        return;
                    }


                }
                if (swap == false)
                {
                    int temp = strArr[strArr.Length - 1];
                    strArr[strArr.Length - 1] = strArr[strArr.Length - 2];
                    strArr[strArr.Length - 2] = (char)temp;

                    String finalStr = new String(strArr);
                    if (!s.Equals(finalStr))
                        Console.WriteLine(finalStr);
                    else
                        Console.WriteLine("no answer");
                    return;
                }
                else
                {

                    Console.WriteLine(new String(strArr));
                    return;
                }
            }


        }

        bool swapdo(char[] arr, int i)
        {
            //System.out.println(arr[i]);
            int max = 0;
            int val = arr[i];
            int maxPos = -1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] > val)
                {
                    if (arr[j] < max)

                    { max = arr[j]; maxPos = j; }
                    else if (max == 0)
                    {
                        max = arr[j];
                        maxPos = j;
                    }
                }
            }

            if (max > 0)
            {
                //System.out.println("max-"+(char)max);
                arr[i] = (char)max;
                arr[maxPos] = (char)val;
                //System.out.println(Arrays.toString(arr));
            }
            else
            {
                return false;
            }
            int temp = 0;
            int n = arr.Length;
            for (int k = i + 1; k < n; k++)
            {
                for (int l = i + 2; l < n; l++)
                {

                    if (arr[l - 1] > arr[l])
                    {
                        //swap the elements!
                        temp = arr[l - 1];
                        arr[l - 1] = arr[l];
                        arr[l] = (char)temp;
                    }

                }
            }

            // System.out.println(Arrays.toString(arr));
            return true;
        }
    }
}
