﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Trees.BinaryTree.BinaryTreeDescription
{
    public interface IBinaryNode<T>
    {
        T Data { get; set;}
        IBinaryNode<T> LeftNode { get; set; }
        IBinaryNode<T> RightNode { get; set; }
        T Value { get; set; }
        T LowerBound(T target, T lastval);
        void AddNode(string name, T value);

    }
}
