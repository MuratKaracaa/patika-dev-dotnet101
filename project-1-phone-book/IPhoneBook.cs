namespace project_1_phone_book
{
    public interface IPhoneBook
    {
        void ListBook(int selection);
        void AddContactToBook(Contact contact);
        void DeletePhoneNumberFromBook(int phoneNumber);
        void FindFromBook(int phoneNumber);
        void UpdateContact(string searchParam, int phoneNumber);
        void PrintContact(Contact contact);

    }
}