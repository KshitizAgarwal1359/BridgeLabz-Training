using System;
namespace BridgeLabz.AddressBookSystem
{
    class AddressBookUtilityImpl : IAddressBook
    {
        //uc6 – Dictionary of Address Books
        private Dictionary<string, AddressBookModel[]> addressBooks;
        private Dictionary<string, int> contactCounts;
        private string currentAddressBook;
        public AddressBookUtilityImpl()
        {
            addressBooks = new Dictionary<string, AddressBookModel[]>();
            contactCounts = new Dictionary<string, int>();
        }
        //uc0
        public void DisplayWelcomeMessage(AddressBookModel model)
        {
            Console.WriteLine("====================================");
            Console.WriteLine(model.WelcomeMessage);
            Console.WriteLine("====================================\n");
        }
        //uc6 – Create New Address Book
        public void CreateAddressBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();
            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("Address Book already exists\n");
                return;
            }
            addressBooks[name] = new AddressBookModel[AddressBookUtility.MAX_CONTACTS];
            contactCounts[name] = 0;
            currentAddressBook = name;
            Console.WriteLine($"Address Book '{name}' created and selected\n");
        }
        //uc1+uc2+uc5 - add New Contact reusing add contact for uc5, no extra code needed add number selected address book 
        public void AddNewContact()
        {
            if (currentAddressBook == null)
            {
                Console.WriteLine("Please select an Address Book first\n");
                return;
            }
            AddressBookModel newContact = new AddressBookModel();
            newContact.AddContact();
            AddressBookModel[] contacts = addressBooks[currentAddressBook];
            int count = contactCounts[currentAddressBook];
            //uc7 –duplicate check
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].Equals(newContact))
                {
                    Console.WriteLine("Duplicate contact found. Not added.\n");
                    return;
                }
            }
            if (count >= AddressBookUtility.MAX_CONTACTS)
            {
                Console.WriteLine("Address Book is full\n");
                return;
            }
            contacts[count] = newContact;
            contactCounts[currentAddressBook]++;
            Console.WriteLine($"Contact added to '{currentAddressBook}' Address Book\n");
        }
        //uc2- display All Contacts
        public void DisplayAllContacts()
        {
            if (currentAddressBook == null)
            {
                Console.WriteLine("Create an Address Book first\n");
                return;
            }
            int count = contactCounts[currentAddressBook];
            if (count == 0)
            {
                Console.WriteLine("No contacts available\n");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                AddressBookModel c = addressBooks[currentAddressBook][i];
                Console.WriteLine($"\nContact {i + 1}");
                Console.WriteLine($"Name  : {c.FirstName} {c.LastName}");
                Console.WriteLine($"City  : {c.City}");
                Console.WriteLine($"Phone : {c.PhoneNumber}");
                Console.WriteLine($"Email : {c.Email}");
            }
            Console.WriteLine();
        }
        //uc3 – Edit contact using name
        public void EditContact()
        {
            Console.Write("Enter First Name to edit: ");
            string name = Console.ReadLine();
            int count = contactCounts[currentAddressBook];
            for (int i = 0; i < count; i++)
            {
                if (addressBooks[currentAddressBook][i].FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter New City: ");
                    addressBooks[currentAddressBook][i].City = Console.ReadLine();
                    Console.Write("Enter New Phone: ");
                    addressBooks[currentAddressBook][i].PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Contact Updated\n");
                    return;
                }
            }
            Console.WriteLine("Contact not found\n");
        }
        //uc4 - delete the contact using name
        public void DeleteContact()
        {
            Console.Write("Enter First Name to delete: ");
            string name = Console.ReadLine();
            int count = contactCounts[currentAddressBook];
            for (int i = 0; i < count; i++)
            {
                if (addressBooks[currentAddressBook][i].FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < count - 1; j++)
                        addressBooks[currentAddressBook][j] = addressBooks[currentAddressBook][j + 1];
                    addressBooks[currentAddressBook][count - 1] = null;
                    contactCounts[currentAddressBook]--;
                    Console.WriteLine("Contact Deleted\n");
                    return;
                }
            }
            Console.WriteLine("Contact not found\n");
        }
        //uc6– Select Address Book refactor uc6
        public void SelectAddressBook()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("No Address Books available. Create one first.\n");
                return;
            }
            Console.WriteLine("Available Address Books:");
            foreach (string name in addressBooks.Keys)
            {
                Console.WriteLine("- " + name);
            }
            Console.Write("Enter Address Book name to select: ");
            string nameToSelect = Console.ReadLine();
            if (!addressBooks.ContainsKey(nameToSelect))
            {
                Console.WriteLine("Address Book not found\n");
                return;
            }
            currentAddressBook = nameToSelect;
            Console.WriteLine($"Address Book '{currentAddressBook}' selected\n");
        }
    }
}
