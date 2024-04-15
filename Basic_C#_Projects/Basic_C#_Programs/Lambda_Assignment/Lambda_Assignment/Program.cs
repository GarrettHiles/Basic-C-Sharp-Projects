using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Workers = new List<Employee> //list of workers with the employee class
            {
                new Employee { id = 1, FirstName = "Joe", LastName = "Schmow"},
                new Employee { id = 2, FirstName = "Jake", LastName = "Schmow"},
                new Employee { id = 3, FirstName = "Joe", LastName = "Jackson"},
                new Employee { id = 4, FirstName = "Dave", LastName = "Getta"},
                new Employee { id = 5, FirstName = "Fred", LastName = "Wilson"},
                new Employee { id = 6, FirstName = "Harold", LastName = "Scary"},
                new Employee { id = 7, FirstName = "Gray", LastName = "Nolan"},
                new Employee { id = 8, FirstName = "Freddy", LastName = "Alexander"},
                new Employee { id = 9, FirstName = "Joe", LastName = "Rollie"},
                new Employee { id = 10, FirstName = "Ryan", LastName = "Guy"}

            };

            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in Workers)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }


           List<Employee> joes1 = Workers.Where(f => f.FirstName =="Joe").ToList();


           List<Employee> wokers5 = Workers.Where(i => i.id > 5).ToList();
            


        }
    }
}
