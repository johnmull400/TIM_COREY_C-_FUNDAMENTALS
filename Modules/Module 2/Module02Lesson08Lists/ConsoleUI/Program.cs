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
            List<string> classNames = new List<string>();

            classNames.Add("Sue");
            classNames.Add("Paul");
            classNames.Add("Valerie");
            classNames.Add("Geoff");
            classNames.Add("Raul");
            classNames.Add("Alice");


            for (int i = 0; i < classNames.Count; i++)
            {
                Console.WriteLine($"The name at element {i} is {classNames[i]}" );
            }

            Console.WriteLine($"There are {classNames.Count} students in the class.");
            Console.WriteLine();

            int counter = 0;

            foreach (var i in classNames)
            {
                Console.WriteLine(classNames[counter]);
                counter++;
            }

            Console.WriteLine($"There are {counter} students in the class. ");
            Console.WriteLine();

            classNames.Sort();

            counter = 0;
            do
            {
                Console.WriteLine(classNames[counter]);
                counter++;

            } while (counter < classNames.Count);

            Console.WriteLine($"There are {counter} students in the class. ");
            Console.WriteLine();

            counter = 0;
            while (counter < classNames.Count)
            {
                Console.WriteLine(classNames[counter]);
                counter++;
            }

            Console.WriteLine($"There are {counter} students in the class. ");
            Console.ReadLine();
        }
    }
}
