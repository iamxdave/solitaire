namespace Solitaire.Games.Core.Models.Cards
{
    public class CardDeck
    {
        public List<Card> Cards { get; set; }

        public CardDeck()
        {
            Cards = new List<Card>();
        }
        public List<Card> GetCards(int number)
        {
            var cards = Cards.GetRange(0, number);
            Cards.RemoveRange(0, number);
            return cards;
        }

        public List<Card> GetAllCards()
        {
            var cards = new List<Card>(Cards);
            Cards.Clear();
            return cards;
        }
    }
}
