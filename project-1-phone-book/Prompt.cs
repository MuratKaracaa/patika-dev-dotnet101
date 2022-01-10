using System;
using System.Collections.Generic;

namespace project_1_phone_book
{
    public class Prompt
    {
        public static int PromptMenu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            int i = -1;
            try
            {
                i = int.Parse(Console.ReadLine());
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return i;
        }

        public static Contact PromptAddContact()
        {
            string name = string.Empty, lastName = string.Empty;
            int phoneNumber = 0;
            try
            {
                Console.Write("Lütfen isim giriniz             : ");
                name = Console.ReadLine();
                Console.Write("Lütfen soyisim giriniz          : ");
                lastName = Console.ReadLine();
                Console.Write("Lütfen telefon numarası giriniz : ");
                phoneNumber = int.Parse(Console.ReadLine());
            }
            catch (System.Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Contact contact = new Contact(name, lastName, phoneNumber);
            return contact;
        }

        public static int PromptNotFoundBySearchCriteria(string type)
        {
            try
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine($" * {type}yi sonlandırmak için : (1)");
                Console.WriteLine(" * Yeniden denemek için      : (2)");
                int selection = int.Parse(Console.ReadLine());
                checkSelection(selection);
                if (selection == 2) return 2;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        public static bool PromptApproveDeletion()
        {
            bool selection = false;
            try
            {
                Console.Write("isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string input = Console.ReadLine();
                checkSelection(input);
                selection = input == "y" ? true : selection;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                PromptApproveDeletion();
            }
            return selection;
        }

        public static string PromptNameOrLastNameInput(string type)
        {
            Console.Write($"Lütfen numarasını {type} istediğiniz kişinin adını ya da soyadını giriniz: ");
            string input = Console.ReadLine();
            return input;
        }

        public static int PromptPhoneNumberToUpdate()
        {
            Console.Write("Lütfen yeni numarayı giriniz: ");
            int input = 0;
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (System.Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return input;
        }

        public static int PromptSearchCriteria()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            int selection = -1;
            try
            {
                Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                selection = int.Parse(Console.ReadLine());
                checkSelection(selection);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                PromptSearchCriteria();
            }
            return selection;
        }

        public static int PromptAlphabeticalOrder()
        {
            Console.WriteLine("Sıralama seçeneği seçiniz:");
            Console.WriteLine("[A-Z] (1)");
            Console.WriteLine("[Z-A] (2)");
            int i = 1;
            try
            {
                i = int.Parse(Console.ReadLine());
                checkSelection(i);
                if (i == 2) i = 2;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                PromptAlphabeticalOrder();
            }

            return i;
        }

        public static int PromptPhoneNumberToFind()
        {
            Console.Write("Lütfen bulmak istediğiniz kişi bilgilerine ait telefon numarasını giriniz:");
            int i = 0;
            try
            {
                i = int.Parse(Console.ReadLine());
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                PromptPhoneNumberToFind();
            }
            return i;
        }

        private static void checkSelection(int selection)
        {
            List<int> selectionOptions = new List<int>() { 1, 2 };
            if (!selectionOptions.Contains(selection)) throw new Exception("Geçerli bir tercih yapınız");
        }

        private static void checkSelection(string selection)
        {
            List<string> selectionOptions = new List<string>() { "y", "n" };
            if (!selectionOptions.Contains(selection)) throw new Exception("Geçerli bir tercih yapınız");
        }
    }
}