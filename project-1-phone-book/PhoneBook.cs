using System;
using System.Collections.Generic;
using System.Linq;

namespace project_1_phone_book
{
    public class PhoneBook : IPhoneBook
    {
        private static List<Contact> book;

        public PhoneBook() { }

        public void ListBook(int selection)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            book.OrderBy(contact => contact.Name).ToList();
            if (selection == 1) foreach (Contact contact in book) PrintContact(contact);
            else if (selection == 2) for (int i = book.Count - 1; i >= 0; i--) PrintContact(book[i]);
        }

        public void AddContactToBook(Contact contact)
        {
            book.Add(contact);
        }

        public void DeletePhoneNumberFromBook(int phoneNumber)
        {
            Contact contactToRemove = book.Find(contact => contact.PhoneNumber == phoneNumber);
            book.Remove(contactToRemove);
        }

        public void FindFromBook(int phoneNumber)
        {
            List<Contact> foundContacts = book.FindAll(contact => contact.PhoneNumber == phoneNumber);
            Console.WriteLine("Arama Sonuçlarınız:");
            Console.WriteLine("**********************************************");
            foreach (Contact contact in foundContacts) PrintContact(contact);

        }

        public void FindFromBook(string searchParam)
        {
            List<Contact> foundContacts = book.FindAll(contact => contact.Name == searchParam || contact.LastName == searchParam);
            Console.WriteLine("Arama Sonuçlarınız:");
            Console.WriteLine(" **********************************************");
            foreach (Contact contact in foundContacts) PrintContact(contact);
        }

        public void UpdateContact(string searchParam, int phoneNumber)
        {
            Contact contactToUpdate = book.Find(contact => contact.Name == searchParam || contact.LastName == searchParam);
            contactToUpdate.PhoneNumber = phoneNumber;
        }

        public void PrintContact(Contact contact)
        {
            Console.WriteLine($"İsim: {contact.Name}");
            Console.WriteLine($"Soyisim: {contact.LastName}");
            Console.WriteLine($"Telefon Numarası: {contact.PhoneNumber}");
            Console.WriteLine("-");
        }
    }
}