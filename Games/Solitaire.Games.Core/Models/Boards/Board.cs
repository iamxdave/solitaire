using Solitaire.Games.Core.Models.Piles;

namespace Solitaire.Games.Core.Models.Boards
{
    public class Board
    {
        public List<Pile> BoardPiles { get; set; }
        public List<Pile> SuitPiles { get; set; }
        public Pile DrawPile { get; set; }
        public Pile WastePile { get; set; }
    }
}
