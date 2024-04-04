using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndIntegersAssogment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> number = new List<int>();
                number.Add(125);
                number.Add(135);
                number.Add(197);
                number.Add(721);
                number.Add(83);
                number.Add(436);

                Console.WriteLine("Choose a number to divide each in this list by.");
                int each = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < number.Count; i++) //a for to go through the list
                {
                    number[i] /= each; //divides each number
                }

                Console.WriteLine("Results: "); //To show results under
                Console.ReadLine();

                foreach (int num in number) //foreach loop to print each number
                {
                    Console.WriteLine(num);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Whole number please."); //if a string is entered
                return;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero"); // if they divide by zero
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //any other unforseen event
            }
            finally
            {
                Console.ReadLine(); //what to do after the catch block
            }


            
        }
    }
}
