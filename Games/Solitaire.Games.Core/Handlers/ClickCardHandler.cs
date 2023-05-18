using Solitaire.Games.Core.Models;
using Solitaire.Games.Core.Models.Cards;
using Solitaire.Games.Core.Models.Piles;
using Solitaire.Games.Core.Services;


namespace Solitaire.Games.Core.Handlers
{
    public class ClickCardHandler
    {
        public static void Handle(Game game, Card card, ICardValidationService service)
        {
            var suitPiles = game.Board.SuitPiles;
            var cardSuitPile = suitPiles.FirstOrDefault(pile => pile.CardSuit == card.CardSuit) ?? throw new NullReferenceException($"Can't find a card suit {card.CardSuit} in suit piles");
            
            var boardPiles = game.Board.BoardPiles;
            var wastePile = game.Board.WastePile;

            var piles = new List<Pile>(boardPiles + wastePile);
            piles.AddRange(suitPiles);

            var sourcePile = piles.FirstOrDefault(pile => pile.Contains(card)) ?? throw new NullReferenceException($"Can't find card {card} in board piles");

            if ((cardSuitPile.IsEmpty() && service.IsAce(card)) || (!cardSuitPile.IsEmpty() && service.AreConsecutiveValuesAscending(card, cardSuitPile.Cards.Last())))
            {
                cardSuitPile.Cards.Add(card);
                sourcePile.Cards.Remove(card);

            }
            else if ((piles.Any(pile => pile.Contains(card))))
            {
                var destinationPile = boardPiles.FirstOrDefault(pile =>
                    (pile.IsEmpty() && service.IsKing(card)) ||
                    (!pile.IsEmpty() && service.AreConsecutiveValuesDescending(card, pile.Cards.Last()) && service.AreOppositeColors(card, pile.Cards.Last())));

                if (destinationPile == null)
                {
                    return;
                }
                
                if (!sourcePile.IsLastCard(card))
                {
                    var index = sourcePile.Cards.IndexOf(card);
                    MoveCardsHandler.Handle(index, sourcePile, destinationPile);
                }
                else
                {
                    destinationPile.Cards.Add(card);
                    sourcePile.Cards.Remove(card);
                }
                
            }
        }
    }
}
