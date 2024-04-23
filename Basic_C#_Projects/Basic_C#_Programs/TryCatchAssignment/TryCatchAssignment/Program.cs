using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you?");
                int age = int.Parse(Console.ReadLine());//string to int

                if (age <= 0)
                {
                    Console.WriteLine("Positive number please."); //if they enter in a negitive number
                }
                else
                {
                    int yearborn = DateTime.Now.Year - age; //gets your estimated year born
                    Console.WriteLine($"You were born in {yearborn}"); 
                    Console.ReadLine();
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Age must be a number.");//if they try to enter their age as a word ex. Ten
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong"); //if anything else goes wrong
                Console.ReadLine();
            }
        }
    }
}
