using PhoneBookLibrary;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using PhoneBookConsoleUI;

namespace PhoneBookLibrary
{
    public class UserInteractionLogic
    {
        public static void PhonebookMenu(List<Contact> contacts)
        {
            string userAnswer;
            ConsoleLogging.MainMenu();
            userAnswer = Console.ReadLine();

            //if-else statment for user selection, choosing 1-5 on the main menu          
            if (userAnswer == "1")
            {
                //read CRUD operation
                ConsoleLogging.ClearConsole();
                GetAllContacts(contacts);
            }
            else if (userAnswer == "2")
            {
                //create CRUD operation
                ConsoleLogging.ClearConsole();
                ConsoleLogging.PassMessage("Create New Contact:");
                var newContact = CreateContact();
                contacts.Add(newContact);

            }
            else if (userAnswer == "3")
            {
                //update CRUD operation
                ConsoleLogging.ClearConsole();
                UpdateContact(contacts);
            }
            else if (userAnswer == "4")
            {
                //delete CRUD operation
                ConsoleLogging.ClearConsole();
                DeleteContact(contacts);
            }
            else if (userAnswer == "5")
            {
                //save the current list of contacts back to .csv file and exit the program
                ConsoleLogging.ClearConsole();
                FileManipulation.SaveContacts(contacts);
                ConsoleLogging.ExitMessage();
            }
            else
            {
                //any other response will trigger an invalid message
                ConsoleLogging.InvalidResponse();

            }
        }
        public static void GetAllContacts(List<Contact> contacts)
        {
            //display all contacts using foreach method
            ConsoleLogging.CRUDForeachLoop(contacts);
        }

        public static Contact CreateContact()
        {
            //method to create a new contact and allow the user to set each property, returning the new contact
            var contact = new Contact();

            ConsoleLogging.PassMessage("What is the first name of the person?");
            contact.FirstName = Console.ReadLine();

            ConsoleLogging.PassMessage("What is the last name of the person?");
            contact.LastName = Console.ReadLine();

            ConsoleLogging.PassMessage("What is the phone number of the person?");
            contact.PhoneNumber = Console.ReadLine();

            ConsoleLogging.PassMessage("What is the email for this contact?");
            contact.EmailAddress = Console.ReadLine();

            ConsoleLogging.PassMessage("What home address would you like to enter for this contact?");
            contact.HomeAddress = Console.ReadLine();

            return contact;
        }
        public static void UpdateContact(List<Contact> contacts)
        {
            //for update method, user chooses ID of the contact to update and the CreateContact method is called
            ConsoleLogging.CRUDForLoop(contacts);

            ConsoleLogging.PassMessage("What is the ID of the contact you'd like to update?");
            var contactID = Convert.ToInt32(Console.ReadLine());

            contacts[contactID - 1] = CreateContact();
            ConsoleLogging.PassMessage("Success!");
        }

        public static void DeleteContact(List<Contact> contacts)
        {
            //delete method and update method use a for loop for displaying IDs to user
            //for the delete function, use RemoveAt method and generated ID number to take the desired contact from contacts list
            ConsoleLogging.CRUDForLoop(contacts);

            ConsoleLogging.PassMessage("What is the ID of the contact you'd like to delete?");
            var contactID = Convert.ToInt32(Console.ReadLine());

            //remove the contact at ID location
            contacts.RemoveAt(contactID - 1);
            ConsoleLogging.PassMessage("Success!");
        }
    }
}
