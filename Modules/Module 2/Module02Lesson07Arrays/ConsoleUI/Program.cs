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
            string[] firstNames = new string[] {"Dave","Peter","Steve","Scott","Alan" };

            bool isValid = false;
            string continueYN = "N";
            int index = 0;

            do
            {
                continueYN = "n";

                Console.WriteLine("Please enter a number to return the name at that position");
                isValid = int.TryParse(Console.ReadLine(), out index);

                if (isValid)
                {
                    if (index < firstNames.Length)
                    {
                        Console.WriteLine($"The name at position {index} is {firstNames[index]}");
                        Console.WriteLine("Do you want to continue?, Please enter \"Y\" or \"N\"");
                        continueYN = Console.ReadLine().ToLower();
                    }
                    else
                    {
                        Console.WriteLine("The number you have entered is outside of the bounds of the array");
                    }

                }
                else
                {
                    Console.WriteLine("Error.The value you have entered is not an integer");
                }

               
            } while (isValid && continueYN == "y" && index <= firstNames.Length );

            Console.WriteLine("Application end.");
            Console.ReadLine();

        }
    }
}
