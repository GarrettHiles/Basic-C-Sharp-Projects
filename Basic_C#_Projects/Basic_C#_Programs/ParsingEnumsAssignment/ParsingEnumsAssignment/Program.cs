using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day of the week:");

            try
            {
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine()); //sees if entered value matches any of the values in the enum
                Console.WriteLine($"The day is {day}");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day in the week."); //if they don't enter in a matching input somewhere in the enum
            }
            Console.ReadLine();


        }
    }
}
