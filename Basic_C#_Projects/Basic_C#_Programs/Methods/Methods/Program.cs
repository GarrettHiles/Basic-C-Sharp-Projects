using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace math = new //gives the class a new variable
            Trace(); //calls the class 

            int answer1 = math.PlusSeven(9); //first method where it just adds 7
            Console.WriteLine(answer1);
            Console.ReadLine();

            int answer2 = math.TimesTwo(68); //Second method multiplies by 2
            Console.WriteLine(answer2);
            Console.ReadLine();

            int answer3 = math.MinusEight(14); //Third method subtracts by 14
            Console.WriteLine(answer3);
            Console.ReadLine();

        }
    }
}
