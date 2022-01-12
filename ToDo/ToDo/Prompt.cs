using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace ToDo
{
    internal class Prompt
    {
        public static int PromptMenu()
        {
            Console.WriteLine(Enums_Constants.Constants.Menu);
            int i = int.Parse(Console.ReadLine()); 
            return i;
        }

        public static Card PromptAddCardToBoard()
        {
            string title = string.Empty, content = string.Empty; 
            int appointedPerson = 0 , size = 0;

            try
            {
                Console.Write(Enums_Constants.Constants.EnterTitle);
                title = Console.ReadLine();
                Console.Write(Enums_Constants.Constants.EnterContent);
                content = Console.ReadLine();
                Console.Write(Enums_Constants.Constants.SelectSize);
                size = int.Parse(Console.ReadLine());
                Console.Write(Enums_Constants.Constants.SelectAppointedPerson);
                appointedPerson = int.Parse(Console.ReadLine());
                Appointed.checkIfAppointedExists(appointedPerson);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PromptAddCardToBoard();
            }
            
            Card newCard = new(title, content, size , appointedPerson);
            return newCard;
        }

        public static string PromptEnterTitleForOperation(string operation)
        {
            Console.Write(Enums_Constants.Constants.EnterTitleForOperation(operation));
            string inputTitle = Console.ReadLine();
            return inputTitle;
        }

        public static int PromptNoResultsReturnForOperation(string operation)
        {
            Console.WriteLine(Enums_Constants.Constants.NoResultsReturnedForOperation(operation));
            try
            {
                int inputSelection = int.Parse(Console.ReadLine());
                checkSelection(inputSelection , Enums_Constants.Constants.range2);
                if (inputSelection == 2)
                {
                    if (operation == Enums_Constants.Constants.OperationCardRemove) return (int)Enums_Constants.Menu.RemoveCardFromBoard;
                    if (operation == Enums_Constants.Constants.OperationRelocateCard) return (int)Enums_Constants.Menu.RelocateCard;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                PromptNoResultsReturnForOperation(operation);
            }
            return (int)Enums_Constants.Menu.PromptMenu;
        }

        public static string PromptTargetRelocationLineSelection(Card card)
        {
            Board.PrintCard(card);
            Console.WriteLine(Enums_Constants.Constants.PleaseSelectTargetLine);
            int inputSelection = 0;
            try
            {
                inputSelection = int.Parse(Console.ReadLine());
                checkSelection(inputSelection , Enums_Constants.Constants.range3);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                PromptTargetRelocationLineSelection(card);
            }
            return Enum.GetName(typeof(Enums_Constants.Lines), inputSelection).ToString();
        }

        private static void checkSelection(int selection, List<int>options)
        {
            if (!options.Contains(selection)) throw new Exception(Enums_Constants.Constants.SelectionNotValid);
        }
    }
}
