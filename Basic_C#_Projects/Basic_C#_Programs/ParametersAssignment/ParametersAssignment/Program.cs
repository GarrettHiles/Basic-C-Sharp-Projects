using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employ1 = new Employee<string> //makes the list inside a string and makes new employee object
            {
                Id = 1,
                FirstName = "Gary",
                LastName = "Hiles",
                things = new List<string> { "Playstation", "Xbox", "Pc" } //values for the lsit
            };

            Employee<int> employ2 = new Employee<int> //makes the list inside use the int data type 
            {
                Id = 2,
                FirstName = "Payton",
                LastName = "Schmitt",
                things = new List<int> { 5, 10, 15, 20 }
            };

            foreach (var thing in employ1.things) //just prints every item in the things list from the first employee
            {
                Console.WriteLine(thing);
            }

            foreach (var thing in employ2.things)//prints each int in the things list from employee two
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();


        }
    }
}
