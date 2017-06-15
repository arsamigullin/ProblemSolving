using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AdvancedTasks.DataStructure.Trees.BST
{
    public class BSTNode<T> : ITreeNode<T> where T : IComparable<T>
    {
        private ITreeNode<T> left;
        private ITreeNode<T> rigth;
        private T max;
        public ITreeNode<T> Left
        {
            get { return left; }

            set { left = value; }
        }
        public ITreeNode<T> Right
        {
            get { return rigth; }

            set { rigth = value; }
        }

        public void Add(T value)
        {
           
        }

        public T Value { get; set; }
    }
}
