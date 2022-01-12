using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal interface IBoard
    {
        int PrintCards();
        int AddCardToBoard(Card card);
        int RemoveCardFromBoard(string title);
        int RelocateCard(string searchParam);

    }
}
