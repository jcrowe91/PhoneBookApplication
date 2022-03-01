using PhoneBookLibrary;
using System;
using System.Collections.Generic;

namespace PhoneBookConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;
            var contacts = new List<Contact>();
            
           
            Console.WriteLine("Welcome to your phonebook application!");


            Console.WriteLine($"What would you like to do?\n1: View All Contacts\n2: Create a New Contact\n3: Update A Contact\n4: Delete A Contact");
            userAnswer = Convert.ToString(Console.ReadLine());
            

            if (userAnswer == "1") //View All
            {
                SeeAllContacts(contacts);
                
            }
            else if (userAnswer == "2") //Create
            {
               var newContact = CreateContact();
               contacts.Add(newContact);
                
            }
            else if (userAnswer == "3") //Update
            {
                Console.WriteLine("Three");
            }
            else if (userAnswer == "4") //Delete
            {
                Console.WriteLine("Four");
            }
            else
            {
                Console.WriteLine("Please enter a valid response");
            }

        }

        public static void SeeAllContacts(List<Contact> contacts)
        {
            foreach (var item in contacts)
            {
                Console.WriteLine(item);
            }
        }

        public static Contact CreateContact()
        {
            Console.WriteLine("What is the first name of the person you want to add?");
            var contact = new Contact();
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("What is the last name of the person you want to add?");
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
