using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBookThreading;
using System.Collections.Generic;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMultipleContacts_WhenAddedTOList_ShouldMatchContactEntries()
        {
            List<ContactDetails> contactDetails = new List<ContactDetails>();
            contactDetails.Add(new ContactDetails { FirstName = "Kumar", LastName = "Kartikeya", Address = "India", City = "Agra" });
            contactDetails.Add(new ContactDetails { FirstName = "Robert", LastName = "Lewandowski", Address = "Poland", City = "Warsaw" });
            contactDetails.Add(new ContactDetails { FirstName = "Douglas", LastName = "Costa", Address = "Brazil", City = "Sapucaia do Sul" });
            contactDetails.Add(new ContactDetails { FirstName = "Meg", LastName = "Lanning", Address = "Australia", City = "Sydney" });
            AddressOperations addressOperations = new AddressOperations();
            // UC 21
            DateTime startDateTimeThread = DateTime.Now;
            addressOperations.AddContactToAddressbookWithThread(contactDetails);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with thread: " + (stopDateTimeThread - startDateTimeThread));
        }
    }
}
