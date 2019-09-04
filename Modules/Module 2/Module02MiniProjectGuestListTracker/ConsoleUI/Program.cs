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

        static Dictionary<string, int> GuestList = new Dictionary<string, int>();
        static int totalGuests = 0;

        public static void ManageGuestList(string guestName, int numberInParty)
        {

            //Dictionary<string, int> GuestList = new Dictionary<string, int>();

            GuestList.Add(guestName, numberInParty);
            
        }
        public static void AskForGuestDetails()
        {
            string guestName = "";
            int numberInParty = 0;

            Console.WriteLine("Please enter the guests name");
            guestName=Console.ReadLine();

            Console.WriteLine($"Enter the number of guests in {guestName}'s party");
            bool isInt = Int32.TryParse(Console.ReadLine(), out numberInParty);

            ManageGuestList(guestName,numberInParty);
            totalGuests += numberInParty;

        }
        public static void PrintGuestList()
        {
            // Note the word Party in the loop. This will work as long as you use the same word in 
            // Console.Writeline
            foreach (KeyValuePair<string, int> Party in GuestList)
            {
                
                Console.WriteLine("Name: {0}, Number in Party {1}",Party.Key,Party.Value);
            }

            Console.WriteLine($"The total number of guests is {totalGuests.ToString()}");

        }
    }
}
