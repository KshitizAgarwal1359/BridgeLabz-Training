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
                Console.WriteLine("1. Add New Contact");
                Console.WriteLine("2. Display All Contacts");
                Console.WriteLine("3. Edit Existing Contact");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        service.AddNewContact(); break;
                    case 2:
                        service.DisplayAllContacts(); break;
                    case 3:
                        service.EditContact();break;
                    case 4:
                        Console.WriteLine("Exiting Address Book Application...");
                        exit = true; break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.\n"); break;
                }
            }
        }
    }
}
