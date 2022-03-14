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

        public static void MainConsole(List<Contact> contacts)
        {
            //user will specify when the application is done
            while (true)
            {
                UserInteractionLogic.PhonebookMenu(contacts);
            }
        }

        public static void PassMessage(string message)
        {
            Console.WriteLine(message);            
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }

        public static void CRUDForLoop(List<Contact> contacts)
        {
            //used in update and delete methods
            for (int i = 0; i < contacts.Count; i++)
            {
                //loop through each contact, assign an ID number, and display the properties of each
                Console.WriteLine($"ID: {i + 1} {contacts[i].FirstName} {contacts[i].LastName}\nPhone Number: {contacts[i].PhoneNumber}\nEmail Address: {contacts[i].EmailAddress}\nHome Address: {contacts[i].HomeAddress}");
                Console.WriteLine("-----------------------------");
            }
        }

        public static void CRUDForeachLoop(List<Contact> contacts)
        {
            //used in GetAllContacts method
            ClearConsole();
            foreach (var contact in contacts)
            {
                //display properties of each contact in list
                Console.WriteLine($"{contact.FirstName} {contact.LastName}\nPhone Number: {contact.PhoneNumber}\nEmail Address: {contact.EmailAddress}\nHome Address: {contact.HomeAddress}");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
