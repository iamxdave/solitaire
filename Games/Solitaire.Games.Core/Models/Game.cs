using Solitaire.Games.Core.Models.Boards;
using Solitaire.Games.Core.Models.Cards;

namespace Solitaire.Games.Core.Models
{
    public class Game
    {
        public CardDeck Deck { get; set; }
        public Board Board { get; set; }
        public bool IsOver { get; set; }
    }
}
