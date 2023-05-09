using Solitaire.Games.Core.Models.Cards;
using Solitaire.Games.Core.Models.Piles;

namespace Solitaire.Games.Core.Models.Boards
{
    public class Board
    {
        public List<Pile> BoardPiles { get; set; }
        public Dictionary<CardSuit, Pile> SuitPiles { get; set; }
        public Pile DrawPile { get; set; }
        public Pile WastePile { get; set; }
    }
}
