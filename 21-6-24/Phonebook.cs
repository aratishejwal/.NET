using System;
using System.Collections.Generic;

class PhoneBook
{
    // Dictionary to store contacts
    private Dictionary<string, string> contacts;

    public PhoneBook()
    {
        contacts = new Dictionary<string, string>();
    }

    // Method to add a contact
    public void AddContact(string name, string phoneNumber)
    {
        if (!contacts.ContainsKey(name))
        {
            contacts[name] = phoneNumber;
            Console.WriteLine("Contact added successfully.");
        }
        else
        {
            Console.WriteLine("Contact already exists.");
        }
    }

    // Method to search for a contact
    public void SearchContact(string name)
    {
        if (contacts.ContainsKey(name))
        {
            Console.WriteLine("Contact found: {0} - {1}", name, contacts[name]);
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    // Method to display all contacts
    public void DisplayContacts()
    {
        if (contacts.Count > 0)
        {
            Console.WriteLine("Phone Book Contacts:");
            foreach (var contact in contacts)
            {
                Console.WriteLine("{0} - {1}", contact.Key, contact.Value);
            }
        }
        else
        {
            Console.WriteLine("No contacts in the phone book.");
        }
    }
}

class Program
{
    static void Main()
    {
        PhoneBook phoneBook = new PhoneBook();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nPhone Book Menu:");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Search Contact");
            Console.WriteLine("3. Display All Contacts");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter contact name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter contact phone number: ");
                    string phoneNumber = Console.ReadLine();
                    phoneBook.AddContact(name, phoneNumber);
                    break;

                case "2":
                    Console.Write("Enter contact name to search: ");
                    string searchName = Console.ReadLine();
                    phoneBook.SearchContact(searchName);
                    break;

                case "3":
                    phoneBook.DisplayContacts();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Exiting Phone Book application. Goodbye!");
    }
}
