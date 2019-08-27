using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is to practice setting up variables
            // bool - is alive 
            // string First name
            // string Last name
            // int age

            //variables
            int age = 25;
            string firstName = "John";
            string lastName = "Smith";
            string fullName = $"{firstName} {lastName}";
            string output = $"{fullName} {age.ToString()}";
            string filePath = @"C:\Temp\MyFiles";


            Console.WriteLine(fullName);
            Console.WriteLine(output);
            Console.WriteLine($"His information can be found here:  {filePath}");

            Console.ReadLine();


        }
    }
}
