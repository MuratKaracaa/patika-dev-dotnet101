using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace ToDo
{
    internal class Enums_Constants
    {
        public static class Constants
        {
            public const string Menu = "  Lütfen yapmak istediğiniz işlemi seçiniz :)" + Seperator + "\n  (1) Board Listelemek\n  (2) Board'a Kart Eklemek\n  (3) Board'dan Kart Silmek\n  (4) Kart Taşımak";
            public const string ToDo = "ToDo";
            public const string InProgress = "InProgress";
            public const string Done = "Done";
            public const string Empty = "~ BOŞ ~";
            public const string Line = "Line";
            public const string ToDoLine = ToDo + " " + Line;
            public const string InProgressLine = InProgress + " " + Line;
            public const string DoneLine = Done + " " + Line;
            public const string Seperator = " ************************";
            public const string Title = "Başlık      :";
            public const string Content = "İçerik      :";
            public const string AppointedPerson = "Atanan Kişi :";
            public const string Size = "Büyüklük    :";
            public const string BelongingLine = "Line        :";
            public const string EndOfCard = "-";
            public const string EnterTitle = " Başlık Giriniz                                  : ";
            public const string EnterContent = " İçerik Giriniz                                  : ";
            public const string SelectSize = " Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ";
            public const string SelectAppointedPerson = " Kişi Seçiniz                                    : ";
            public static string EnterTitleForOperation(string operation)
            {
                return $"Lütfen {operation} yapmak istediğiniz kartı seçin.\nLütfen kart başlığını yazınız: ";
            }
            public const string FoundCardInformation = "Bulunan Kart Bilgileri";
            public const string PleaseSelectTargetLine = "Lütfen taşımak istediğiniz line'ı seçiniz.\n (1) TODO\n (2) IN PROGRESS\n (3) DONE";
            public static string NoResultsReturnedForOperation(string operation)
            {
                return $" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n * {operation} işlemini sonlandırmak için : (1)\n * Yeniden denemek için : (2)";
            }
            public const string SelectionNotValid = "Geçersiz Seçim Yaptınız!";
            public static List<int> range2 = new(){1,2};
            public static List<int> range3 = new(){1,2,3};
            public const string CardAdded = "Kart Eklendi.";
            public const string CardsRemoved = "Kartlar Silindi.";
            public const string CardRelocated = "Kartın Line'ı Değiştirildi.";
            public const string AppointedPersonDoesNotExist = "Kart atamaya çalıştığınız kişi atanabilecekler listesinde yer almamaktadır.";
            public const string OperationCardRemove = "Kart Silme";
            public const string OperationRelocateCard = "Line Değiştirme";
        }

        public enum Sizes
        {
            XS = 1,
            S,
            M,
            L,
            XL
        }

        public enum Lines
        {
            ToDo = 1,
            InProgress,
            Done
        }

        public enum Menu
        {
            PromptMenu,
            PrintCards,
            AddCardToBoard,
            RemoveCardFromBoard,
            RelocateCard
        }
    }
}
