using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    class Program
    {
        struct Number
        {
            public decimal Amount { get; set; } //makes amount a data type decimal variable
        }

        static void Main(string[] args)
        {
            Number a = new Number { Amount = 209.32m }; //amount assigned to a.Amount 
            Console.WriteLine(a.Amount);
            Console.ReadLine();
        }

    }
}
