namespace Soltaire.Games.Core.Models.Cards
{
    public record Card
    {
        public string CardName { get; }

        public Card(CardRank cardRank, string suit)
        {
            CardName = $"{cardRank.Rank}_of_{suit}";
        }
    }
}