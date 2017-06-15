using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Trees;
using Algorithms.Trees.BinaryTree.BinaryTreeDescription;

namespace Algorithms.AdvancedTasks.DataStructure.Trees.BST
{
    public class Tree<T> where T: IComparable<T>
    {
        private T max;
        public ITreeNode<T> Root { get; set; }
        public T Max { get { return max; } }

        public Tree()
        {

        }

        public void Add(T value)
        {
            int rescmp = value.CompareTo(max);
            if (rescmp >= 0)
            {
                max = value;
            }
            if (Root == null)
            {
                Root = new BSTNode<T>();
                Root.Value = value;
                return;
            }
            ITreeNode<T> node = Root;
            while (node!=null)
            {
                rescmp = node.Value.CompareTo(value);
                if (rescmp > 0)
                {
                    if (node.Left == null)
                    {
                        node.Left = new BSTNode<T>();
                        node.Left.Value = value;
                        return;
                    }
                    node = node.Left;
                }
                else
                {
                    if (node.Right == null)
                    {
                        node.Right = new BSTNode<T>();
                        node.Right.Value = value;
                        return;
                    }
                    node = node.Right;
                }
            }


        }

        public T LowerBound(T value)
        {
            ITreeNode<T> node = Root;
            T lastBound= default(T);
            while (node!=null)
            {
                int rescmp = node.Value.CompareTo(value);
                if (rescmp == 0) return value;
                if (rescmp > 0)
                {
                    lastBound = node.Value;
                    if (node.Left != null)
                    {
                        node = node.Left;
                        continue;
                    }
                    return lastBound;
                }
                else
                {
                   
                    if (node.Right != null)
                    {
                        node = node.Right;
                        continue;
                    }
                    return lastBound;
                }
            }
            return lastBound;
        }
    }
}
