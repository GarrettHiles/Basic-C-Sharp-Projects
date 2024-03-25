using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourlyrate, hours, salary; // defines varibles
            bool moneymaker;
            Console.WriteLine("Anonymous Income Comparison Program"); //says name of program
            Console.ReadLine();
            Console.WriteLine("Person 1"); //says to write person one
            Console.ReadLine();//displays person 1 as a string
            Console.WriteLine("Hourly Rate?");//asks for hourly rate
            hourlyrate = Convert.ToInt32(Console.ReadLine());//makes hourly rate a input and converts the string to a intger data type
            Console.WriteLine("Hours worked a week");
            hours = Convert.ToInt32(Console.ReadLine());// changes hours worked a week into a int from a string
            salary = hourlyrate * hours * 4 * 12;//takes inputs and multiplys for a yearly salary
            Console.WriteLine("Person 2");
            Console.ReadLine();
            int hourlyrate2, hours2, salary2; //repeats for person 2
            Console.WriteLine("Hourly Rate?");
            hourlyrate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked a week");
            hours2 = Convert.ToInt32(Console.ReadLine());
            salary2 = hourlyrate2 * hours2 * 4 * 12; //takes inputs and multiplys for a yearly salary

            Console.WriteLine("Annual salary of Person 1: \n" + salary); //displays salary 1
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2: \n" + salary2);//displays salary 2
            Console.ReadLine();

            Console.WriteLine("Does person 1 make more money than person 2?");
            Console.ReadLine();
            moneymaker = salary > salary2;//askes if salary 1 is greater than salary 2
            Console.WriteLine(moneymaker);
            Console.ReadLine();

        }
    }
}
