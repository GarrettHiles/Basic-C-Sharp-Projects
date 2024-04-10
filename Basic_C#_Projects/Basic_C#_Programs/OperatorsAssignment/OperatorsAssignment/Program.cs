using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee worker1 = new Employee
            {
                Id = 1,
                FirstName = "Gary",
                LastName = "Hiles"

            };

            Employee worker2 = new Employee
            {
                Id = 2,
                FirstName = "Ryan",
                LastName = "Rohe"
            };

            if (worker1 == worker2)
            {
                Console.WriteLine("The employees have the same Id.");
            }
            else
            {
                Console.WriteLine("The employees have different Ids.");
            }
            Console.ReadLine();
                
        }
    }
}
