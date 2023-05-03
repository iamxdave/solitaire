using Soltaire.Games.Core.Helpers;

namespace Soltaire.Games.Core.Models.Cards
{
    public class CardDeckFactory
    {
        public static CardDeck Create()
        {
            var cards = new List<Card>();


            foreach (string suit in new[] { "spades", "hearts", "clubs", "diamonds" })
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
