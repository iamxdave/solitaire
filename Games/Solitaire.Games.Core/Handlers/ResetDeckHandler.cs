using Solitaire.Games.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Solitaire.Games.Core.Handlers
{
    public class ResetDeckHandler
    {
        public static void Handle(Game game)
        {
            var drawPile = game.Board.DrawPile;

            if (drawPile.Cards.Count == 0)
            {
                var wastePile = game.Board.WastePile;

                drawPile.Cards.AddRange(wastePile.Cards);

                wastePile.Cards.Clear();
            }
        }
    }
}
