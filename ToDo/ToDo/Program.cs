using System;

namespace ToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = Prompt.PromptMenu();
            string searchParam = string.Empty;
            string newLine = string.Empty;
            Board board = new Board();
            while (i >= (int)Enums_Constants.Menu.PromptMenu && i <= (int)Enums_Constants.Menu.RelocateCard)
            {
                switch (i)
                {
                    case (int)Enums_Constants.Menu.PromptMenu:
                        i = Prompt.PromptMenu();
                        break;
                    case (int)Enums_Constants.Menu.PrintCards:
                        i = board.PrintCards();
                        break;
                    case (int)Enums_Constants.Menu.AddCardToBoard:
                        Card newCard = Prompt.PromptAddCardToBoard();
                        i = board.AddCardToBoard(newCard);
                        break;
                    case (int)Enums_Constants.Menu.RemoveCardFromBoard:
                        searchParam = Prompt.PromptEnterTitleForOperation(Enums_Constants.Constants.OperationCardRemove);
                        i = board.RemoveCardFromBoard(searchParam);
                        break;
                    case (int)Enums_Constants.Menu.RelocateCard:
                        searchParam = Prompt.PromptEnterTitleForOperation(Enums_Constants.Constants.OperationRelocateCard);
                        i = board.RelocateCard(searchParam);
                        break;
                }
            }

        }
    }
}
