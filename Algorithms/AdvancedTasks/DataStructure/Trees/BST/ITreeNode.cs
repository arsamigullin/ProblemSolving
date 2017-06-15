using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AdvancedTasks.DataStructure.Trees.BST
{
    public interface ITreeNode<T> where T : IComparable<T>
    {
        ITreeNode<T> Left { get; set; }
        ITreeNode<T> Right { get; set; }
        void Add(T value);
        T Value { get; set; }
    }
}
