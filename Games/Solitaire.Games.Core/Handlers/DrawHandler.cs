using Solitaire.Games.Core.Models;

namespace Solitaire.Games.Core.Handlers
{
    public class DrawHandler
    {
        public static void Handle(Game game)
        {
            var drawPile = game.Board.DrawPile;
            var wastePile = game.Board.WastePile;

            var drawnCard = drawPile.Cards.Last();

            drawPile.Cards.Remove(drawnCard);

            wastePile.Cards.Add(drawnCard);
        }
    }
}
