using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nameguess = false; 
            Console.WriteLine("Guess a name"); //takes input for name guess
            string name = Console.ReadLine();

            while (!nameguess) //loop for guessing the right name
            {
                switch (name)
                {
                    case "Payton":
                        Console.WriteLine("You guessed Payton. Try again");
                        Console.WriteLine("Guess a name");
                        name = Console.ReadLine();
                        break;

                    case "Ryan":
                        Console.WriteLine("You guessed Ryan. Try again");
                        Console.WriteLine("Guess a name");
                        name = Console.ReadLine();
                        break;

                    case "Gary":
                        Console.WriteLine("You guessed Gary. You're Right!");
                        nameguess = true; //makes it so that Gary is the right answer
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a name");
                        name = Console.ReadLine();
                        break;

                }
            }
            Console.ReadLine();

            Console.WriteLine("Guess a fruit");
            string fruit = Console.ReadLine(); //takes input for fruit guess
            bool fruitguess = fruit == "Grape"; //The fruit guess is wrong unless it's grape

            do
            {
                switch (fruit)
                {
                    case "apple":
                        Console.WriteLine("You guessed apple. Try again bro.");
                        Console.WriteLine("Guess a fruit");
                        fruit = Console.ReadLine();
                        break;
                    case "grape":
                        Console.WriteLine("You guessed grape. Good Job!");
                        fruitguess = true; //makes it so that the loop doesn't go on forever if guessed right
                        break;
                    case "orange":
                        Console.WriteLine("You guessed orange. Try again bro.");
                        Console.WriteLine("Guess a fruit");
                        fruit = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("You did not guess the right fruit."); //for any other fruit not listed
                        Console.WriteLine("Guess a fruit");
                        fruit = Console.ReadLine();
                        break;

                }
                
            }
            while (!fruitguess); //while the fruit guess is false.
            Console.ReadLine();


        } 
    }
}
