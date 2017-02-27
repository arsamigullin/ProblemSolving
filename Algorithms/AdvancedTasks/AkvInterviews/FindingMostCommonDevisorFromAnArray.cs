using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks
{
    [DisplayInfo("Anvanced Tasks", "Finding Most Common Devisors in array", typeof(List<int>))]
    class FindingMostCommonDevisorFromAnArray
    {
        public List<int> Calculate()
        {
            int[] array = new[] { 4852,19866, 3004, 1618 };
            int gdc=0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (i == 0)
                {
                  gdc = GDC(array[i], array[i + 1]);    
                }
                else
                {
                    gdc = GDC(gdc, array[i + 1]);  
                }
                
            }
            return new List<int>{gdc};
        }

        private int GDC(int num1, int num2)
        {
            while (num2!=0)
            {
                int reminder = num1%num2;
                num1 = num2;
                num2 = reminder;
            }
            return num1;
        }
    }
}
