namespace Solitaire.Games.Core.Models.Cards
{
    public record Card
    {
        public string CardName { get; }
        public CardRank CardRank { get; }
        public CardSuit CardSuit { get; }
        public bool IsFlipped { get; set; } = false;

        public Card(CardRank cardRank, CardSuit cardSuit)
        {
            CardRank = cardRank;
            CardSuit = cardSuit;
            CardName = $"{cardRank.Rank}_of_{cardSuit}";
        }
    }
}