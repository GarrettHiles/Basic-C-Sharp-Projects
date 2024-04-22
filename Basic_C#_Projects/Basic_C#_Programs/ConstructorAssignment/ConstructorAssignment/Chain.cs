using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Chain
    {
        public string Monkey { get; set; }

        public Chain(string name)
        {
            Monkey = name;
        }
        public Chain() : this("Gorilla") { }
    }
}
