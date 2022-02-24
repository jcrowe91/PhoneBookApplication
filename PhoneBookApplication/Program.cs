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
            

            if (userAnswer == "1")
            {
                Console.WriteLine("One");
            }
            else if (userAnswer == "2")
            {
                Console.WriteLine("Two");
            }
            else if (userAnswer == "3")
            {
                Console.WriteLine("Three");
            }
            else if (userAnswer == "4")
            {
                Console.WriteLine("Four");
            }
            else
            {
                Console.WriteLine("Please enter a valid response");
            }




        }

    }   
}
