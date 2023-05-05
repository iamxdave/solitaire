using Solitaire.Games.Core.Models.Cards;

namespace Solitaire.Games.Core.Models.Piles
{
    public class Pile
    {
        public List<Card> Cards { get; set; }

        public Pile() { 
            Cards = new List<Card>();
        }
        public int GetCardIndex(Card card)
        {
            return Cards.IndexOf(card);
        }
        public bool IsFirstCard(Card card)
        {
            return Cards.IndexOf(card) == 0;
        }
        public bool IsLastCard(Card card)
        {
            return Cards.IndexOf(card) == (Cards.Count - 1);
        }
    }
}
