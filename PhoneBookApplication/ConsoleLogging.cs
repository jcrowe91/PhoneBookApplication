using PhoneBookLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookLibrary
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

        public static void MainConsole(List<Contact> contacts, string filePath)
        {
            bool cont = true;
            while (cont == true)
            {
                UserInteractionLogic.PhonebookMenu(contacts, filePath);
            }
        }

        public static void PassMessage(string message)
        {
            Console.WriteLine(message);            
        }

        public static void CRUDForLoop(List<Contact> contacts)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine($"ID: {i + 1} {contacts[i].FirstName} {contacts[i].LastName}\nPhone Number: {contacts[i].PhoneNumber}\nEmail Address: {contacts[i].EmailAddress}\nHome Address: {contacts[i].HomeAddress}");
                Console.WriteLine("-----------------------------");
            }
        }

        public static void CRUDForeachLoop(List<Contact> contacts)
        {
            Console.Clear();
            foreach (var item in contacts)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}\nPhone Number: {item.PhoneNumber}\nEmail Address: {item.EmailAddress}\nHome Address: {item.HomeAddress}");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
