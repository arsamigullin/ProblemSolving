using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList;

namespace Algorithms.AdvancedTasks
{
    [DisplayInfo("Anvanced Tasks", "AntiArithmetic", typeof(List<int>))]
    [System.Runtime.InteropServices.Guid("80C42F9C-94A7-4276-AAF1-890F33C2C66A")]
    public class AntiArithmetic
    {
        public List<int> Go()
        {
            int countnumber = 0;
            int[] array = new int[0];
            
            while (true)
            {
                string tokenVal = Console.ReadLine();
                if (tokenVal.Trim() == "0")
                {
                    return new List<int>();
                }
                string[] split = tokenVal.Split(new char[] {':'}, StringSplitOptions.None);
                countnumber = Int32.Parse(split[0]);
                split = split[1].Trim().Split(new char[] {' '}, StringSplitOptions.None);
                array = split.Select(Int32.Parse).ToArray(); //Array.ConvertAll(split, int.Parse);
                bool res = check(array, countnumber);
                Console.WriteLine(res ? "no" : "yes");
            }
        }
        // 0 5 8 3 1 45 - is wrong
        private bool check(int[] array, int countNumber)
        {
            int [] map = new int[countNumber];
            // fill map
            for (int i = 0; i < array.Length; i++)
            {
                map[array[i]] = i;
            }
            int arrayLength = array.Length;

            for (int j = 0; j < arrayLength - 1; j++)
            {
                for (int i = j + 1; i < arrayLength; i++)
                {
                    int d = array[i] - array[j];
                    int toFind = array[j] + d *2;
                    if (toFind>=0 && toFind<countNumber && map[toFind] > i)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }

   
}



