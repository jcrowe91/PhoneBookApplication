using PhoneBookLibrary;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PhoneBookLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {           
            string filePath = FileManipulation.FilePath();
            List<Contact> contacts = new List<Contact>();

            ConsoleLogging.WelcomeMessage();
            FileManipulation.LoadContacts(contacts, filePath);

            ConsoleLogging.MainConsole(contacts, filePath);
        }                     

    }   
}
