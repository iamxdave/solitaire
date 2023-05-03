namespace Soltaire.Games.Core.Models
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; init; }
        public int Score { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
