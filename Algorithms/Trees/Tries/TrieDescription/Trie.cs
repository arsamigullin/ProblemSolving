using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Trees.Tries.TrieDescription
{
    public class Trie
    {
        private readonly TrieNode _root;

        public Trie()
        {
            _root = new TrieNode('^', 0, null);
        }

        public TrieNode Prefix(string s)
        {
            var currentNode = _root;
            var result = currentNode;

            foreach (var c in s)
            {
                currentNode = currentNode.FindChildNode(c);
               
                if (currentNode == null)
                {
                    break;
                }
                else
                {
                    currentNode.Count++;
                }
                   
                result = currentNode;
            }
            return result;
        }

        public TrieNode fnd(string s)
        {
            var currentNode = _root;
            var result = currentNode;

            foreach (var c in s)
            {
                currentNode = currentNode.FindChildNode(c);
                if (currentNode == null)
                {
                    return null;
                }

                result = currentNode;
            }
            return result;
        }

       int getCnt(TrieNode child,  int cnt)
        {
            if (child == null)
            {
                return cnt;
            }
            if (child.isCompletedWord)
            {
                cnt++;
            }
            foreach (var chld in child.Children)
            {
                cnt = getCnt(chld,  cnt);
            }
            return cnt;
        }

        public int Search(string s)
        {
            var prefix = fnd(s);
            int cnt = 0;
            if (prefix != null)
            {
                cnt = prefix.Count; // getCnt(prefix, cnt);
            }
            return cnt; // && prefix.FindChildNode('$') != null;
        }


        public void Insert(string s)
        {
            var commonPrefix = Prefix(s);
            var current = commonPrefix;

            for (var i = current.Depth; i < s.Length; i++)
            {
                var newNode = new TrieNode(s[i], current.Depth + 1, current);
                newNode.Count++;
                current.Children.Add(newNode);
                current = newNode;
            }
            current.isCompletedWord = true;
            //current.Children.Add(new TrieNode('$', current.Depth + 1, current));
        }

        public void Delete(string s)
        {
            //if (Search(s))
            //{
            //    var node = Prefix(s).FindChildNode('$');

            //    while (node.IsLeaf())
            //    {
            //        var parent = node.Parent;
            //        parent.DeleteChildNode(node.Value);
            //        node = parent;
            //    }
            //}
        }

    }
}
