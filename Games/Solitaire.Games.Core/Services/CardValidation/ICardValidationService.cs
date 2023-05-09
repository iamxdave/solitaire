using Solitaire.Games.Core.Models.Cards;
using Solitaire.Games.Core.Models.Piles;

namespace Solitaire.Games.Core.Services
{
    public interface ICardValidationService
    {
        bool AreConsecutiveValuesDescending(Card first, Card second);
        bool AreConsecutiveValuesAscending(Card first, Card second);
        bool AreSameSuits(Card first, CardSuit cardSuit);
        bool AreOpossiteColors(Card first, Card second);
        bool IsKing(Card first);
        bool IsAce(Card first);
    }
}
