using Solitaire.Games.Core.Models.Cards;

namespace Solitaire.Games.Core.Models.Piles
{
    public class Pile
    {
        public List<Card> Cards { get; set; }

        public Pile() { 
            Cards = new List<Card>();
        }
        public static List<Pile> operator +(List<Pile> a, Pile b)
        {
            return new List<Pile>(a) {b};
        }
        public bool IsFirstCard(Card card)
        {
            return Cards.IndexOf(card) == 0;
        }
        public bool IsLastCard(Card card)
        {
            return Cards.IndexOf(card) == (Cards.Count - 1);
        }
        public bool IsEmpty()
        {
            return Cards.Count == 0;
        }
        public bool Contains(Card card)
        {
            return Cards.Any(c => c.Equals(card));
        }
    }
}
