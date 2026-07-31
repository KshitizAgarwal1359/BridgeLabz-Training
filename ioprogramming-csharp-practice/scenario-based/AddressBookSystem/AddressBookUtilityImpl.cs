using System;
using System.IO;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using System.Text.Json;
namespace BridgeLabz.AddressBookSystem
{
    class AddressBookUtilityImpl : IAddressBook
    {
        //uc6 – Dictionary of Address Books
        private Dictionary<string, List<AddressBookModel>> addressBooks;
        private string currentAddressBook;
        public AddressBookUtilityImpl()
        {
            addressBooks = new Dictionary<string, List<AddressBookModel>>();
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
            if (string.IsNullOrWhiteSpace(name))
                throw new EmptyInputException("Address Book name cannot be empty");
            if (addressBooks.ContainsKey(name))
                throw new DuplicateContactException("Address Book already exists");
            addressBooks.Add(name, new List<AddressBookModel>());
            currentAddressBook = name;
            Console.WriteLine($"Address Book '{name}' created and selected\n");
        }
        //uc1+uc2+uc5 - add New Contact reusing add contact for uc5, no extra code needed add number selected address book 
        public void AddNewContact()
        {
            if (currentAddressBook == null)
                throw new EmptyInputException("Select an Address Book first");
            AddressBookModel contact = new AddressBookModel();
            contact.AddContact();
            List<AddressBookModel> contacts = addressBooks[currentAddressBook];
            if (contacts.Contains(contact))
                throw new DuplicateContactException("Duplicate contact not allowed");
            contacts.Add(contact);
            Console.WriteLine("Contact added successfully\n");
        }
        //uc2- display All Contacts
        public void DisplayAllContacts()
        {
            if (currentAddressBook == null)
                throw new EmptyInputException("Select Address Book first");
            foreach (AddressBookModel contact in addressBooks[currentAddressBook])
            {
                Console.WriteLine(contact);
                Console.WriteLine("------------------------");
            }
        }
        //uc3 – Edit contact using name
        public void EditContact()
        {
            Console.Write("Enter First Name to edit: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
                throw new EmptyInputException("Name cannot be empty");
            List<AddressBookModel> contacts = addressBooks[currentAddressBook];
            AddressBookModel contact = contacts.Find(c => c.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (contact == null)
                throw new ContactNotFoundException("Contact not found");
            Console.Write("Enter New City: ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Contact updated successfully\n");
        }
        //uc4 - delete the contact using name
        public void DeleteContact()
        {
            Console.Write("Enter First Name to delete: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
                throw new EmptyInputException("Name cannot be empty");
            List<AddressBookModel> contacts = addressBooks[currentAddressBook];
            AddressBookModel contact = contacts.Find(c => c.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (contact == null)
                throw new ContactNotFoundException("Contact not found");
            contacts.Remove(contact);
            Console.WriteLine("Contact deleted successfully\n");
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
                Console.WriteLine("- " + name);
            Console.Write("Enter Address Book name: ");
            string nameToSelect = Console.ReadLine();
            if (!addressBooks.ContainsKey(nameToSelect))
                throw new ContactNotFoundException("Address Book not found");
            currentAddressBook = nameToSelect;
            Console.WriteLine($"'{currentAddressBook}' selected\n");
        }
        //uc8 searching person by city or state
        public void SearchPersonByCityOrState()
        {
            if (addressBooks.Count == 0)
                throw new ContactNotFoundException("No Address Books available");
            Console.Write("Search by (1) City or (2) State: ");
            if (!int.TryParse(Console.ReadLine(), out int option))
                throw new InvalidMenuChoiceException("Invalid option");
            Console.Write("Enter City/State name: ");
            string value = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(value))
                throw new EmptyInputException("Search value cannot be empty");
            bool found = false;
            foreach (var entry in addressBooks)
            {
                foreach (AddressBookModel contact in entry.Value)
                {
                    bool match =
                        (option == 1 && contact.City.Equals(value, StringComparison.OrdinalIgnoreCase)) ||
                        (option == 2 && contact.State.Equals(value, StringComparison.OrdinalIgnoreCase));
                    if (match)
                    {
                        if (!found)
                        {
                            Console.WriteLine("\nSearch Results:");
                            found = true;
                        }
                        Console.WriteLine($"Address Book: {entry.Key}");
                        Console.WriteLine(contact);
                        Console.WriteLine("----------------------");
                    }
                }
            }
            if (!found)
                throw new ContactNotFoundException("No matching persons found");
        }
        //uc9-feature to search person by city or state in a book
        public void ViewPersonsByCityOrStateInBook()
        {
            if (currentAddressBook == null)
                throw new EmptyInputException("Select an Address Book first");
            Console.Write("Search by (1) City or (2) State: ");
            if (!int.TryParse(Console.ReadLine(), out int option))
                throw new InvalidMenuChoiceException("Invalid option");
            Console.Write("Enter City/State name: ");
            string value = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(value))
                throw new EmptyInputException("Search value cannot be empty");
            List<AddressBookModel> contacts = addressBooks[currentAddressBook];
            bool found = false;
            foreach (AddressBookModel contact in contacts)
            {
                bool match =
                    (option == 1 && contact.City.Equals(value, StringComparison.OrdinalIgnoreCase)) ||
                    (option == 2 && contact.State.Equals(value, StringComparison.OrdinalIgnoreCase));
                if (match)
                {
                    if (!found)
                    {
                        Console.WriteLine($"\nPersons in '{currentAddressBook}':");
                        found = true;
                    }
                    Console.WriteLine(contact);
                    Console.WriteLine("----------------------");
                }
            }
            if (!found)
                throw new ContactNotFoundException("No persons found in this Address Book");
        }
        //uc10-count person by city or state across all address books
        public void CountPersonsByCityOrState()
        {
            if (addressBooks.Count == 0)
                throw new ContactNotFoundException("No Address Books available");
            Console.Write("Count by (1) City or (2) State: ");
            if (!int.TryParse(Console.ReadLine(), out int option))
                throw new InvalidMenuChoiceException("Invalid option");
            Console.Write("Enter City/State name: ");
            string value = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(value))
                throw new EmptyInputException("Search value cannot be empty");
            int count = 0;
            foreach (var entry in addressBooks)
            {
                count += entry.Value.Count(contact =>
                    (option == 1 && contact.City.Equals(value, StringComparison.OrdinalIgnoreCase)) ||
                    (option == 2 && contact.State.Equals(value, StringComparison.OrdinalIgnoreCase))
                );
            }
            Console.WriteLine($"Total persons found: {count}\n");
        }
        //uc11-sort contacts using person name alphabetically
        public void SortContactsByName()
        {
            if (currentAddressBook == null)
                throw new EmptyInputException("Select an Address Book first");
            List<AddressBookModel> contacts = addressBooks[currentAddressBook];
            if (contacts.Count <= 1)
            {
                Console.WriteLine("Not enough contacts to sort\n");
                return;
            }
            contacts.Sort((c1, c2) =>
                string.Compare(
                    c1.FirstName + c1.LastName,
                    c2.FirstName + c2.LastName,
                    StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"\nSorted Contacts in '{currentAddressBook}':");
            foreach (AddressBookModel contact in contacts)
            {
                Console.WriteLine(contact); // uses ToString()
                Console.WriteLine("----------------------");
            }
        }
        //uc 12 - sorting contancts by location by city, state, ZIP
        public void SortContactsByLocation()
        {
            if (currentAddressBook == null)
                throw new EmptyInputException("Select an Address Book first");
            List<AddressBookModel> contacts = addressBooks[currentAddressBook];
            if (contacts.Count <= 1)
            {
                Console.WriteLine("Not enough contacts to sort\n");
                return;
            }
            Console.WriteLine("Sort by:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            Console.WriteLine("3. Zip");
            Console.Write("Enter the option number: ");
            if (!int.TryParse(Console.ReadLine(), out int option))
                throw new InvalidMenuChoiceException("Invalid sorting option");
            switch (option)
            {
                case 1:
                    contacts.Sort((c1, c2) =>
                        string.Compare(c1.City, c2.City, StringComparison.OrdinalIgnoreCase));
                    break;
                case 2:
                    contacts.Sort((c1, c2) =>
                        string.Compare(c1.State, c2.State, StringComparison.OrdinalIgnoreCase));
                    break;
                case 3:
                    contacts.Sort((c1, c2) =>
                        string.Compare(c1.Zip, c2.Zip, StringComparison.OrdinalIgnoreCase));
                    break;
                default:
                    throw new InvalidMenuChoiceException("Invalid sorting choice");
            }
            Console.WriteLine($"\nSorted Contacts in '{currentAddressBook}':");
            foreach (AddressBookModel contact in contacts)
            {
                Console.WriteLine(contact); // Uses overridden ToString()
                Console.WriteLine("----------------------");
            }
        }
        //uc13 - feature to write to file
        public void WriteAddressBookToFile()
        {
            if (currentAddressBook == null)
                throw new EmptyInputException("Select an Address Book first");
            string fileName = currentAddressBook + ".txt";
            List<AddressBookModel> contacts = addressBooks[currentAddressBook];
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (AddressBookModel contact in contacts)
                {
                    writer.WriteLine(
                        $"{contact.FirstName},{contact.LastName},{contact.City},{contact.State},{contact.Zip},{contact.PhoneNumber},{contact.Email}");
                }
            }
            Console.WriteLine($"Address Book saved to file '{fileName}'\n");
        }
        //uc13 - feature to read from file
        public void ReadAddressBookFromFile()
        {
            Console.Write("Enter Address Book name to load: ");
            string bookName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(bookName))
                throw new EmptyInputException("Address Book name cannot be empty");
            string fileName = bookName + ".txt";
            if (!File.Exists(fileName))
                throw new ContactNotFoundException("File does not exist");
            List<AddressBookModel> contacts = new List<AddressBookModel>();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    if (data.Length == 7)
                    {
                        AddressBookModel contact = new AddressBookModel
                        {
                            FirstName = data[0],
                            LastName = data[1],
                            City = data[2],
                            State = data[3],
                            Zip = data[4],
                            PhoneNumber = data[5],
                            Email = data[6]
                        };
                        contacts.Add(contact);
                    }
                }
            }
            addressBooks[bookName] = contacts;
            currentAddressBook = bookName;
            Console.WriteLine($"Address Book '{bookName}' loaded successfully\n");
        }
        //uc 14 - feature to write in CSV file
        public void WriteAddressBookToCSV()
        {
            if (currentAddressBook == null)
                throw new EmptyInputException("Select an Address Book first");
            string fileName = currentAddressBook + ".csv";
            List<AddressBookModel> contacts = addressBooks[currentAddressBook];
            using (var writer = new StreamWriter(fileName))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(contacts);
            }
            Console.WriteLine($"Address Book exported to CSV file '{fileName}'\n");
        }
        //uc 14 - feature to write contact to Csv file
        public void ReadAddressBookFromCSV()
        {
            Console.Write("Enter Address Book name to load: ");
            string bookName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(bookName))
                throw new EmptyInputException("Address Book name cannot be empty");
            string fileName = bookName + ".csv";
            if (!File.Exists(fileName))
                throw new ContactNotFoundException("CSV file does not exist");
            List<AddressBookModel> contacts;
            using (var reader = new StreamReader(fileName))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                contacts = csv.GetRecords<AddressBookModel>().ToList();
            }
            addressBooks[bookName] = contacts;
            currentAddressBook = bookName;
            Console.WriteLine($"Address Book '{bookName}' loaded from CSV successfully\n");
        }
        //uc15 - feature to write contacts in JSON file
        public void WriteAddressBookToJson()
        {
            if (currentAddressBook == null)
                throw new EmptyInputException("Select an Address Book first");
            string fileName = currentAddressBook + ".json";
            List<AddressBookModel> contacts = addressBooks[currentAddressBook];
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(contacts, options);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine($"Address Book saved as JSON file '{fileName}'\n");
        }
        public void ReadAddressBookFromJson()
        {
            Console.Write("Enter Address Book name to load: ");
            string bookName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(bookName))
                throw new EmptyInputException("Address Book name cannot be empty");
            string fileName = bookName + ".json";
            if (!File.Exists(fileName))
                throw new ContactNotFoundException("JSON file does not exist");
            string jsonString = File.ReadAllText(fileName);
            List<AddressBookModel> contacts = JsonSerializer.Deserialize<List<AddressBookModel>>(jsonString);
            addressBooks[bookName] = contacts;
            currentAddressBook = bookName;
            Console.WriteLine($"Address Book '{bookName}' loaded from JSON successfully\n");
        }
    }
}
