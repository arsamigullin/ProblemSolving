using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.Trees;
using Algorithms.Trees.BinaryTree.BinaryTreeDescription;

namespace Algorithms.AdvancedTasks.AkvInterviews
{
    [DisplayInfo("Anvanced Tasks - Akvelon Interviews", "Decompose Trees And Compose It Again", typeof(List<int>))]
    class DecomposeTreesAndComposeItAgain
    {
        private IBinaryNode<int> root;
        public DecomposeTreesAndComposeItAgain()
        {
            root = new BinaryNode<int>(7);
            root.LeftNode = new BinaryNode<int>(5);
            root.RightNode = new BinaryNode<int>(15);
            root.RightNode.LeftNode = new BinaryNode<int>(11);
        }

        public List<int> Go()
        {
            IDictionary<int, NodeData<int>[]> nodeCollection = new Dictionary<int, NodeData<int>[]>();
            nodeCollection[-1] = new NodeData<int>[2];
            nodeCollection[-1][0] = new NodeData<int>(0, root.Value);

            int indexnode = 0;
            DecomposeTree(root, nodeCollection, ref indexnode);
            IBinaryNode<int> composedRoot = new BinaryNode<int>();
            ComposeTreeAgain(composedRoot, nodeCollection, -1);
            return new List<int>();
        }

        private void DecomposeTree(IBinaryNode<int> root, IDictionary<int, NodeData<int>[]> nodeDataCollection, ref int indexNode)
        {
            if (root == null) return;
            int parentIndex = indexNode;
            if (!nodeDataCollection.ContainsKey(indexNode))
            {
                nodeDataCollection[indexNode] = new NodeData<int>[2];
            }
            if (root.LeftNode != null)
            {
                indexNode++;
                nodeDataCollection[parentIndex][0] = new NodeData<int>(indexNode, root.LeftNode.Value);
                DecomposeTree(root.LeftNode, nodeDataCollection, ref indexNode);
            }

            if (root.RightNode != null)
            {
                indexNode++;
                nodeDataCollection[parentIndex][1] = new NodeData<int>(indexNode, root.RightNode.Value);
                DecomposeTree(root.RightNode, nodeDataCollection, ref indexNode);
            }
        }

        private void ComposeTreeAgain(IBinaryNode<int> root, IDictionary<int, NodeData<int>[]> nodeDataCollection, int indexNode)
        {
            if (!nodeDataCollection.ContainsKey(indexNode)) return;

            var nodes = nodeDataCollection[indexNode];
            if (indexNode == -1)
            {

                root.Value=nodes[0].Value;
                indexNode++;
                ComposeTreeAgain(root, nodeDataCollection, indexNode);
            }
            else
            {
                if (nodes[0].Index != 0)
                {
                    root.LeftNode = new BinaryNode<int>(nodes[0].Value);
                    ComposeTreeAgain(root.LeftNode, nodeDataCollection, nodes[0].Index);
                }
                if (nodes[1].Index != 0)
                {
                    root.RightNode = new BinaryNode<int>(nodes[1].Value);
                    ComposeTreeAgain(root.RightNode, nodeDataCollection, nodes[1].Index);
                }
            }

        }

        struct NodeData<T>
        {
            public int Index { get; set; }
            public T Value { get; set; }

            public NodeData(int index, T value)
            {
                Index = index;
                Value = value;
            }
        }
    }
}
