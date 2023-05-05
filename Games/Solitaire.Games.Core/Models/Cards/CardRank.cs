namespace Solitaire.Games.Core.Models.Cards
{
    public record CardRank(string Rank, int Value)
    {
        public override string ToString() => $"Rank: {Rank}, Value: {Value}";
    }
}
