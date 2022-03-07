using PhoneBookLibrary;
using System;
using System.Collections.Generic;

namespace PhoneBookConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Things to think about
            /*
             * 1. Have a class that handles business logic, keep that in your Library, A Contact doesn't need to know how to create, read, update, or delete itself.
             * 1a. Will you need to have more than one instance of this new class?
             * 2. Think about adding a class that handles user interactions with the console, where should that class go
             * 2a. Should there ever be more than one instance of that class?
             */

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

            var test2 = new Contact();
            test2.FirstName = "Ulfric";
            test2.LastName = "Stormcloak";
            test2.PhoneNumber = 5555555;
            test2.HomeAddress = "Windhelm";
            test2.EmailAddress = "skyrimforthenords@hrothgar.com";
            contacts.Add(test2);

            var test3 = new Contact();
            test3.FirstName = "Kaz";
            test3.LastName = "Miller";
            test3.PhoneNumber = 5555555;
            test3.HomeAddress = "Mother Base";
            test3.EmailAddress = "playeduslikeafiddle@outerheaven.org";
            contacts.Add(test3);
;
            #endregion

            Console.WriteLine("Welcome to your phonebook application!");

            while (cont == true)
            {
               UserInteractionLogic.PhonebookMenu(contacts);               
            }
        }                     

    }   
}
