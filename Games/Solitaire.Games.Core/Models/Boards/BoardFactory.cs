using Solitaire.Games.Core.Models.Cards;
using Solitaire.Games.Core.Models.Piles;

namespace Solitaire.Games.Core.Models.Boards
{
    public class BoardFactory
    {
        public static Board Create(CardDeck cardDeck)
        {
            var board = new Board
            {
                BoardPiles = new List<Pile>(),
                SuitPiles = new List<Pile>(),
                DrawPile = new Pile(),
                WastePile = new Pile()
            };

            for(int i = 1; i <= 7; i++)
            {
                board.BoardPiles.Add(PileFactory.Create(cardDeck, i));
            }

            board.DrawPile = PileFactory.Create(cardDeck);

            return board;
        }
    }
}
