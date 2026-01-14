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
                Console.WriteLine("2. Add New Contact");
                Console.WriteLine("3. Display All Contacts");
                Console.WriteLine("4. Edit Existing Contact");
                Console.WriteLine("5. Delete a contact");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        service.CreateAddressBook(); break;
                    case 2:
                        service.AddNewContact(); break;
                    case 3:
                        service.DisplayAllContacts(); break;
                    case 4:
                        service.EditContact();break;
                    case 5:
                        service.DeleteContact(); break;
                    case 6:
                        Console.WriteLine("Exiting Address Book Application...");
                        exit = true; break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.\n"); break;
                }
            }
        }
    }
}
