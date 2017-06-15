using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Trees.BinaryTree.BinaryTreeDescription;

namespace Algorithms.Trees
{
//  The number of branches B in a binary tree containing N nodes is B = N – 1.
//■ The number of nodes N in a perfect binary tree of height H is N = 2H+1 – 1.
//■ Conversely, if a perfect binary tree contains N nodes, it has a height of
//log2(N + 1) – 1.
//■ The number of leaf nodes L in a perfect binary tree of height H is L = 2H.
//Because the total number of nodes in a perfect binary tree of height H 
//is 2H+1 – 1, the number of internal nodes I is I = N – L = (2H+1 – 1) – 2H = 
//(2H+1 – 2H) – 1 = 2H × (2 – 1) – 1 = 2H – 1.
//■ This means that in a perfect binary tree, almost exactly half of the nodes are
//leaves and almost exactly half are internal nodes.More precisely, I = L – 1.
//■ The number of missing branches(places where a child could be added)
//M in a binary tree that contains N nodes is M = N + 1.
//■ If a binary tree has N0 leaf nodes and N2 nodes with degree 2, N0 = N2 + 1. 
//In other words, there is one more leaf node than nodes with degree 2.
    public class BinaryNode<T>:IBinaryNode<T> where T : IComparable
    {
        public T Data { get; set; }
        public IBinaryNode<T> LeftNode { get; set; }
        public IBinaryNode<T> RightNode { get; set; }
        public T Value { get; set; }
        public void AddNode(string name, T new_value)
        {
            if (new_value.CompareTo(Value) < 0)
            {
                if (LeftNode == null)
                {
                    LeftNode= new BinaryNode<T>(new_value);
                    LeftNode.Value = new_value;
                }
                else
                {
                    LeftNode.AddNode(name, new_value);
                }
            }
            else
            {
                if (RightNode == null)
                {
                    RightNode= new BinaryNode<T>(new_value);
                    RightNode.Value = new_value;
                }
                else
                {
                    RightNode.AddNode(name, new_value);
                }
            }
        }

        public T LowerBound(T val, T lastval)
        {
            int cmp = val.CompareTo(Value);
            if (cmp < 0)
            {
                if (LeftNode == null)
                {
                    return lastval;
                }
                lastval = LeftNode.Value;
               return LeftNode.LowerBound(val, lastval);
            }
            else if (cmp>0)
            {
                if (RightNode == null)
                {
                    return lastval;
                }
                lastval = RightNode.Value;
                return RightNode.LowerBound(val, lastval);
            }
            return val;
        }

        public BinaryNode(T data)
        {
            Data = data;
        }

        public BinaryNode()
        {
            
        }
    }
}
