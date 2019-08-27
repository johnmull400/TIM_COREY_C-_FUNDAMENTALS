using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject01UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            int diff;
            bool tooYoung = false;

            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            diff = 21 - age;
            if (diff > 0)
            {
                tooYoung = true;
            }

            if ((name.ToLower() == "bob" || name.ToLower() == "sue") && tooYoung == true)
            {
                Console.WriteLine($"I recommend you wait {diff} years before starting the course, Professor {name}");
            }
            else if ((name.ToLower() == "bob" || name.ToLower() == "sue") && tooYoung == false)
            {
                Console.WriteLine($"Welcome, Professor {name}");
            }
            else if ((name.ToLower() != "bob" && name.ToLower() != "sue") && tooYoung == true)
            {
                Console.WriteLine($"I suggest wait {diff} years before starting the course {name}");
            }
            else if ((name.ToLower() != "bob" && name.ToLower() != "sue") && tooYoung == false)
            {
                Console.WriteLine($"Welcome to the course {name}");
            }
            

            Console.WriteLine("Application finished, press any key to continue.");
            Console.ReadKey();
        }
    }
}
