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
        public static void PhonebookMenu(List<Contact> contacts)
        {
            
            string userAnswer;            
            Console.WriteLine($"What would you like to do?\n1: View All Contacts\n2: Create a New Contact\n3: Update A Contact\n4: Delete A Contact\n5: Save and Exit");
            userAnswer = Console.ReadLine();

            if (userAnswer == "1") //View All
            {
                Console.Clear();
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
                Console.Clear();
                ContactLogic.UpdateContact(contacts);
            }
            else if (userAnswer == "4") //Delete
            {
                Console.Clear();
                ContactLogic.DeleteContact(contacts);
            }
            else if (userAnswer == "5")
            {
                Console.Clear();
                //SaveContacts(contacts, filePath);                
                Console.WriteLine($"\nSaved your contacts! Have a great day!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter a valid response");

            }
        }

        public static void LoadContacts(List<Contact> contacts, string filePath)
        {


            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Contact newContact = new Contact();
                newContact.FirstName = entries[0];
                newContact.LastName = entries[1];
                newContact.PhoneNumber = (entries[2]);
                newContact.EmailAddress = entries[3];
                newContact.HomeAddress = entries[4];
                contacts.Add(newContact);                
            }
        }

        public static void SaveContacts(List<Contact> contacts, string filePath)
        {
            List<string> output = new List<string>();

            foreach (var item in contacts)
            {
                output.Add($"{item.FirstName},{item.LastName},{item.PhoneNumber},{item.EmailAddress},{item.HomeAddress}");
            }

            File.WriteAllLines(filePath, output);           

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(300);
                Console.Write('.');
            }

        }
    }
}
