using System;
namespace BridgeLabz.AddressBookSystem
{
    class AddressBookUtilityImpl : IAddressBook
    {
        private AddressBookModel[] contacts;
        private int contactCount;
        public AddressBookUtilityImpl()
        {
            contacts = new AddressBookModel[AddressBookUtility.MAX_CONTACTS];
            contactCount = 0;
        }
        //uc0
        public void DisplayWelcomeMessage(AddressBookModel model)
        {
            Console.WriteLine("====================================");
            Console.WriteLine(model.WelcomeMessage);
            Console.WriteLine("====================================\n");
        }
        //uc1+uc2+uc5 - add New Contact reusing add contact for uc5, no extra code needed
        public void AddNewContact()
        {
            if (contactCount >= AddressBookUtility.MAX_CONTACTS)
            {
                Console.WriteLine("Address Book is Full\n");
                return;
            }
            AddressBookModel model = new AddressBookModel();
            model.AddContact();
            contacts[contactCount] = model;
            contactCount++;
            Console.WriteLine("Contact Added Successfully\n");
        }
        //uc2- display All Contacts
        public void DisplayAllContacts()
        {
            if (contactCount == 0)
            {
                Console.WriteLine("No contacts available\n");
                return;
            }
            for (int i = 0; i < contactCount; i++)
            {
                Console.WriteLine($"\nContact {i + 1}");
                Console.WriteLine($"Name   : {contacts[i].FirstName} {contacts[i].LastName}");
                Console.WriteLine($"City   : {contacts[i].City}");
                Console.WriteLine($"Phone  : {contacts[i].PhoneNumber}");
                Console.WriteLine($"Email  : {contacts[i].Email}");
            }
            Console.WriteLine();
        }
        //uc3 – Edit contact using name
        public void EditContact()
        {
            if (contactCount == 0)
            {
                Console.WriteLine("No contacts to edit\n");
                return;
            }
            Console.Write("Enter First Name of contact to edit: ");
            string name = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < contactCount; i++)
            {
                if (contacts[i].FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    Console.WriteLine("Contact Found. Enter new details:");
                    Console.Write("Enter New Address: ");
                    contacts[i].Address = Console.ReadLine();
                    Console.Write("Enter New City: ");
                    contacts[i].City = Console.ReadLine();
                    Console.Write("Enter New State: ");
                    contacts[i].State = Console.ReadLine();
                    Console.Write("Enter New Zip: ");
                    contacts[i].Zip = Console.ReadLine();
                    Console.Write("Enter New Phone Number: ");
                    contacts[i].PhoneNumber = Console.ReadLine();
                    Console.Write("Enter New Email: ");
                    contacts[i].Email = Console.ReadLine();
                    Console.WriteLine("Contact Updated Successfully\n");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Contact not found\n");
            }
        }
        //uc4 - delete the contact using name
        public void DeleteContact()
        {
            if (contactCount == 0)
            {
                Console.WriteLine("No contacts to delete\n");
                return;
            }
            Console.Write("Enter First Name to delete: ");
            string name = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < contactCount; i++)
            {
                if (contacts[i].FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    // Shift elements left
                    for (int j = i; j < contactCount - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }
                    contacts[contactCount - 1] = null;
                    contactCount--;
                    Console.WriteLine("Contact Deleted Successfully\n");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Contact not found\n");
            }
        }
    }
}
