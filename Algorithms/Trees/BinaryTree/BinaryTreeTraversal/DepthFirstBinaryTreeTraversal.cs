using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.Trees.BinaryTree.BinaryTreeDescription;

namespace Algorithms.Trees.BinaryTree.BinaryTreeTraversal
{
    [DisplayInfo("Tree", "Binary - Depth-first Traversal", typeof(List<string>))]
    public class DepthFirstBinaryTreeTraversal
    {
        // Output D, B, E, A, C
        public List<string> Traverse()
        {
            BinaryNode<int> root = TreeFactory.GetBinaryTreeWithHeight3();
            Queue<IBinaryNode<int>> children = new Queue<IBinaryNode<int>>();

            children.Enqueue(root);

            while (children.Count!=0)
            {
                var node = children.Dequeue();
                // <Process node>
                Console.WriteLine(node.Name);
                if (node.LeftNode!=null) children.Enqueue(node.LeftNode);
                if (node.RightNode != null) children.Enqueue(node.RightNode);
            }

            return new List<string>();
        }

    }
}
