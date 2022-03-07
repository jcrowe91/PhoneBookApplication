using PhoneBookLibrary;
using System;
using System.Collections.Generic;

namespace PhoneBookConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool cont = true;
            var contacts = new List<Contact>();
            #region TEST CONTACT
            var test = new Contact();
            test.FirstName = "Albert";
            test.LastName = "Wesker";
            test.PhoneNumber = 5555555;
            test.HomeAddress = "Raccoon City";
            test.EmailAddress = "awesker@umbrella.com";
            contacts.Add(test);
            #endregion

            Console.WriteLine("Welcome to your phonebook application!");

            while (cont == true)
            {
                PhonebookMenu(contacts);               
            }
        }

        private static void PhonebookMenu(List<Contact> contacts)
        {
            string userAnswer;
            Console.WriteLine($"What would you like to do?\n1: View All Contacts\n2: Create a New Contact\n3: Update A Contact\n4: Delete A Contact\n5: Exit");
            userAnswer = Console.ReadLine();

            if (userAnswer == "1") //View All
            {
                SeeAllContacts(contacts);
            }
            else if (userAnswer == "2") //Create
            {
                Console.Clear();
                Console.WriteLine("Create New Contact:");
                var newContact = CreateContact();
                contacts.Add(newContact);

            }
            else if (userAnswer == "3") //Update
            {
                UpdateContact(contacts);
            }
            else if (userAnswer == "4") //Delete
            {
                DeleteContact(contacts);
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

        private static void DeleteContact(List<Contact> contacts)
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

        private static void UpdateContact(List<Contact> contacts)
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

        public static void SeeAllContacts(List<Contact> contacts)
        {
            Console.Clear();
            foreach (var item in contacts)
            {                              
                Console.WriteLine($"{item.FirstName} {item.LastName}\nPhone Number: {item.PhoneNumber}\nEmail Address: {item.EmailAddress}\nHome Address: {item.HomeAddress}");
                Console.WriteLine("-----------------------------");
            }
        }

        public static Contact CreateContact()
        {
            var contact = new Contact();                        
            Console.WriteLine("What is the first name of the person?");            
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("What is the last name of the person?");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("What is the phone number of the person?");
            contact.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the email for this contact?");
            contact.EmailAddress = Console.ReadLine();
            Console.WriteLine("What home address would you like to enter for this contact?");
            contact.HomeAddress = Console.ReadLine();
            return contact;
        }

        

    }   
}
