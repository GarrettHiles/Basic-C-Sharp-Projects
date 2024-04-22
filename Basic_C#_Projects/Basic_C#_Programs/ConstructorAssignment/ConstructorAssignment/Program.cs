using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Always = "Here ";
            var any = "type of data type";

            Chain obj = new Chain("Chimp");

            Console.WriteLine("This plus " + obj.Monkey);
            Console.ReadLine();
        }
    }
}
