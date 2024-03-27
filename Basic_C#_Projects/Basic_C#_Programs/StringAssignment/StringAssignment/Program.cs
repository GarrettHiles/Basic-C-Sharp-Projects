using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string man, lady, baby;
            man = "This is a ";
            lady = "joined together ";
            baby = "sentence";
            string family = man + lady + baby; //joins variables into one sentence
            Console.WriteLine(family);
            Console.ReadLine();


            string up = "uppercase.";
            up = up.ToUpper(); //turns whatever value in up and makes it uppercase.
            Console.WriteLine(up); 
            Console.ReadLine();

            StringBuilder build = new StringBuilder();
            build.Append("This is the first sentence.\n"); //builds a paragraph one sentence at time
            build.Append("This is the second sentence.\n");
            build.Append("This is the third sentence.\n");

            Console.WriteLine(build);
            Console.ReadLine();

        }
    }
}
