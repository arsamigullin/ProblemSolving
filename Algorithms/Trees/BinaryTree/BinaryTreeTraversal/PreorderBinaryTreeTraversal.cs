using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.Trees.BinaryTree.BinaryTreeDescription;

namespace Algorithms.Trees.BinaryTree.BinaryTreeTraversal
{
    //you can also defi ne a preorder
    //traversal for trees of higher degrees
    [DisplayInfo("Tree", "Binary - Preorder Traversal", typeof(List<string>))]
    public class PreorderBinaryTreeTraversal
    {
        // Output D B A C E
        public List<string> Go()
        {
            TraversePreorder(TreeFactory.GetBinaryTreeWithHeight3());
            return new List<string>();
        }

        private void TraversePreorder(IBinaryNode<int> node)
        {
            Console.WriteLine(node.Data);
            if (node.LeftNode != null)
            {
                TraversePreorder(node.LeftNode);
            }
            if (node.RightNode != null)
            {
                TraversePreorder(node.RightNode);
            }
        }
    }
}
