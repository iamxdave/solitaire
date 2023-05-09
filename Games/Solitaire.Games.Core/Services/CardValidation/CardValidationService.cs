using Solitaire.Games.Core.Models.Cards;


namespace Solitaire.Games.Core.Services
{
    public class CardValidationService : ICardValidationService
    {
        public bool AreConsecutiveValuesDescending(Card first, Card second)
        {
            if (first != null && second != null && first.IsFlipped && second.IsFlipped)
            {
                return first.CardRank.Value == second.CardRank?.Value - 1;
            }

            return false;
        }

        public bool AreConsecutiveValuesAscending(Card first, Card second)
        {
            if (first != null && second != null && first.IsFlipped && second.IsFlipped)
            {
                return first.CardRank.Value - 1 == second.CardRank.Value;
            }

            return false;
        }

        public bool AreSameSuits(Card first, CardSuit cardSuit)
        {
            if (first != null && first.IsFlipped)
            {
                return first.CardSuit == cardSuit;
            }

            return false;
        }
        public bool AreOpossiteColors(Card first, Card second)
        {
            if (first != null && second != null && first.IsFlipped && second.IsFlipped)
            {
                var red = new CardSuit[] { CardSuit.hearts, CardSuit.diamonds };
                var black = new CardSuit[] { CardSuit.clubs, CardSuit.spades };

                bool areOppositeColors =
                    red.Contains(first.CardSuit) && black.Contains(second.CardSuit) ||
                    black.Contains(first.CardSuit) && red.Contains(second.CardSuit);

                return areOppositeColors;
            }

            return false;
        }
        public bool IsKing(Card first)
        {
            if (first != null && first.IsFlipped)
            {
                return first.CardRank.Rank == "king";
            }

            return false;
        }
        public bool IsAce(Card first)
        {
            if (first != null && first.IsFlipped)
            {
                return first.CardRank.Rank == "ace";
            }

            return false;
        }
    }
}
