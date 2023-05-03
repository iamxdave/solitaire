using Soltaire.Games.Core.Helpers;
using Soltaire.Games.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soltaire.Games.Core.Handlers
{
    public class ShuffleDeckHandler
    {
        public static void Handle(Game game)
        {
            game.Deck.Cards = CardShuffler.Shuffle(game.Deck.Cards);
            game.Cards = CardShuffler.Shuffle(game.Cards);
        }
    }
}
