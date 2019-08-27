using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayVariablesUI
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 1, 9, 23, 16, 42, 56 };

            Console.WriteLine($"There are  {numbers.Count()}  items in the numbers array");
            Console.ReadKey();
            
            //output all the numbers in the array.
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            //now step through the array and output all the numbers on at a time.
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }

            // now allow the user to select which number they want to see 
            foreach (var item in numbers)
            {

                Console.WriteLine("Please select a number from 1 - 6");
                int selection = Convert.ToInt32(Console.ReadLine());
                if (selection < 7)
                {
                    Console.WriteLine($"The number at that position is: {numbers[(selection - 1)]}");
                }
                else Console.WriteLine("Number out of range. Please try again");


           }

            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
