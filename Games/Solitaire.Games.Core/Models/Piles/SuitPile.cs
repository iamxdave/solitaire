using Solitaire.Games.Core.Models.Cards;

namespace Solitaire.Games.Core.Models.Piles
{
    public class SuitPile : Pile
    {
        public CardSuit CardSuit {get; }

        public SuitPile(CardSuit cardSuit)
        {
            CardSuit = cardSuit;
        }
    }
}