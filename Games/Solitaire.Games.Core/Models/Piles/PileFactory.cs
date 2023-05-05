using Solitaire.Games.Core.Models.Cards;

namespace Solitaire.Games.Core.Models.Piles
{
    public class PileFactory
    {
        public static Pile Create(CardDeck cardDeck, int numberOfCards)
        {
            var pile = new Pile
            {
                Cards = cardDeck.GetCards(numberOfCards),
            };

            return pile;
        }

        public static Pile Create(CardDeck cardDeck)
        {
            var pile = new Pile
            {
                Cards = cardDeck.GetAllCards(),
            };

            return pile;
        }
    }
}
