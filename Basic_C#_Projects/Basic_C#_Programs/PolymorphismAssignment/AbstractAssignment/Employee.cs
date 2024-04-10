using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    class Employee : Person , IQuittable //inherits from Person and the interface
    {
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
        public void Quit() //implements the quit method
        {
            Console.WriteLine($"{FirstName} {LastName} has quit.");
        }
    }
}
