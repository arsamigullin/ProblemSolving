using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.Trees.BinaryTree.BinaryTreeDescription;

namespace Algorithms.Trees.BinaryTree.BinaryTreeTraversal
{
    //Like the preorder traversal, you can easily defi ne a postorder traversal for trees with a degree greater than 
    //    2. The algorithm should visit all of a node’s children before visiting the node itself.

    [DisplayInfo("Tree", "Binary - Inorder Traversal", typeof(List<string>))]
    public class PostOrderBinaryTreeTraversal
    {
        // Output A C B E D
        public List<string> Go()
        {
            TraversePostorder(TreeFactory.GetBinaryTreeWithHeight3());
            return new List<string>();
        }

        public void TraversePostorder(IBinaryNode<int> node)
        {

            if (node.LeftNode != null)
            {
                TraversePostorder(node.LeftNode);
            }
            //Console.WriteLine(node.Data);
            if (node.RightNode != null)
            {
                TraversePostorder(node.RightNode);
            }
            Console.WriteLine(node.Data);
        }
    }
}
