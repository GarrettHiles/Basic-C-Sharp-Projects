using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameArray = { "Dave", "Scott", "Bob", "Lance", "Dot", "Mash" }; //Array of names
            Console.WriteLine("Please select a index of the Name Array: ");
            int select = int.Parse(Console.ReadLine()); //Changes the string choice into the int location

            if (select <= nameArray.Length)
            {
                Console.WriteLine($"Index Contains: {nameArray[select]}"); //says what the index contains
            }
            else
            {
                Console.WriteLine("That index does not exist. Select Again."); //nothing in this index
            }
            Console.ReadLine();




            int[] numArray = { 90, 29, 15, 60, 43, 34 };
            Console.WriteLine("Please select a index of the Number Array: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice <= numArray.Length) //says if the choice is less than or equal to do the following
            {
                Console.WriteLine($"Index contains: {numArray[choice]}"); //whatever number that has information in it's index
            }
            else
            {
                Console.WriteLine("There is no info for that index."); //if the user chooses a index with no information
            }
            Console.ReadLine();



            List<string> Stringlist = new List<string>(); //makes a list with a string data type
            Stringlist.Add("Cheeseburger");
            Stringlist.Add("Pizza");
            Stringlist.Add("Chicken Tenders");
            Stringlist.Add("Pb&j");
            Stringlist.Add("Fried Shrimp"); 

            Console.WriteLine("Please select a index of this String list"); 
            int decision = int.Parse(Console.ReadLine());
            
            if (decision <= Stringlist.Count) //in lists it's Count instead of Length
            {
                Console.WriteLine($"Index contains: {Stringlist[decision]}");
            }
            else
            {
                Console.WriteLine("No information in that list spot"); // for a choice that is too high of number
            }
            Console.ReadLine();
            
            
            
            





        }
    }
}
