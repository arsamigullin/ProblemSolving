using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.Trees.BinaryTree.BinaryTreeDescription;

namespace Algorithms.Trees.BinaryTree.BinaryTreeTraversal
{
    // inorder or symmetric traversal

    //    Unlike the preorder traversal, it’s unclear how you would defi ne an inorder
    //traversal for a tree with a degree greater than 2. You could defi ne it to mean
    //that the algorithm should process the fi rst half of a node’s children, and then
    //the node, and then the remaining children.That’s an atypical traversal, though.
    [DisplayInfo("Tree", "Binary - Inorder Traversal", typeof(List<string>))]
    public class InorderBinaryTreeTraversal
    {

        // Output A B C D E
        public List<string> Go()
        {
            TraverseInorder(TreeFactory.GetBinaryTreeWithHeight3());
            return new List<string>();
        }

        private void TraverseInorder(IBinaryNode<int> node)
        {
          
            if (node.LeftNode != null)
            {
                TraverseInorder(node.LeftNode);
            }
            Console.WriteLine(node.Name);
            if (node.RightNode != null)
            {
                TraverseInorder(node.RightNode);
            }
        }
    }
}
