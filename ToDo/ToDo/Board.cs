using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDo
{
    internal class Board : IBoard
    {
        private static List<Card> cards;

        public Board(){}

        static Board()
        {
            cards = new List<Card>();
            for (int i = 1; i <= 3; i++) cards.Add(new($"Mock Card {i}", $"Mock Content {i}" , i , i));
        }

        public int PrintCards()
        {
            List<Card> toDo = new List<Card>();
            List<Card> inProgress = new List<Card>();
            List<Card> done = new List<Card>();
            if (cards.Count == 0) Console.WriteLine(Enums_Constants.Constants.Empty);
            else
            {
                foreach (Card card in cards)
                {
                    switch(card.Line)
                    {
                        case Enums_Constants.Constants.ToDo:
                            toDo.Add(card);
                            break;
                        case Enums_Constants.Constants.InProgress:
                            inProgress.Add(card);
                            break;
                        case Enums_Constants.Constants.Done:
                            done.Add(card);
                            break;
                    }
                }
                Console.WriteLine(Enums_Constants.Constants.ToDoLine);
                Console.WriteLine(Enums_Constants.Constants.Seperator);
                foreach (Card card in toDo) PrintCardL(Enums_Constants.Constants.ToDo, card);
                Console.WriteLine(Enums_Constants.Constants.InProgressLine);
                Console.WriteLine(Enums_Constants.Constants.Seperator);
                foreach (Card card in inProgress) PrintCardL(Enums_Constants.Constants.InProgress, card);
                Console.WriteLine(Enums_Constants.Constants.DoneLine);
                Console.WriteLine(Enums_Constants.Constants.Seperator);
                foreach (Card card in done) PrintCardL(Enums_Constants.Constants.Done, card);
            }
            return (int)Enums_Constants.Menu.PromptMenu;
        }

        static void PrintCardL(string lineName, Card card)
        {            
            Console.WriteLine(Enums_Constants.Constants.Title + card.Title);
            Console.WriteLine(Enums_Constants.Constants.Content + card.Content);
            Console.WriteLine(Enums_Constants.Constants.AppointedPerson + card.AppointedPerson);
            Console.WriteLine(Enums_Constants.Constants.Size + Enum.GetName(typeof(Enums_Constants.Sizes), card.Size));
            Console.WriteLine(Enums_Constants.Constants.EndOfCard);
        }

        public static void PrintCard(Card card)
        {
            Console.WriteLine(Enums_Constants.Constants.FoundCardInformation);
            Console.WriteLine(Enums_Constants.Constants.Seperator);
            Console.WriteLine(Enums_Constants.Constants.Title + card.Title);
            Console.WriteLine(Enums_Constants.Constants.Content + card.Content);
            Console.WriteLine(Enums_Constants.Constants.AppointedPerson + card.AppointedPerson);
            Console.WriteLine(Enums_Constants.Constants.Size + Enum.GetName(typeof(Enums_Constants.Sizes), card.Size));
            Console.WriteLine(Enums_Constants.Constants.BelongingLine + card.Line + new string('\n' , 2));
        }

        public int AddCardToBoard(Card card)
        {
            cards.Add(card);
            Console.WriteLine(Enums_Constants.Constants.CardAdded);
            return (int)Enums_Constants.Menu.PromptMenu;
        }

        public int RemoveCardFromBoard(string title)
        {
            List<Card> cardsToRemove = cards.FindAll(card => card.Title == title);
            int i = 0;
            if (cardsToRemove.Count == 0) i = Prompt.PromptNoResultsReturnForOperation(Enums_Constants.Constants.OperationCardRemove);
            else
            {
                foreach(Card card in cardsToRemove) cards.Remove(card);
                Console.WriteLine(Enums_Constants.Constants.CardsRemoved);
            }
            return i;
        }

        public int RelocateCard(string searchParam)
        {            
            int i = 0;            
            try
            {
                Card cardToRelocate = FindFromBoard(searchParam);
                cardToRelocate.GetType();
                string newLine = Prompt.PromptTargetRelocationLineSelection(cardToRelocate);
                cardToRelocate.Line = newLine;
                Console.WriteLine(Enums_Constants.Constants.CardRelocated);
            }
            catch (Exception)
            { 
                i = Prompt.PromptNoResultsReturnForOperation(Enums_Constants.Constants.OperationRelocateCard);
            }
            Console.WriteLine(i);
            return i;
        }

        static Card FindFromBoard(string title)
        {
            Card foundCard = cards.Find(card => card.Title == title);
            return foundCard;
        }

        public List<Card> FindManyFromBoard(string title)
        {
            List<Card> foundCards = cards.FindAll(card => card.Title == title);
            return foundCards;
        }
    }
}