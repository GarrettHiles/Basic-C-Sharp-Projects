using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine(); // writes above
            Console.WriteLine("Daily Report");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine(); // save what you write back into a string variable
            Console.WriteLine(" What course are you on?");
            string cuurentcourse = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string pagenumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pagenumber);// converts saved varuable, the string number, into a integer
            Console.WriteLine("Do you need help with anything? please answer true or false");
            string tf = Console.ReadLine(); //a string bc it says please answer true or false
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string postexpierence = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hourstudy = Console.ReadLine();
            int hourStudy = Convert.ToInt32(hourstudy); //Converts the number of hours in string to int
            Console.WriteLine("Thank you for your answers. and instructor will respond to this shortly. Have a Great day!");
            Console.ReadLine();

        }
    }
}
