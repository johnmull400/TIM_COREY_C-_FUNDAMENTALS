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
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine().ToLower();
            string choice = "";

            // This loop will execute because the test variable choice is initialised to ""
            // Had the variable been intialised to "exit", this loop would not have executed but
            // The do while loop would have executed once until the variable was evaluated at the
            // bottom of the loop.
            while (choice != "exit")
            {
                if (name == "tim")
                {
                    Console.WriteLine("Hello Professor Tim");
                }
                else
                {
                    Console.WriteLine($"Hi, {name}");
                }

                Console.WriteLine("Type \"exit\" to end the program, (First loop)");
                choice = Console.ReadLine();
            }


            // This loop will execute at least once and then until the while 
            // condition is met.
            do
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine().ToLower();

                if (name == "tim")
                {
                    Console.WriteLine("Hello Professor Tim");
                }
                else
                {
                    Console.WriteLine($"Hi, {name}");
                }

                Console.WriteLine("Type \"exit\" to end the program, (Second loop)");
                choice = Console.ReadLine();   

            } while (choice != "exit");

        }
    }
}
