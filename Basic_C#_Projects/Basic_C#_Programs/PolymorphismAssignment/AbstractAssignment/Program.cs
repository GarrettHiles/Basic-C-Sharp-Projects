using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee //instantiate employee object
            {
                FirstName = "Sample", //fill the variables
                LastName = "Student"
            };
            employee.SayName(); //calls method
            Console.ReadLine();

            IQuittable quittableEmployee = employee; //polymorphism to create IQuittable type object
            quittableEmployee.Quit(); //calls the quit method
            Console.ReadLine();
        }
    }
}
