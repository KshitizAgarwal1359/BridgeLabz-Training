using System;
namespace BridgeLabz.AddressBookSystem
{
    class AddressBookUtilityImpl : IAddressBook
    {
        // UC0 - Display Welcome Message
        public void DisplayWelcomeMessage(AddressBookModel model)
        {
            Console.WriteLine("====================================");
            Console.WriteLine(model.WelcomeMessage);
            Console.WriteLine("====================================\n");
        }
        // UC1 - Display Contact Details
        public void DisplayContact(AddressBookModel model)
        {
            Console.WriteLine("----- Contact Details -----");
            Console.WriteLine($"Name   : {model.FirstName} {model.LastName}");
            Console.WriteLine($"Address: {model.Address}");
            Console.WriteLine($"City   : {model.City}");
            Console.WriteLine($"State  : {model.State}");
            Console.WriteLine($"Zip    : {model.Zip}");
            Console.WriteLine($"Phone  : {model.PhoneNumber}");
            Console.WriteLine($"Email  : {model.Email}");
            Console.WriteLine("---------------------------");
        }
    }
}
