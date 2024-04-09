using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 math = new Class1();

            math.Leroy(40, 13);
            Console.ReadLine();


            math.Leroy(num2: 11, num1: 33);

            Console.ReadLine();
        }
    }
}
