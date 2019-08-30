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

            string[] firstNames = new string[5];

            Console.WriteLine("Please enter a comma separated list of first names.");
            string inputNames = Console.ReadLine().ToLower();

            firstNames = inputNames.Split(',');

            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine($"The name at element {i} in the array is {firstNames[i]}");
            }

            Console.WriteLine("Applicaton End.");

            Console.ReadLine(); 


        }
    }
}
