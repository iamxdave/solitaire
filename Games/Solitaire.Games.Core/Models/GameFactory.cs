using Solitaire.Games.Core.Models.Boards;
using Solitaire.Games.Core.Models.Piles;
using Solitaire.Games.Core.Models.Cards;

namespace Solitaire.Games.Core.Models
{
    public class GameFactory
    {
        public static Game Create(string playerName)
        {
            var deck = CardDeckFactory.Create();

            var game = new Game
            {
                Deck = deck,
                Board = BoardFactory.Create(deck),
                Player = new Player(playerName),
            };

            return game;
        }
    }
}
