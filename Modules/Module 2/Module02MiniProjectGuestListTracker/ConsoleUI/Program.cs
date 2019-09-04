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
           
            Console.WriteLine("Do you wnat to register a guest?");
            string addMoreGuests = Console.ReadLine().ToLower();

            while (addMoreGuests == "y")
            {
                AskForGuestDetails();
                
                Console.WriteLine("Do you wnat to register another guest?");
                addMoreGuests = Console.ReadLine().ToLower();
            }
            PrintGuestList();
            Console.ReadLine();
        }

        public static void ManageGuestList(string guestName, int numberInParty)
        {

            Dictionary<string, int> GuestList = new Dictionary<string, int>();

            GuestList.Add(guestName, numberInParty);
            
        }
        public static void AskForGuestDetails()
        {
            string guestName = "";
            int numberInParty = 0;

            Console.WriteLine("Please enter the guests name");
            Console.ReadLine();

            ManageGuestList(guestName,numberInParty);
            

        }
        public static void PrintGuestList()
        {
            foreach (KeyValuePair<string,int> item in ManageGuestList.GuestList)
            {
                Console.WriteLine(ManageGuestList.guest)
            }        

        

        }
    }
}
