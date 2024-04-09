using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Class1
    {
        public void inHalf(int num, out int result) 
        {
            result = num / 2;
            Console.WriteLine(result);
        }

        public void Upper(int num1, int num2, out int result)
        {
            result = num1 + num2;
        }

        public void Upper(int num1, int num2, int num3,  out int result) //overloaded method
        {
            result = num1 * num2 * num3;
        }

    }
}
