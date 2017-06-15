using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.LinkedList.SinglyLinkedList.SinglyCellDescription;
using Algorithms.Trees;
using Algorithms.Trees.BinaryTree.BinaryTreeDescription;

namespace Algorithms.LinkedList
{
    [DisplayInfo("LinkedListSingly", "Creating LinkedList From BST ", typeof(List<string>))]
    class CreatingLinkedListFromBST
    {
        private SinglyCell<int> linkedListNode = new SinglyCell<int>();
        public List<int> Go()
        {
            BinaryNode<int> root =new BinaryNode<int>(8);
            root.LeftNode = new BinaryNode<int>(3);
            root.RightNode = new BinaryNode<int>(10);
            root.LeftNode.LeftNode = new BinaryNode<int>(1);
            root.LeftNode.RightNode = new BinaryNode<int>(6);
            root.LeftNode.RightNode.LeftNode =new BinaryNode<int>(4);
            root.LeftNode.RightNode.RightNode = new BinaryNode<int>(7);
            root.RightNode.RightNode = new BinaryNode<int>(14);
            root.RightNode.RightNode.LeftNode = new BinaryNode<int>(13);
            var res = CreateLinkedListFromBST(root, linkedListNode);
            return  new List<int>();
        }

        private ISinglyCell<int> CreateLinkedListFromBST(IBinaryNode<int> root, ISinglyCell<int> linkedNode )
        {
            var currentNode = linkedNode;

            if (root.LeftNode != null)
                currentNode = CreateLinkedListFromBST(root.LeftNode, currentNode);

            var node = new SinglyCell<int>();
            node.Value = root.Value;
            currentNode.Next = node;
            currentNode = node;

            if (root.RightNode != null)
                CreateLinkedListFromBST(root.RightNode, currentNode);

            return currentNode;
        }
    }
}
