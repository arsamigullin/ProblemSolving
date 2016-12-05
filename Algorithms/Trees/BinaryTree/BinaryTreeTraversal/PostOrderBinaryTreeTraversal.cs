using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.Trees.BinaryTree.BinaryTreeDescription;

namespace Algorithms.Trees.BinaryTree.BinaryTreeTraversal
{
    [DisplayInfo("Tree", "Binary - Inorder Traversal", typeof(List<string>))]
    public class PostOrderBinaryTreeTraversal
    {
        BinaryNode<string> root = new BinaryNode<string>("root");
        public PostOrderBinaryTreeTraversal()
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
            TraversePostorder(root);
            return new List<string>();
        }

        private void TraversePostorder(IBinaryNode<string> node)
        {

            if (node.LeftNode != null)
            {
                TraversePostorder(node.LeftNode);
            }
            Console.WriteLine(node.Name);
            if (node.RightNode != null)
            {
                TraversePostorder(node.RightNode);
            }
        }
    }
}
