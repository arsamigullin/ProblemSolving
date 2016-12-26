﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Trees.BinaryTree.BinaryTreeDescription
{
    public interface IBinaryNode<T>
    {
        string Name { get; set;}
        IBinaryNode<T> LeftNode { get; set; }
        IBinaryNode<T> RightNode { get; set; }
        T Value { get; set; }

        void AddNode(string name, T value);

    }
}
