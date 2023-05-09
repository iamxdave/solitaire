
namespace Solitaire.Games.Core.Models.Cards
{
    public class CardDeckFactory
    {
        public static CardDeck Create()
        {
            var cards = new List<Card>();


            var cardSuits = (CardSuit[])Enum.GetValues(typeof(CardSuit)) ?? throw new NullReferenceException("Card suits are empty");

            foreach (var suit in cardSuits)
            {
                var value = 1;
                foreach (var rank in new[] { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" })
                {
                    cards.Add(new Card(new CardRank(rank, value), suit));
                    value++;
                }
            }

            var deck = new CardDeck();
            deck.Cards = cards.OrderBy(x => Guid.NewGuid()).ToList();

            return deck;
        }
    }
}
