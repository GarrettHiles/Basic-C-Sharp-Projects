using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6part
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringarray = { "Frog", "Monkey", "Howard", "Duck" }; //part 1.

            Console.WriteLine("Please enter a string.");
            string userText = Console.ReadLine();

            for (int i = 0; i < stringarray.Length; i++)
            {
                stringarray[i] += userText;
            }

            foreach (string str in stringarray)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();

           
            
            
            
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());   // Part 2
            bool isguessed = number == 12;
            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again"); //Just reprints this statement
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());//with this line and the one above so it doesn't go one forever
                        break;

                    case 12:
                        Console.WriteLine("You guessed the right number");
                        isguessed = true; //this also stops the loop
                        break;

                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isguessed);

            Console.ReadLine();


           
            
            for (int i = 1; i < 10; i++) //Part 3
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            List<string> thislist = new List<string>() { "Funky", "Titan", "Stupid", "Ship", "Lost", "Failer" };

            while (true) //Part 4
            {
                Console.WriteLine("Enter the word you want to search for");
                string response = Console.ReadLine();

                int index = thislist.IndexOf(response);
                if (index != -1) //-1 wont be on the list therefore neither is the search item 
                {
                    Console.WriteLine($"'{response}' is found at index {index} in the list"); //if one of the list items is on the list it will display it's index 
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine($"'{response}' was not found on the list");
                }
            }



            List<string> listdos = new List<string>() { "Grape", "Apple", "Orange", "Grape", "Banana" }; //part 5

            Console.WriteLine("Search for a word in the list");
            string listitem = Console.ReadLine();

            List<int> matching = new List<int>();
            for (int i = 0; i < listdos.Count; i++)
            {
                if (listdos[i].Contains(listitem))
                {
                    matching.Add(i); //adds to other list
                }

            }

            if (matching.Count > 0)
            {
                Console.WriteLine($"Indices of items that match '{listitem}'");
                foreach (int index in matching)
                {
                    Console.Write($"{index} "); //writes the index of user input
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"No items containing '{listitem}' found in the list"); //item searched was not found
            }
            Console.ReadLine();

           
            
            
            List<string> listtres = new List<string>() { "Monkey", "Ant", "Oxe", "Monkey", "Bat", "Ant" }; //part 6

            Dictionary<string, int> amount = new Dictionary<string, int>(); //so it remembers the strings so it can locate if there is a copy

            foreach (string item in listtres)
            {
                if (amount.ContainsKey(item))
                {
                    Console.WriteLine($"'{item}' is a duplicate.");
                }
                else
                {
                    Console.WriteLine($"'{item}' is not a copy.");
                    amount[item] = 1; //if the item in the list is there only once
                }

            }
            Console.ReadLine();






        }
    }
}
