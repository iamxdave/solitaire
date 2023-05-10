using Solitaire.Games.Core.Models;
using Solitaire.Games.Core.Models.Cards;
using Solitaire.Games.Core.Services;


namespace Solitaire.Games.Core.Handlers
{
    public class ClickCardHandler
    {
        public static void Handle(Game game, Card card, ICardValidationService service)
        {
            var suitPile = game.Board.SuitPiles.FirstOrDefault(kvp => kvp.Key == card.CardSuit).Value ?? throw new NullReferenceException($"Can't find a card suit {card.CardSuit} in suit piles");
            var boardPiles = game.Board.BoardPiles;
            var wastePile = game.Board.WastePile;

            var sourcePile = (boardPiles + wastePile).FirstOrDefault(pile => pile.Contains(card)) ?? throw new NullReferenceException($"Can't find card {card} in board piles");

            if ((suitPile.IsEmpty() && service.IsAce(card)) || (!suitPile.IsEmpty() && service.AreConsecutiveValuesAscending(card, suitPile.Cards.Last())))
            {
                suitPile.Cards.Add(card);
                sourcePile.Cards.Remove(card);

            }
            else if ((boardPiles + wastePile).Any(pile => pile.Contains(card)))
            {
                var destinationPile = boardPiles.FirstOrDefault(pile =>
                    (pile.IsEmpty() && service.IsKing(card)) ||
                    (!pile.IsEmpty() && service.AreConsecutiveValuesDescending(card, pile.Cards.Last()) && service.AreOppositeColors(card, pile.Cards.Last())));

                if (destinationPile != null)
                {
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
}
