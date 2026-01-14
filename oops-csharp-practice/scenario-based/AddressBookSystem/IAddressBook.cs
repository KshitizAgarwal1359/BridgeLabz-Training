using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabz.AddressBookSystem
{
        interface IAddressBook
        {
        void DisplayWelcomeMessage(AddressBookModel model); //uc0
        void AddNewContact(); //uc2    
        void DisplayAllContacts(); //uc2
        void EditContact(); //uc3
        }
}
