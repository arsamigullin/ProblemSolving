using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.Trees.BinaryTree.BinaryTreeDescription;

namespace Algorithms.Trees.BinaryTree
{
    [DisplayInfo("Tree", "BST - Checking To BST", typeof(List<string>))]
    public class CheckingToBst
    {
        private IBinaryNode<int> root;
        public CheckingToBst()
        {
             root = new BinaryNode<int>(8);

            root.LeftNode= new BinaryNode<int>(4);
            root.LeftNode.LeftNode = new BinaryNode<int>(2);
            root.LeftNode.LeftNode.LeftNode = new BinaryNode<int>(1);
            root.LeftNode.LeftNode.RightNode = new BinaryNode<int>(3);

            root.LeftNode.RightNode = new BinaryNode<int>(6);
            root.LeftNode.RightNode.LeftNode = new BinaryNode<int>(5);
            root.LeftNode.RightNode.RightNode = new BinaryNode<int>(7);

            root.RightNode = new BinaryNode<int>(13);
            root.RightNode.LeftNode= new BinaryNode<int>(10);
            root.RightNode.LeftNode.LeftNode = new BinaryNode<int>(9);
            root.RightNode.LeftNode.RightNode = new BinaryNode<int>(11);

            root.RightNode.RightNode = new BinaryNode<int>(14);
            root.RightNode.RightNode.LeftNode = new BinaryNode<int>(12);
            root.RightNode.RightNode.RightNode = new BinaryNode<int>(15);
        }
        public List<bool> CheckToBst()
        {
            bool res = check(root, Int32.MinValue, Int32.MaxValue);
            return  new List<bool> {res};
        }

        private bool check(IBinaryNode<int> roo, int min, int max)
        {
            if (roo == null) return true;
            if (roo.Data > min && roo.Data < max
                && check(roo.LeftNode, min, roo.Data)
                && check(roo.RightNode, root.Data, max))
            {
                return true;
            }
            return false;
        }
    }
}
