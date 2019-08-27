using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables2UI
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 0;
            string firstName = "";
            string input = "N";
            string lastName = "";
            string fullName = "";
            bool aliveYN = false;
          
            Console.WriteLine("Please enter the first name of the person of interest");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter the last name of the person of interest");
            lastName = Console.ReadLine();

            fullName = $"{firstName} {lastName}";

            Console.WriteLine("What is thie person's age?");
            age = Int32.Parse(Console.ReadLine());

            age += 10;


            while (input.ToUpper() != "Y" || input.ToUpper() != "N") ;
            {
                Console.WriteLine("Is this person still alive?, Please answer 'Y' or 'N'");
                input = Console.ReadLine();
            } 


            if (input.ToUpper() == "Y")
            {
                aliveYN = true;
            }
            else aliveYN = false;


            Console.WriteLine($"The person's name is: {fullName}.");
            Console.WriteLine($"Their age is: {age}.");
            if (aliveYN == true)
            {
                Console.WriteLine("And they are alive.");
            }
            else Console.WriteLine("And they are dead.");



            Console.WriteLine($"The age plus 10 years is {age}");

            Console.ReadLine();

        }
    }
}
