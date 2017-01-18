using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Tree
{
    [DisplayInfo("Anvanced Tasks - Hackerrank", "Tree Swap Nodes Algo", typeof(List<int>))]
    class SwapNodesAlgo
    {
        public List<int> Go()
        {
            int N = Int32.Parse(Console.ReadLine());
            int n = 0;
            string [] nodesStr = new string[N];
            while (n < N)
            {
                nodesStr[n] = Console.ReadLine();
                n++;
            }
            Node root = new Node();
            root.Value = 1;

            int [] nodes = nodesStr.SelectMany(x => x.Split(' ')).Select(Int32.Parse).ToArray();
            if (nodes.Length > 3)
            {
                root.Left = new Node();
                root.Value = nodes[0];
                root.Right = new Node();
                root.Value = nodes[1];
            }
            for (int i = 0; i < nodesStr.Length; i += 2)
            {
                nodesStr[i] = Console.ReadLine();
                //  fillNodes(root, ref n);
            }
            fillNodes(root, ref n);
            return  new List<int>();
        }

        private static void fillNodes(Node node, ref int n)
        {
            n--;
            if (n == 0) return;
            int[] childs = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            if (childs[0] != -1)
            {
                node.Left = new Node();
                node.Left.Value = childs[0];
                fillNodes(node.Left, ref n);
            }
            if (childs[1] != -1)
            {
                node.Right = new Node();
                node.Right.Value = childs[1];
                fillNodes(node.Right, ref n);
            }
        }

        class Node
        {
            public int Value;
            public Node Left;
            public Node Right;
        }
    }
}
