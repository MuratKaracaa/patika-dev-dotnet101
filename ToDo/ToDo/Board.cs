using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDo
{
    internal class Board : IBoard
    {
        private static List<Card> toDoLine;
        private static List<Card> inProgressLine;
        private static List<Card> doneLine;

        public Board(){}

        static Board()
        {
            toDoLine = new List<Card>();
            inProgressLine = new List<Card>();
            doneLine = new List<Card>();
        }

        public void PrintCard(string lineName , List<Card> list)
        {
            Console.WriteLine(lineName + "Line");
            Console.WriteLine(" ************************");
            if (list.Count == 0) ; Console.WriteLine("~ BOŞ ~");
            else
            {
                foreach (Card card in list)
                {
                    Console.WriteLine("Başlık      :" + card.Title);
                    Console.WriteLine("İçerik      :" + card.Content);
                    Console.WriteLine("Atanan Kişi :" + card.Person);
                    Console.WriteLine("Büyüklük    :" + card.Size);
                    Console.WriteLine("-");
                }
            }            
        }

        public void AddCardToBoard(Card card)
        {
            toDoLine.Add(card);
        }

        public void RemoveCardFromBoard(string title)
        {
            toDoLine.Concat(inProgressLine).Concat(doneLine).ToList().RemoveAll(x => x.Title.Equals(title));
        }

        public void RelocateCard(List<Card> list, Card card)
        {
            
        }

        public void 
    }
}
