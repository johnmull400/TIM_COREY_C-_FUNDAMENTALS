using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World");

            // This will not send the cursor to the next line.
            Console.Write("Please enter your name: ");

            string myName = Console.ReadLine();

            Console.WriteLine("Hello " + myName);

            Console.WriteLine();

            Console.WriteLine("Press any key to end");

            Console.ReadKey();

            //INCIDENTALLY
            // Control + J will bring Intellisense back up
            // Double tab for code snippets

        }
    }
}
