using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    abstract class Person //The abstract class
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName(); //abstract method
    }

    
}
