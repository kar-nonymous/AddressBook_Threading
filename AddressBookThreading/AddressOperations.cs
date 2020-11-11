using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AddressBookThreading
{
    public class AddressOperations
    {
        /// <summary>
        /// Creating the list
        /// </summary>
        public List<ContactDetails> adressBookList = new List<ContactDetails>();
        /// <summary>
        /// UC 21:
        /// Add multiple contacts to the address book
        /// </summary>
        /// <param name="adressBookList"></param>
        public void AddContactToAddressbookWithThread(List<ContactDetails> adressBookList)
        {
            adressBookList.ForEach(contactData =>
            {
                Thread thread = new Thread(() =>
                {
                    Console.WriteLine(" Employee being added: " + contactData.FirstName);
                    this.addEmployeePayroll(contactData);
                    Console.WriteLine(" Employee added: " + contactData.FirstName);
                });
                thread.Start();
            });
            Console.WriteLine(this.adressBookList.Count);
        }
        public void addEmployeePayroll(ContactDetails contact)
        {
            adressBookList.Add(contact);
        }
    }
}
