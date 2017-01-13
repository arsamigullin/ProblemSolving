using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Trees.Tries.TrieDescription
{
    public class TrieNode
    {
        public char Value { get; set; }
        public List<TrieNode> Children { get; set; }
        public TrieNode Parent { get; set; }
        public int Depth { get; set; }

        public bool isCompletedWord { get; set; }
        public int Count { get; set; }

        public TrieNode(char value, int depth, TrieNode parent)
        {
            Value = value;
            Children = new List<TrieNode>();
            Depth = depth;
            Parent = parent;
        }

        public bool IsLeaf()
        {
            return Children.Count == 0;
        }

        public TrieNode FindChildNode(char c)
        {
            foreach (var child in Children)
                if (child.Value == c)
                    return child;

            return null;
        }

        public void DeleteChildNode(char c)
        {
            for (var i = 0; i < Children.Count; i++)
                if (Children[i].Value == c)
                    Children.RemoveAt(i);
        }
    }
}
