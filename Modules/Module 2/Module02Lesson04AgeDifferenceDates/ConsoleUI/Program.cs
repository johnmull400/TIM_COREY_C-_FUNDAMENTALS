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
            Console.WriteLine("Please enter your date of birht in the format DD/MM/YYYY");
            string birthDateText = Console.ReadLine();
            bool validDate = DateTime.TryParse(birthDateText, out DateTime dateOfBirth);

            if (validDate)
            {
                // How many days have passed between the entered date and today
                double daysDiff = (DateTime.Today.Date - dateOfBirth ).TotalDays;
                double yearsDiff = daysDiff / 365;

                Console.WriteLine($"Days since {dateOfBirth} : {daysDiff} ");
                Console.WriteLine($"Years since {dateOfBirth} : {Math.Round(yearsDiff,2)} ");
            }

            Console.ReadLine();
        }
    }
}
