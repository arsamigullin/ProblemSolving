using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Trees.BalancedTree.AVLTree
{
    interface IAVLTreeNode<T>
    {
        T BalancedFactor { get;}
        T Value { get; set; }
        IAVLTreeNode<T> LeftNode { get; set; }
        IAVLTreeNode<T> RightNode { get; set; }
    }
}
