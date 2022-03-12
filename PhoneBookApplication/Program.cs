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
            List<Contact> contacts = new List<Contact>();

            //print welcome message to console
            ConsoleLogging.WelcomeMessage();

            //load current saved contacts from csv file, or create one if none exists
            FileManipulation.LoadContactsCSV(contacts);

            //print the main menu to console
            ConsoleLogging.MainConsole(contacts);
        }                     

    }   
}
