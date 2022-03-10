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
        public static void PhonebookMenu(List<Contact> contacts, string filePath)
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
                Console.WriteLine("Create New Contact:");
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
                FileManipulation.SaveContactsCSV(contacts, filePath);
                ConsoleLogging.ExitMessage();
            }
            else
            {
                ConsoleLogging.InvalidResponse();

            }
        }

        public static void SeeAllContacts(List<Contact> contacts)
        {
            Console.Clear();
            foreach (var item in contacts)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}\nPhone Number: {item.PhoneNumber}\nEmail Address: {item.EmailAddress}\nHome Address: {item.HomeAddress}");
                Console.WriteLine("-----------------------------");
            }
        }

        public static void DeleteContact(List<Contact> contacts)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine($"ID: {i + 1} {contacts[i].FirstName} {contacts[i].LastName}\nPhone Number: {contacts[i].PhoneNumber}\nEmail Address: {contacts[i].EmailAddress}\nHome Address: {contacts[i].HomeAddress}");
                Console.WriteLine("-----------------------------");
            }

            Console.WriteLine("What is the ID of the contact you'd like to delete?");
            var contactID = Convert.ToInt32(Console.ReadLine());

            contacts.RemoveAt(contactID - 1);
            Console.WriteLine("Success!");
        }

        public static void UpdateContact(List<Contact> contacts)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine($"ID: {i + 1} {contacts[i].FirstName} {contacts[i].LastName}\nPhone Number: {contacts[i].PhoneNumber}\nEmail Address: {contacts[i].EmailAddress}\nHome Address: {contacts[i].HomeAddress}");
                Console.WriteLine("-----------------------------");
            }

            Console.WriteLine("What is the ID of the contact you'd like to update?");
            var contactID = Convert.ToInt32(Console.ReadLine());

            contacts[contactID - 1] = CreateContact();
            Console.WriteLine("Success!");
        }

        public static Contact CreateContact()
        {
            //Add method to pass message in ConsoleLogging
            var contact = new Contact();
            Console.WriteLine("What is the first name of the person?");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("What is the last name of the person?");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("What is the phone number of the person?");
            contact.PhoneNumber = (Console.ReadLine());
            Console.WriteLine("What is the email for this contact?");
            contact.EmailAddress = Console.ReadLine();
            Console.WriteLine("What home address would you like to enter for this contact?");
            contact.HomeAddress = Console.ReadLine();
            return contact;
        }


    }
}
