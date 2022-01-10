using System;
using System.Collections.Generic;
using System.Linq;

namespace project_1_phone_book
{
    public class PhoneBook : IPhoneBook
    {
        private static List<Contact> book;

        public PhoneBook() { }

        static PhoneBook()
        {
            book = new List<Contact>();
            Contact mock1 = new Contact("mock1", "mock1Last", 48598543);
            Contact mock2 = new Contact("mock2", "mock2Last", 66516162);
            Contact mock3 = new Contact("mock3", "mock3Last", 89784525);
            Contact mock4 = new Contact("mock4", "mock4Last", 68461715);
            Contact mock5 = new Contact("mock5", "mock5Last", 13465162);
            book.Add(mock3);
            book.Add(mock1);
            book.Add(mock5);
            book.Add(mock4);
            book.Add(mock2);
        }

        public int ListBook(int asc)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            //book = book.OrderBy(contact => contact.Name).ToList();
            book.Sort((c1, c2) => c1.Name.CompareTo(c2.Name));
            if (asc == 1) foreach (Contact contact in book) PrintContact(contact);
            else if (asc == 2) for (int i = book.Count - 1; i >= 0; i--) PrintContact(book[i]);
            return 0;
        }

        public int AddContactToBook(Contact contact)
        {
            book.Add(contact);
            Console.WriteLine("Numara Eklendi!");
            return 0;
        }

        public int DeletePhoneNumberFromBook(string searchParam)
        {
            book.Sort((c1, c2) => c1.Name.CompareTo(c2.Name));
            Contact contactToRemove = book.Find(contact => contact.Name == searchParam || contact.LastName == searchParam);
            int i = 0;
            try
            {
                contactToRemove.GetType();
                bool approved = Prompt.PromptApproveDeletion();
                if (approved)
                {
                    book.Remove(contactToRemove);
                    Console.WriteLine("Silme işlemi başarılı");
                }
                else
                    return i;

            }
            catch (System.Exception ex)
            {
                string message = ex.Message;
                i = Prompt.PromptNotFoundBySearchCriteria("Silme");
            }
            return i;
        }

        public int FindFromBook(int phoneNumber)
        {
            List<Contact> foundContacts = book.FindAll(contact => contact.PhoneNumber.Equals(phoneNumber));
            int i = 0;
            try
            {
                foundContacts.GetType();
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                foreach (Contact contact in foundContacts) PrintContact(contact);
            }
            catch (System.Exception ex)
            {
                string message = ex.Message;
                Prompt.PromptNotFoundBySearchCriteria("Arama");
                i = int.Parse(Console.ReadLine());
            }
            return i;

        }

        public int FindFromBook(string searchParam)
        {
            List<Contact> foundContacts = book.FindAll(contact => contact.Name.Contains(searchParam) || contact.LastName.Contains(searchParam));
            int i = 0;
            try
            {
                foundContacts.GetType();
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine(" **********************************************");
                foreach (Contact contact in foundContacts) PrintContact(contact);
            }
            catch (System.Exception ex)
            {
                string message = ex.Message;
                Prompt.PromptNotFoundBySearchCriteria("Arama");
                i = int.Parse(Console.ReadLine());
            }
            return i;
        }

        public int UpdateContact(string searchParam, int phoneNumber)
        {
            int i = 0;
            Contact contactToUpdate = book.Find(contact => contact.Name == searchParam || contact.LastName == searchParam);
            try
            {
                contactToUpdate.GetType();
                contactToUpdate.PhoneNumber = phoneNumber;
                Console.WriteLine("Contact başarıyla güncellendi.");
            }
            catch (System.Exception ex)
            {
                string message = ex.Message;
                i = Prompt.PromptNotFoundBySearchCriteria("Güncelleme");
            }
            return i;

        }

        private void PrintContact(Contact contact)
        {
            Console.WriteLine($"İsim: {contact.Name}");
            Console.WriteLine($"Soyisim: {contact.LastName}");
            Console.WriteLine($"Telefon Numarası: {contact.PhoneNumber}");
            Console.WriteLine("-");
        }
    }
}