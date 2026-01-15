using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabz.AddressBookSystem
{
    class AddressBookMenu
    {
        public static void Start()
        {
            AddressBookModel model = new AddressBookModel();
            model.WelcomeMessage = "WELCOME TO ADDRESS BOOK SYSTEM";
            IAddressBook service = new AddressBookUtilityImpl();
            service.DisplayWelcomeMessage(model);
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Create Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Add New Contact");
                Console.WriteLine("4. Display All Contacts");
                Console.WriteLine("5. Edit Existing Contact");
                Console.WriteLine("6. Delete a contact");
                Console.WriteLine("7. Search Person by City or State");
                Console.WriteLine("8. View Persons by City or State (Specific Address Book)");
                Console.WriteLine("9. Count Persons by City or State");
                Console.WriteLine("10. Sort Contacts by Name");
                Console.WriteLine("11. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        service.CreateAddressBook(); break;
                    case 2:
                        service.SelectAddressBook(); break;
                    case 3:
                        service.AddNewContact(); break;
                    case 4:
                        service.DisplayAllContacts(); break;
                    case 5:
                        service.EditContact();break;
                    case 6:
                        service.DeleteContact(); break;
                    case 7:
                        service.SearchPersonByCityOrState(); break;
                    case 8:
                        service.ViewPersonsByCityOrStateInBook(); break;
                    case 9:
                        service.CountPersonsByCityOrState(); break;
                    case 10:
                        service.SortContactsByName(); break;
                    case 11:
                        Console.WriteLine("Exiting Address Book Application...");
                        exit = true; break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.\n"); break;
                }
            }
        }
    }
}
