using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Algorithms.Trees.Tries.TrieDescription;

namespace Algorithms.AdvancedTasks.Hackerrank.Tries
{
    [DisplayInfo("Anvanced Tasks Hackerrank", "Tries : Contact List", typeof(List<bool>))]
    class ContactList
    {
        public List<bool> Go()
        {
            string s = "hack";
            Trie t = new Trie();
            t.Insert(s);
            t.Insert("hackerrank");
            int p = t.Search("hac");
            return new List<bool>();
        }
    }
}
