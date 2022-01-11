using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal interface IBoard
    {
        void PrintCard(string lineName , List<Card> list);
        void AddCardToBoard(Card card);
        void RemoveCardFromBoard(string title);
        void RelocateCard(List<Card> list,string title);

    }
}
