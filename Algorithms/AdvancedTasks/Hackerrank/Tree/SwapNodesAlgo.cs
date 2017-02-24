using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Algorithms.Attributes;

namespace Algorithms.AdvancedTasks.Hackerrank.Tree
{
    [DisplayInfo("Anvanced Tasks - Hackerrank", "Tree Swap Nodes Algo", typeof(List<int>))]
    class SwapNodesAlgo
    {
        public List<int> Go()
        {
            int[] ar = new[] {1};
            ReadingTestCases.ReadAllText();

            int N = Int32.Parse(ReadingTestCases.ReadLine());
            int n = 0;
            string[] nodesStr = new string[N];
            while (n < N)
            {
                nodesStr[n] = ReadingTestCases.ReadLine();
                n++;
            }

            Node root = new Node();
            root.Value = 1;
            root.Height = 1;
            int H = 1;
            List<string> l = nodesStr.ToList();
            l.Insert(0,"1");
            fillNodes(root, 1, l, H);
            H=GetHeight(root);
            int Kcount = Int32.Parse(ReadingTestCases.ReadLine());


            while (Kcount>0)
            {
                int k = Int32.Parse(ReadingTestCases.ReadLine());
                int i = 2;
                int p = k;
                while (p<=H)
                {
                    swap(root, p);
                    p = k*i;
                    i++;
                }
                traverseInOrder(root);
                Console.Write("\n");
                Kcount--;
            }
          
            return  new List<int>();
        }

        private int GetHeight(Node node)
        {
            if (node == null) return -1 ;
            return Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;
        }

        private void swap(Node node, int level)
        {
            if (node == null)
            {
                return;
            }
            if (node.Height == level)
            {
                Node n = node.Left;
                node.Left = node.Right;
                node.Right = n;
             
            }
            swap(node.Left, level);
            swap(node.Right, level);

        }

        private void traverseInOrder(Node node)
        {
            if (node.Left != null)
            {
                traverseInOrder(node.Left);
            }
            Console.Write(node.Value+ " ");
            if (node.Right != null)
            {
                traverseInOrder(node.Right);
            }
        }



        private static int fillNodes(Node node,  int n,  List<string> nodes, int h)
        {
            if (node.Value == -1)
            {
                return h;
            }
            if (n >= nodes.Count)
            {
                return h;
            }
            int H = h;
            int[] arr = nodes[n].Split(' ').Select(Int32.Parse).ToArray();
            if (arr[0] != -1)
            {
                Node l = new Node();
                l.Value = arr[0];
                l.Height = h + 1;
                node.Left = l;
                H = fillNodes(node.Left, arr[0], nodes, h+1);
            }
            if (arr[1] != -1)
            {
                Node r = new Node();
                r.Value = arr[1];
                r.Height = h + 1;
                node.Right = r;
                H = fillNodes(node.Right, arr[1], nodes, h+1);
            }

            return H;
        }

        class Node
        {
            public int Value;
            public Node Left;
            public Node Right;
            public int Height;
        }
    }
}
