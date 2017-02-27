using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Trees.BalancedTree.AVLTree
{
    class AVLTreeNode : IAVLTreeNode<int>
    {
        public int BalancedFactor => GetHeight(LeftNode) + GetHeight(RightNode);

        private int GetHeight(IAVLTreeNode<int> node)
        {
            if (node == null) return -1;
            return Math.Max(GetHeight(node.LeftNode), GetHeight(node.RightNode)) + 1;
        }

        public IAVLTreeNode<int> LeftNode { get; set; }

        public IAVLTreeNode<int> RightNode { get; set; }
       

        public int Value { get; set; }

    }
}
