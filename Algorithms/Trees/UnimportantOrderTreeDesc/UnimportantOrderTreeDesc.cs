using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Trees.BinaryTree.UnimportantOrderTreeDesc
{
    public class UnimportantOrderTreeDesc
    {
        public string Name { get; set; }

        List<UnimportantOrderTreeDesc> Children = new List<UnimportantOrderTreeDesc>();

        public UnimportantOrderTreeDesc(string name)
        {
            Name = name;
        }
    }
}
