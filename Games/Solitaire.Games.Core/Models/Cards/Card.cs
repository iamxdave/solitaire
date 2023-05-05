namespace Solitaire.Games.Core.Models.Cards
{
    public record Card
    {
        public string CardName { get; }
        public bool IsFlipped { get; set; }

        public Card(CardRank cardRank, string suit)
        {
            CardName = $"{cardRank.Rank}_of_{suit}";
            IsFlipped = false;
        }
    }
}