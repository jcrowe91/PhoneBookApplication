using PhoneBookLibrary;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PhoneBookLibrary
{
    public class UserInteractionLogic
    {
        public static void PhonebookMenu(List<Contact> contacts)
        {            
            string userAnswer;            
            ConsoleLogging.MainMenu();
            userAnswer = Console.ReadLine();

            if (userAnswer == "1") 
            {
                Console.Clear();
                SeeAllContacts(contacts);
            }
            else if (userAnswer == "2")
            {
                Console.Clear();
                ConsoleLogging.PassMessage("Create New Contact:");
                var newContact = CreateContact();
                contacts.Add(newContact);

            }
            else if (userAnswer == "3") 
            {
                Console.Clear();
                UpdateContact(contacts);
            }
            else if (userAnswer == "4") 
            {
                Console.Clear();
                DeleteContact(contacts);
            }
            else if (userAnswer == "5")
            {
                Console.Clear();
                FileManipulation.SaveContactsCSV(contacts);
                ConsoleLogging.ExitMessage();
            }
            else
            {
                ConsoleLogging.InvalidResponse();

            }
        }

        public static void SeeAllContacts(List<Contact> contacts)
        {
            ConsoleLogging.CRUDForeachLoop(contacts);
        }

        public static void DeleteContact(List<Contact> contacts)
        {
            ConsoleLogging.CRUDForLoop(contacts);

            ConsoleLogging.PassMessage("What is the ID of the contact you'd like to delete?");
            var contactID = Convert.ToInt32(Console.ReadLine());

            contacts.RemoveAt(contactID - 1);
            ConsoleLogging.PassMessage("Success!");
        }

        public static void UpdateContact(List<Contact> contacts)
        {
            ConsoleLogging.CRUDForLoop(contacts);

            ConsoleLogging.PassMessage("What is the ID of the contact you'd like to update?");
            var contactID = Convert.ToInt32(Console.ReadLine());

            contacts[contactID - 1] = CreateContact();
            ConsoleLogging.PassMessage("Success!");
        }

        public static Contact CreateContact()
        {            
            var contact = new Contact();
            ConsoleLogging.PassMessage("What is the first name of the person?");
            contact.FirstName = Console.ReadLine();
            ConsoleLogging.PassMessage("What is the last name of the person?");
            contact.LastName = Console.ReadLine();
            ConsoleLogging.PassMessage("What is the phone number of the person?");
            contact.PhoneNumber = (Console.ReadLine());
            ConsoleLogging.PassMessage("What is the email for this contact?");
            contact.EmailAddress = Console.ReadLine();
            ConsoleLogging.PassMessage("What home address would you like to enter for this contact?");
            contact.HomeAddress = Console.ReadLine();
            return contact;
        }


    }
}
