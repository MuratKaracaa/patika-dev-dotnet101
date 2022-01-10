using System;

namespace project_1_phone_book
{
    public class Promt
    {
        public static int PromtMenu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
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

        public static string PromptDeleteNumber()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string nameOrLastName = Console.ReadLine();
            return nameOrLastName;
        }

        public static int PromptNotFoundBySearchCriteria(string type)
        {
            int selection = -1;
            try
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine($" * {type}yi sonlandırmak için : (1)");
                Console.WriteLine(" * Yeniden denemek için      : (2)");
                selection = int.Parse(Console.ReadLine());
                if (selection != 1 || selection != 2) throw new Exception("Geçerli bir tercih yapınız");
            }
            catch (System.Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return selection;
        }

        public static bool PromptApproveDeletion()
        {
            bool selection = false;
            try
            {
                Console.Write("isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string input = Console.ReadLine();
                if (input != "y" || input != "n") throw new Exception("Geçerli bir tercih yapınız");
                selection = input == "y" ? true : selection;
            }
            catch (System.Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return selection;
        }

        public static string PromptUpdateContactNameOrLastName()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string input = Console.ReadLine();
            return input;
        }

        public static int PromptPhoneNumberToUpdate()
        {
            Console.Write("Lütfen yeni numarayı giriniz: ");
            int input = -1;
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
                if (selection != 1 || selection != 2) throw new Exception("Geçerli bir tercih yapınız");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return selection;
        }

    }
}