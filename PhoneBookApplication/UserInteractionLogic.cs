using PhoneBookLibrary;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PhoneBookConsoleUI
{
    public class UserInteractionLogic
    {
        public static void PhonebookMenu(List<Contact> contacts, string filePath)
        {
            
            string userAnswer;            
            ConsoleLogging.MainMenu();
            userAnswer = Console.ReadLine();

            if (userAnswer == "1") 
            {
                Console.Clear();
                ContactLogic.SeeAllContacts(contacts);
            }
            else if (userAnswer == "2")
            {
                Console.Clear();
                Console.WriteLine("Create New Contact:");
                var newContact = ContactLogic.CreateContact();
                contacts.Add(newContact);

            }
            else if (userAnswer == "3") 
            {
                Console.Clear();
                ContactLogic.UpdateContact(contacts);
            }
            else if (userAnswer == "4") 
            {
                Console.Clear();
                ContactLogic.DeleteContact(contacts);
            }
            else if (userAnswer == "5")
            {
                Console.Clear();
                FileManipulation.SaveContacts(contacts, filePath);
                ConsoleLogging.ExitMessage();
            }
            else
            {
                ConsoleLogging.InvalidResponse();

            }
        }

        

        
    }
}
