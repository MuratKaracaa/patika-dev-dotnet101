namespace project_1_phone_book
{
    public interface IPhoneBook
    {
        int ListBook(int selection);
        int AddContactToBook(Contact contact);
        int DeletePhoneNumberFromBook(string searchParam);
        int FindFromBook(int phoneNumber);
        int FindFromBook(string searchParam);
        int UpdateContact(string searchParam, int phoneNumber);
    }
}