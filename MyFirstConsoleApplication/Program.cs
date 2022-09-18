using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main()
        {
            GetUserNameAndLocation();
            PressToContinue();
            ChristmasCountdown();
            PressToContinue();
            GlazerApp.RunExample();
            PressToContinue();
        }

        private static void GetUserNameAndLocation()  {

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            var person = new Person
            {
                Name = name
            };

            Console.WriteLine($"Hi {person.Name}! Where are you from?");
            var location = Console.ReadLine();

            person.Location = location;

            Console.WriteLine($"I have never been to {person.Location}. I bet it is nice.");

        }

        private static void PressToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void ChristmasCountdown()
        {
            DateTime today = DateTime.Today;
            var todayFormatted = today.ToString("MM-dd-yyyy");
            Console.WriteLine($"Today's date is: {todayFormatted}");

            DateTime xmas = new DateTime(2022, 12, 25);

            var value = xmas.Subtract(today).TotalDays;

            Console.WriteLine($"There are {value} days until Christmas!");
        }
    }
}
