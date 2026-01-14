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
        //uc1+uc2 – add New Contact
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
        //uc2– display All Contacts
        public void DisplayAllContacts()
        {
            if (contactCount == 0)
            {
                Console.WriteLine("No contacts available\n");
                return;
            }
            Console.WriteLine("\n----- Address Book Contacts -----");
            for (int i = 0; i < contactCount; i++)
            {
                Console.WriteLine($"\nContact {i + 1}");
                Console.WriteLine($"Name   : {contacts[i].FirstName} {contacts[i].LastName}");
                Console.WriteLine($"City   : {contacts[i].City}");
                Console.WriteLine($"Phone  : {contacts[i].PhoneNumber}");
                Console.WriteLine($"Email  : {contacts[i].Email}");
            }
            Console.WriteLine("---------------------------------\n");
        }
    }
}
