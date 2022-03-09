using PhoneBookLibrary;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PhoneBookConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {           
            string filePath = FileManipulation.FilePath();
            List<Contact> contacts = new List<Contact>();
            ConsoleLogging.WelcomeMessage();
            FileManipulation.LoadContacts(contacts, filePath);

            bool cont = true;
            while (cont == true)
            {
               UserInteractionLogic.PhonebookMenu(contacts, filePath);               
            }
        }                     

    }   
}
