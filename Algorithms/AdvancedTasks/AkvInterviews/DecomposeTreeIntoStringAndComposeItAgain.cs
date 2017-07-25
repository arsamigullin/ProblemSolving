using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.Trees;
using Algorithms.Trees.BinaryTree.BinaryTreeDescription;

namespace Algorithms.AdvancedTasks.AkvInterviews
{
    [DisplayInfo("Anvanced Tasks - Akvelon Interviews", "Decompose Trees Into a String And Compose It Again", typeof(List<int>))]
    class DecomposeTreeIntoStringAndComposeItAgain
    {
        private IBinaryNode<int> root;
        public DecomposeTreeIntoStringAndComposeItAgain()
        {
            root = new BinaryNode<int>(7);
            root.LeftNode = new BinaryNode<int>(5);
            root.LeftNode.LeftNode = new BinaryNode<int>(3);
            root.LeftNode.RightNode = new BinaryNode<int>(4);
            root.LeftNode.RightNode.LeftNode = new BinaryNode<int>(18);
            root.RightNode = new BinaryNode<int>(15);
            root.RightNode.LeftNode = new BinaryNode<int>(10);
            root.RightNode.RightNode = new BinaryNode<int>(11);
            root.RightNode.LeftNode.LeftNode = new BinaryNode<int>(14);
        }

        public List<int> Go()
        {
            string s = "";
            var res = DecomposeTreeIntoString(root);
            var node = ComposeTreeToString(res);
            return new List<int>();
        }

        string DecomposeTreeIntoString(IBinaryNode<int> root)
        {
            if (root == null)
            {
                return "x";
            }
            var leftres = DecomposeTreeIntoString(root.LeftNode);
            var rightres = DecomposeTreeIntoString(root.RightNode);
            string res;
            if (leftres == "x" && rightres == "x")
            {
                res = "#";
            }
            else
            {
                res = leftres + " " + rightres + " #";
            }
            return root.Value + " " + res;
        }

        IBinaryNode<int> ComposeTreeToString(string s)
        {
            Stack<IBinaryNode<int>> stack = new Stack<IBinaryNode<int>>();
            IBinaryNode<int> composedNode;
            string[] arr = s.Split(' ');
            bool needToAddLeft = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == "x")
                {
                    needToAddLeft = false;
                    continue;
                }
                if (arr[i] == "#")
                {
                    stack.Pop();
                    needToAddLeft = false;
                    continue;
                }
                composedNode = new BinaryNode<int>(Convert.ToInt32(arr[i]));
                if (stack.Count > 0)
                {
                    var lastNode = stack.Peek();
                    if (needToAddLeft)
                    {
                        lastNode.LeftNode = composedNode;
                    }
                    else
                    {
                        lastNode.RightNode = composedNode;
                        needToAddLeft = true;
                    }
                }
                stack.Push(composedNode);
             
            }
            return stack.Pop();
        }

    }
}
