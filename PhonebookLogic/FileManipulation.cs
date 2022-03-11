using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneBookLibrary
{
    public class FileManipulation
    {
        public static string FilePath()
        {
            string filePath = $"{Directory.GetCurrentDirectory()}/Contacts.txt";
            return filePath;
        }
        
        public static void LoadContactsCSV(List<Contact> contacts)
        {
            string filePath = FileManipulation.FilePath();

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Contact newContact = new Contact();
                newContact.FirstName = entries[0];
                newContact.LastName = entries[1];
                newContact.PhoneNumber = entries[2];
                newContact.EmailAddress = entries[3];
                newContact.HomeAddress = entries[4];
                contacts.Add(newContact);
            }
        }

        public static void SaveContactsCSV(List<Contact> contacts)
        {
            List<string> output = new List<string>();
            string filePath = FileManipulation.FilePath();

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
