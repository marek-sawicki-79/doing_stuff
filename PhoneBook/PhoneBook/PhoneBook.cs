using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class PhoneBook
    {
        static List<Contact> Contacts { get; set; } = new List<Contact>()
        {
            new Contact("Ala", "123456789"),
            new Contact("Lolek", "222233664"),
            new Contact("Koralgol", "789456123"),
            new Contact("Tola", "456798231"),
            new Contact("Ala", "963258741"),
            new Contact("Kazmirz", "147852369"),
            new Contact("Picipolo", "321654789"),
            new Contact("Zwirek", "608689756"),
            new Contact("Muchomorek", "668354388"),
            new Contact("Dudi", "709262058")
        };

        private void ShowContact(Contact contact)
        {
            Console.WriteLine($"Searched contact: {contact.Name},\t\t {contact.Number}");
        }

        private void IterateContacts(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                ShowContact(contact);
            }
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public void RemoveContact(string removingContact)
        {
            Contacts.RemoveAll(c => c.Name.ToLower().Contains(removingContact.ToLower()));
        }

        public void FindContactByNumber(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);

            if (contact == null)
            {
                Console.WriteLine($"No contact for {number} found in your phone book.");
            }
            else
            {
                ShowContact(contact);
            }
        }

        public void ShowAllContacts()
        {
            IterateContacts(Contacts);
        }

        public void FindContactsByName(string searchedContact)
        {
            var foundContacts = Contacts.Where(c => c.Name.ToLower().Contains(searchedContact.ToLower())).ToList();
            IterateContacts(foundContacts);
        }
    }
}
