using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.Trees;
using Algorithms.Trees.BinaryTree.BinaryTreeDescription;

namespace Algorithms.AdvancedTasks.AkvInterviews
{
    [DisplayInfo("Anvanced Tasks - FindingMinimalValueInBinaryTree", "Finding Minimal Value In Binary Tree", typeof(List<int>))]
    class FindingMinimalValueInBinaryTree
    {
        private IBinaryNode<int> root;
        public FindingMinimalValueInBinaryTree()
        {
            root = new BinaryNode<int>(7);
            root.LeftNode = new BinaryNode<int>(5);
            root.RightNode = new BinaryNode<int>(15);
            root.RightNode.LeftNode = new BinaryNode<int>(11);
        }
        public List<int> Go()
        {
            if (root == null)
                return new List<int>();

            int min = root.Value;
            var c = MinmalValue(root,  min);

            int rmin = root.Value;
            MinmalValue(root, ref rmin);

            return new List<int>();
        }

        private int MinmalValue(IBinaryNode<int> root, int min)
        {
            if(root == null) return min;
            min = Math.Min(min, root.Value);
            return Math.Min(MinmalValue(root.LeftNode, min), MinmalValue(root.RightNode, min));     
        }

        private void MinmalValue(IBinaryNode<int> root, ref int currentMin)
        {
            if (root == null) return;
            if (root.Value < currentMin)
                currentMin = root.Value;
            MinmalValue(root.LeftNode, ref currentMin);
            MinmalValue(root.RightNode, ref currentMin);
        }
    }
}
