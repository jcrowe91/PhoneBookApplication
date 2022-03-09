using PhoneBookLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsoleUI
{
    public class ConsoleLogging
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to your phonebook application!");
        }

        public static void MainMenu()
        {
            Console.WriteLine($"What would you like to do?\n1: View All Contacts\n2: Create a New Contact\n3: Update A Contact\n4: Delete A Contact\n5: Save and Exit");
        }

        public static void ExitMessage()
        {            
            Console.WriteLine($"\nSaved your contacts! Have a great day!");
            Environment.Exit(0);
        }

        public static void InvalidResponse()
        {
            Console.WriteLine("Please enter a valid response");
        }

        public static void ListContacts()
        {
            
        }
    }
}
