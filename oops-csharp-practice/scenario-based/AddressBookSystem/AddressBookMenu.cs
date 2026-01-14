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
            // UC0
            model.WelcomeMessage = "WELCOME TO ADDRESS BOOK SYSTEM";
            IAddressBook service = new AddressBookUtilityImpl();
            service.DisplayWelcomeMessage(model);
            // UC1
            model.AddContact();
            service.DisplayContact(model);
        }
    }
}
