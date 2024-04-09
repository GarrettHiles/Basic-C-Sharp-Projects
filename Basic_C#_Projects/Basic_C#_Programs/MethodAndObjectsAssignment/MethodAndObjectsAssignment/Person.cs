using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjectsAssignment
{
    class Person
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine($"Name: {FirsName} {LastName}");
        }
    }

    class Employee : Person
    {
        public int id { get; set; }
    }
}
