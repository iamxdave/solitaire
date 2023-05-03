using Soltaire.Games.Core.Models.Cards;

namespace Soltaire.Games.Core.Helpers
{
    public static class CardShuffler
    {
        public static List<Card> Shuffle(this List<Card> cards)
        {
            Random rng = new Random();
            return cards.OrderBy(x => rng.Next()).ToList();
        }
    }
}
