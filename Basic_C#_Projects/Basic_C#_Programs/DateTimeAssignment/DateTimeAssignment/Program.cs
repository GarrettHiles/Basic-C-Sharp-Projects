using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //gets current date and time
            Console.ReadLine();

            Console.WriteLine("Please enter a number of hours to pass.");
            string input = Console.ReadLine();
            int hours = int.Parse(input); //switches the inputed string number to intger

            DateTime toCome = DateTime.Now.AddHours(hours); //made to come variable that adds the current date time plus the inputed number
            Console.WriteLine($"It will be {toCome} in {hours} hours.");//tells what the time will be to the console.
            Console.ReadLine();
               
        }
    }
}
