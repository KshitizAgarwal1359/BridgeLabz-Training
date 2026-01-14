using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.AddressBookSystem
{
    
        interface IAddressBook
        {
            void DisplayWelcomeMessage(AddressBookModel model);
            void DisplayContact(AddressBookModel model);
        }
    

}
