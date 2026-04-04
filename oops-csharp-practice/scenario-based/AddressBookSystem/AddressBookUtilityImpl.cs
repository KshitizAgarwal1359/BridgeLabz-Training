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
        //uc8 searching person by city or state
        public void SearchPersonByCityOrState()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("No Address Books available\n");
                return;
            }
            Console.Write("Search by (1) City or (2) State: ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name to search: ");
            string searchValue = Console.ReadLine();
            bool found = false;
            foreach (var entry in addressBooks)
            {
                string addressBookName = entry.Key;
                AddressBookModel[] contacts = entry.Value;
                int count = contactCounts[addressBookName];
                for (int i = 0; i < count; i++)
                {
                    AddressBookModel contact = contacts[i];
                    if ((option == 1 && contact.City.Equals(searchValue, StringComparison.OrdinalIgnoreCase)) ||
                        (option == 2 && contact.State.Equals(searchValue, StringComparison.OrdinalIgnoreCase)))
                    {
                        if (!found)
                        {
                            Console.WriteLine("\nSearch Results:");
                            found = true;
                        }
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine($"Address Book : {addressBookName}");
                        Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
                        Console.WriteLine($"City: {contact.City}");
                        Console.WriteLine($"State: {contact.State}");
                        Console.WriteLine($"Phone: {contact.PhoneNumber}");
                        Console.WriteLine($"Email: {contact.Email}");
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("No matching contacts found\n");
            }
            else
            {
                Console.WriteLine("---------------------------------\n");
            }
        }
        //uc9-feature to search person by city or state in a book
        public void ViewPersonsByCityOrStateInBook()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("No Address Books available\n");
                return;
            }
            //step 1: Select Address Book
            Console.WriteLine("Available Address Books:");
            foreach (string bookName in addressBooks.Keys)
            {
                Console.WriteLine("- " + bookName);
            }
            Console.Write("Enter Address Book name: ");
            string selectedBook = Console.ReadLine();
            if (!addressBooks.ContainsKey(selectedBook))
            {
                Console.WriteLine("Address Book not found\n");
                return;
            }
            //step 2: Choose City or State
            Console.Write("Search by (1) City or (2) State: ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter City/State name: ");
            string searchValue = Console.ReadLine();
            AddressBookModel[] contacts = addressBooks[selectedBook];
            int count = contactCounts[selectedBook];
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                AddressBookModel contact = contacts[i];
                if ((option == 1 && contact.City.Equals(searchValue, StringComparison.OrdinalIgnoreCase)) ||
                    (option == 2 && contact.State.Equals(searchValue, StringComparison.OrdinalIgnoreCase)))
                {
                    if (!found)
                    {
                        Console.WriteLine($"\nPersons in '{selectedBook}' Address Book:");
                        found = true;
                    }
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"Name  : {contact.FirstName} {contact.LastName}");
                    Console.WriteLine($"City  : {contact.City}");
                    Console.WriteLine($"State : {contact.State}");
                    Console.WriteLine($"Phone : {contact.PhoneNumber}");
                    Console.WriteLine($"Email : {contact.Email}");
                }
            }
            if (!found)
            {
                Console.WriteLine("No persons found for the given city/state\n");
            }
            else
            {
                Console.WriteLine("---------------------------------\n");
            }
        }
        //uc10-count person by city or state across all address books
        public void CountPersonsByCityOrState()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("No Address Books available\n");
                return;
            }
            Console.Write("Count by (1) City or (2) State: ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter City/State name: ");
            string searchValue = Console.ReadLine();
            int totalCount = 0;
            foreach (var entry in addressBooks)
            {
                string addressBookName = entry.Key;
                AddressBookModel[] contacts = entry.Value;
                int count = contactCounts[addressBookName];
                for (int i = 0; i < count; i++)
                {
                    AddressBookModel contact = contacts[i];
                    if ((option == 1 && contact.City.Equals(searchValue, StringComparison.OrdinalIgnoreCase)) ||
                        (option == 2 && contact.State.Equals(searchValue, StringComparison.OrdinalIgnoreCase)))
                    {
                        totalCount++;
                    }
                }
            }
            if (option == 1)
            {
                Console.WriteLine($"Total persons in City '{searchValue}': {totalCount}\n");
            }
            else if (option == 2)
            {
                Console.WriteLine($"Total persons in State '{searchValue}': {totalCount}\n");
            }
        }
        //uc11-sort contacts using person name alphabetically
        public void SortContactsByName()
        {
            if (currentAddressBook == null)
            {
                Console.WriteLine("Please select an Address Book first\n");
                return;
            }
            AddressBookModel[] contacts = addressBooks[currentAddressBook];
            int count = contactCounts[currentAddressBook];
            if (count <= 1)
            {
                Console.WriteLine("Not enough contacts to sort\n");
                return;
            }
            //bubble sort by firstName + lastName
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    string name1 = contacts[j].FirstName + contacts[j].LastName;
                    string name2 = contacts[j + 1].FirstName + contacts[j + 1].LastName;
                    if (string.Compare(name1, name2, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        //swap
                        AddressBookModel temp = contacts[j];
                        contacts[j] = contacts[j + 1];
                        contacts[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine($"\nContacts in '{currentAddressBook}' Address Book (Sorted by Name):");
            Console.WriteLine("--------------------------------------------------");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(contacts[i]); // Uses ToString()
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}
