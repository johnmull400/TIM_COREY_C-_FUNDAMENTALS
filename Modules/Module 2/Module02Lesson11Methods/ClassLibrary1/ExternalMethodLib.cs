using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class ExternalMethodLib
    {
        public static void AskUserName(string message)
        {
            Console.WriteLine(message);
        }

        public static string GetUserName()
        {

            string output = Console.ReadLine();
            return output;
        }

        public static void GreetUser(string inputName)
        {

            Console.WriteLine($"Hello, {inputName}");

        }

    }
}
