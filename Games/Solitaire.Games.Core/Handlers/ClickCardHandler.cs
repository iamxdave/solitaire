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
            
            if ((suitPile.IsEmpty() && service.IsAce(card)) || (!suitPile.IsEmpty() && service.AreConsecutiveValuesAscending(card, suitPile.Cards.Last())))
            {
                suitPile.Cards.Add(card);

                foreach (var pile in boardPiles + wastePile)
                {
                    if (pile.Contains(card))
                    {
                        pile.Cards.Remove(card);
                        return;
                    }
                }

            } else if(wastePile.Contains(card))
            {
                foreach (var pile in boardPiles)
                {
                    var lastCard = pile.Cards.Last();
                    if (service.AreConsecutiveValuesDescending(card, lastCard) && service.AreOpossiteColors(card, lastCard))
                    {
                        pile.Cards.Add(card);
                        wastePile.Cards.Remove(card);
                        return;
                    }
                }
            }
        }
    }
}
