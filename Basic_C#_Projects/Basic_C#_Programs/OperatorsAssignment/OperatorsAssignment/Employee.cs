using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public static bool operator ==(Employee worker1, Employee worker2)
        {
            return worker1.Id == worker2.Id;
        }

        public static bool operator !=(Employee worker1, Employee worker2)
        {
            return !(worker1 == worker2);
        }




    }
}
