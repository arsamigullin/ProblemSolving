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
        BinaryNode<string> root = new BinaryNode<string>("root");
        public InorderBinaryTreeTraversal()
        {

            BinaryNode<string> node1 = new BinaryNode<string>("node1");
            BinaryNode<string> node2 = new BinaryNode<string>("node2");
            BinaryNode<string> node3 = new BinaryNode<string>("node3");
            BinaryNode<string> node4 = new BinaryNode<string>("node4");
            BinaryNode<string> node5 = new BinaryNode<string>("node5");
            BinaryNode<string> node6 = new BinaryNode<string>("node6");
            BinaryNode<string> node7 = new BinaryNode<string>("node7");
            BinaryNode<string> node8 = new BinaryNode<string>("node8");
            BinaryNode<string> node9 = new BinaryNode<string>("node9");

            root.LeftNode = node1;
            root.RightNode = node2;
            node1.LeftNode = node3;
            node1.RightNode = node4;
            node4.LeftNode = node5;
            node2.LeftNode = node6;
            node2.RightNode = node7;
            node6.RightNode = node8;
            node7.RightNode = node9;
        }

        public List<string> Go()
        {
            TraverseInorder(root);
            return new List<string>();
        }

        private void TraverseInorder(IBinaryNode<string> node)
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
