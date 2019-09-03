using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //ExternalMethodLib MyLib = new ExternalMethodLib();
            
            //Ask the users name
            ExternalMethodLib.AskUserName("Please enter your name");

            //Get the user's name
            string name = ExternalMethodLib.GetUserName();

            //Greet the user by their name
            ExternalMethodLib.GreetUser(name);

            Console.ReadLine();

            
        }

       

    }
}
