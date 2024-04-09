using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee worker = new Employee //calling class and filling variables
            {
                FirsName = "Sample",
                LastName = "Student"
            };
            worker.SayName(); //calls method
            Console.ReadLine();
        }
    }
}
