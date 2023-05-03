using Soltaire.Games.Core.Models.Cards;

namespace Soltaire.Games.Core.Models
{
    public class GameFactory
    {
        public static Game Create(string playerName)
        {
            var game = new Game
            {
                Deck = CardDeckFactory.Create(),
                Cards = new List<Card>(),
                Player = new Player(playerName),
            };

            return game;
        }
    }
}
