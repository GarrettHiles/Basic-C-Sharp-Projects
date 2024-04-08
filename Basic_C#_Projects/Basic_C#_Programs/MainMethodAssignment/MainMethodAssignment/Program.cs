using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            SameName math = new SameName();

            int result1 = math.Operation(2); //prints the methods
            Console.WriteLine(result1);
            Console.ReadLine();

            int result2 = math.Operation(86.83m); //knows which method to do based on input type like int, decimal, string.
            Console.WriteLine(result2);
            Console.ReadLine();

            int result3 = math.Operation("34");
            Console.WriteLine(result3);
            Console.ReadLine();


        }
    }
}
