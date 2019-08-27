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
            // We ask the user for their age and then calculate how
            // old they were in the year 2000, or if they were even 
            // born. If they were not born, we tell them so, otherwise
            // we tell them thier age in 2000.

            // calculate the year difference betweem today and 2000.
            int difference =  DateTime.Now.Year - 2000;


            //Ask the user for their age and calculate the difference
            Console.WriteLine("Please enter your age");
            string ageText = Console.ReadLine();
            bool isValidAge = int.TryParse(ageText, out int age);
            if (isValidAge)
            {
                int result = age - difference;
                if (result <= 0)
                {
                    Console.WriteLine("You were not born in the year 2000");
                }
                else
                {
                    Console.WriteLine($"In the year 2000 you where {result} years of age");
                }
            }
            Console.ReadKey();
           
        }
    }
}
