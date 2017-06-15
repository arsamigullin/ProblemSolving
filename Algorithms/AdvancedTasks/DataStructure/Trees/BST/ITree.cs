using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AdvancedTasks.DataStructure.Trees.BST
{
    public interface ITree<T> where T: ITreeNode<T>, IComparable<T>
    { 
    }
}
