using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight, height, length, width, product, quote; //all of the variables I use

            Console.WriteLine("Welcome to Package Express. Please follow the intructions below.");
            Console.ReadLine();

            Console.WriteLine("What is the packages weight?"); //asks for the weight and converts it from a string to a int
            weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50) //if the package weights more than 50 it's to big to be shipped
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            
            Console.WriteLine("What is your packages width"); //gets the width
            width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your packages height?");//gets the hight
            height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your packages length?");// gets the length
            length = Convert.ToInt32(Console.ReadLine());

            if (width > 50 & height > 50 & length > 50) //if any of the measurements are over 50 it's too big.
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            product = length * width * height; //gets the product
            quote = product * weight / 100;//gets the price to ship
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00 \n Thank you!"); //message that thanks the user and shows what they would owe in usd.
            Console.ReadLine();
        }
    }
}
