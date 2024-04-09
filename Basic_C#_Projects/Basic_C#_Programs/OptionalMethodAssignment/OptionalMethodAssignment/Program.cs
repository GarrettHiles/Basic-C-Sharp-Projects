using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Way math = new Way();

            Console.WriteLine("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine()); //gets first number
            Console.WriteLine("Enter another number (not required): "); //2nd number not required
            string input = Console.ReadLine();

            int num2 = 0;
            if (!string.IsNullOrEmpty(input)) //for if they don't enter in optional number
            {
                num2 = int.Parse(input);
            }

            int result = math.Math(num1, num2); //calls method
            Console.WriteLine(result);
            Console.ReadLine();



        }
    }
}
