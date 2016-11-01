using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    class DisplayInfoAttribute:Attribute
    {
        public DisplayInfoAttribute(string nameTypeAlgorithms, string nameAlgorithms)
        {
           NameTypeAlgorithms = nameTypeAlgorithms;
            NameAlgorithm = nameAlgorithms;
        }

        public string NameTypeAlgorithms { get; }

        public string NameAlgorithm { get; }
    }
}
