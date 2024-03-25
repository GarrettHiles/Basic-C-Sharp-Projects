using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApprovalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, speedticket; //lists my variables and their types
            string ticket;
            bool havedui, dui;
            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine()); //converts from string to int
            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            ticket = Console.ReadLine();
            dui = Convert.ToBoolean(ticket); //Converts from string to boolean 

            Console.WriteLine("How many speeding tickets do you have?");
            speedticket = Convert.ToInt32(Console.ReadLine()); //Converts from string to int

            havedui = (age >=15 && dui == false  && speedticket <= 3); //Checks to see if age is greater than or equal to 15, if dui equals false, and sees if speeding ticket is under 3
            Console.WriteLine("Qualifed?");
            Console.ReadLine();
            Console.WriteLine(havedui); //writes results
            Console.ReadLine();


            
        }
    }
}
