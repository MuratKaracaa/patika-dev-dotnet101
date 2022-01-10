using System;

namespace project_1_phone_book
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Prompt.PromptMenu();
            int search_param = 0;
            string searchParam = string.Empty;
            int input = 0;
            PhoneBook pb = new();
            while (i >= 0 && i <= 5)
            {
                switch (i)
                {
                    case 0:
                        i = Prompt.PromptMenu();
                        break;
                    case 1:
                        Contact newContact = Prompt.PromptAddContact();
                        i = pb.AddContactToBook(newContact);
                        break;
                    case 2:
                        searchParam = Prompt.PromptNameOrLastNameInput("silmek");
                        i = pb.DeletePhoneNumberFromBook(searchParam);
                        break;
                    case 3:
                        searchParam = Prompt.PromptNameOrLastNameInput("güncellemek");
                        input = Prompt.PromptPhoneNumberToUpdate();
                        i = pb.UpdateContact(searchParam, input);
                        break;
                    case 4:
                        input = Prompt.PromptAlphabeticalOrder();
                        i = pb.ListBook(input);
                        break;
                    case 5:
                        input = Prompt.PromptSearchCriteria();
                        if (input == 1)
                        {
                            searchParam = Prompt.PromptNameOrLastNameInput("aramak");
                            i = pb.FindFromBook(searchParam);
                        }
                        if (input == 2)
                        {
                            search_param = Prompt.PromptPhoneNumberToFind();
                            i = pb.FindFromBook(search_param);
                        }
                        break;
                }
            }
            Console.WriteLine("Görüşmek üzere!");
        }
    }
}
