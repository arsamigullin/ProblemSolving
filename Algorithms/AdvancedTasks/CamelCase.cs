using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks
{
    [DisplayInfo("Anvanced Tasks", "HacherRank - Camel Case", typeof(List<int>))]
    class CamelCase
    {
        public List<int> Go()
        {
            string s = "saveChangesInTheEditor";
            string res=String.Join("", s.Where(Char.IsUpper));
            return new List<int> {res.Length+1};
        }
    }
}
