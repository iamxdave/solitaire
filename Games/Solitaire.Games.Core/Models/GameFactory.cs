using Solitaire.Games.Core.Models.Boards;
using Solitaire.Games.Core.Models.Cards;

namespace Solitaire.Games.Core.Models
{
    public class GameFactory
    {
        public static Game Create()
        {
            var deck = CardDeckFactory.Create();

            var game = new Game
            {
                Deck = deck,
                Board = BoardFactory.Create(deck),
            };

            return game;
        }
    }
}
