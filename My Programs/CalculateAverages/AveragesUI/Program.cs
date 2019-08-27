using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AveragesUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opening message asking the user to enter a number
            Boolean r = false;
            string response = "N";
            int iterations = 3;

            // Use double as default for numbers that need fractions
            // Use decimal for money
            double myTotal = 0.00;
            double myAverage = 0.00;

            while (r == false)
            {

                Console.WriteLine("Are you ready? Please enter Y or N");

                response = Console.ReadLine();

                if (response.ToUpper() != "Y")
                {
                    r = false;
                }
                else r = true;
            }

            //Ask for the next number until 4 more entered
            Console.WriteLine("Welcome to the averages program, please enter the first number");
            myTotal += Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= iterations; i++)
            {
                Console.WriteLine("Please enter the next number");

                myTotal += Convert.ToInt32(Console.ReadLine());

            }

            myAverage = (myTotal / (iterations +1));
            // out of the loop, calculate the mean averege
            Console.WriteLine("The total that you have input is " + myTotal.ToString());

            Console.WriteLine("The mean average of this is " + String.Format("{0:## }", myAverage).ToString());

            // Try to force decimal places - didnt work
            myAverage += 0.21;
            Console.WriteLine("Average after decimal addition " + String.Format("{0:## }", myAverage).ToString());

            Console.WriteLine("Press any key to continue");

            Console.ReadKey();


        }
    }
}
