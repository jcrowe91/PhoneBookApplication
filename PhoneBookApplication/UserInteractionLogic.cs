using PhoneBookLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsoleUI
{
    public class UserInteractionLogic
    {
        public static void PhonebookMenu(List<Contact> contacts)
        {
            string userAnswer;
            Console.WriteLine($"What would you like to do?\n1: View All Contacts\n2: Create a New Contact\n3: Update A Contact\n4: Delete A Contact\n5: Exit");
            userAnswer = Console.ReadLine();

            if (userAnswer == "1") //View All
            {
                ContactLogic.SeeAllContacts(contacts);
            }
            else if (userAnswer == "2") //Create
            {
                Console.Clear();
                Console.WriteLine("Create New Contact:");
                var newContact = ContactLogic.CreateContact();
                contacts.Add(newContact);

            }
            else if (userAnswer == "3") //Update
            {
                ContactLogic.UpdateContact(contacts);
            }
            else if (userAnswer == "4") //Delete
            {
                ContactLogic.DeleteContact(contacts);
            }
            else if (userAnswer == "5")
            {
                Console.WriteLine("Have a great day!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter a valid response");

            }
        }
    }
}
