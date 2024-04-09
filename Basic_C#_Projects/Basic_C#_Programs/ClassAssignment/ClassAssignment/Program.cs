using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 div = new Class1();
            Console.WriteLine("Enter a number to be divided by 2: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int result;

            div.inHalf(input, out result); //calls divide by 2 method
            Console.WriteLine(result);
            Console.ReadLine();


            //overloaded method with out parameters
            div.Upper(5, 5, out result);
            Console.WriteLine(result);
            Console.ReadLine();

            div.Upper(3, 3, 3, out result);
            Console.WriteLine(result);
            Console.ReadLine();

        }
        
    }
}
