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


            Console.WriteLine($"What would you like to do?\n1: View All Contacts\n2: Create a New Contact\n3: Update A Contact\n4: Delete A Contact\n5: Exit");
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

        public static void SeeAllContacts(List<Contact> contacts)
        {
            foreach (var item in contacts)
            {
                Console.Clear();
                Console.WriteLine($"{item.FirstName} {item.LastName}\nPhone Number: {item.PhoneNumber}\nEmail Address: {item.EmailAddress}\nHome Address: {item.HomeAddress}");
            }
        }

        public static Contact CreateContact()
        {
            var contact = new Contact();
            Console.Clear();
            Console.WriteLine("Create New Contact:");
            Console.WriteLine("What is the first name of the person you want to add?");            
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
