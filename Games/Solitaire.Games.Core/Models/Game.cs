using Soltaire.Games.Core.Models.Cards;

namespace Soltaire.Games.Core.Models
{
    public class Game
    {
        public Player Player { get; init; }
        public CardDeck Deck { get; set; }
        public List<Card> Cards { get; set; }
        public bool IsOver { get; set; }
    }
}
