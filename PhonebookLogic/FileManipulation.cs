using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace PhoneBookLibrary
{
    public class FileManipulation
    {
        //class for handling the location of, saving to, and reading from the .csv file that holds the contact information
        public static string GetFilePath()
        {
            //get the current directory on local machine and a Contacts.txt file to save contacts to
            string filePath = $"{Directory.GetCurrentDirectory()}/Contacts.txt";
            return filePath;
        }

        public static void LoadContacts(List<Contact> contacts)
        {
            //method for reading from the .csv file, and converting the info to a list of contacts
            string filePath = GetFilePath();

            //if the file does not exist, create the file and then close it
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            List<string> lines = File.ReadAllLines(filePath).ToList();

            //check if file is populated
            if (lines.Count == 0)
            {
                //if no contacts exist, break out of the method with return
                return;
            }

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                //create new contact and set properties of the contact from the string array
                Contact newContact = new Contact()
                {
                    FirstName = entries[0],
                    LastName = entries[1],
                    PhoneNumber = entries[2],
                    EmailAddress = entries[3],
                    HomeAddress = entries[4]
                };

                //add the contact to the list
                contacts.Add(newContact);
            }
        }

        public static void SaveContacts(List<Contact> contacts)
        {
            //method for allowing user to save updated list of contacts back to .csv file
            List<string> output = new List<string>();
            string filePath = GetFilePath();

            foreach (var contact in contacts)
            {
                //populate the output list with a csv string for each contact in the list
                output.Add($"{contact.FirstName},{contact.LastName},{contact.PhoneNumber},{contact.EmailAddress},{contact.HomeAddress}");
            }

            File.WriteAllLines(filePath, output);

            //for loop to simulate saving progress
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(300);
                Console.Write('.');
            }

        }
    }
}
