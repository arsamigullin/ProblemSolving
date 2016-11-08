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
        public DisplayInfoAttribute(string nameTypeAlgorithms, string nameAlgorithms, Type returnType)
        {
           NameTypeAlgorithms = nameTypeAlgorithms;
           NameAlgorithm = nameAlgorithms;
            ReturnType = returnType;
        }

        public string NameTypeAlgorithms { get; set; }

        public string NameAlgorithm { get; set; }

        public Type ReturnType { get; set; }
    }
}
