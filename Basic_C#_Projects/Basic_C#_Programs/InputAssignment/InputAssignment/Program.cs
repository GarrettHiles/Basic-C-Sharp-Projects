using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number"); //asks for user input
            string input = Console.ReadLine();
            int number = int.Parse(input); //changes the string to int

            string filepath = @"C:\Users\Garrett Hiles\OneDrive\Documents\GitHub\Tech-Academy-Projects\Basic_C#_Projects\Basic_C#_Programs\Text\input.txt"; //the path
            File.AppendAllText(filepath, number + Environment.NewLine); // takes the file path, inputed number, and makes a new line every time

            string[] lines = File.ReadAllLines(filepath); 
            foreach(string line in lines)//prints out each entry made in the text file
            {
                Console.WriteLine(line);
            }
            Console.Read();//shows the inputed numbers to the user
        }
    }
}
