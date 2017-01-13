using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.Trees.BinaryTree.BinaryTreeTraversal;

namespace Algorithms.Trees.BinaryTree.OperatingBinaryTree
{
    [DisplayInfo("Tree", "Binary Sorted - Adding Nodes To Existing Tree", typeof(List<string>))]
    public class AddingNodesSortedOrderToBinaryTree
    {
        private BinaryNode<int> root = TreeFactory.GetBinaryTreeWithHeight3();

        public List<string> AddNodes()
        {
            int[] values = new[] {6,9,8,7};

            foreach (int value in values)
            {
                root.AddNode(value.ToString(), value);
            }

            PostOrderBinaryTreeTraversal p = new PostOrderBinaryTreeTraversal();
            p.TraversePostorder(root);
            return new List<string>();
        }
    }
}
