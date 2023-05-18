using Solitaire.Games.Core.Models;
using Solitaire.Games.Core.Models.Cards;
using Solitaire.Games.Core.Models.Piles;

namespace Solitaire.Games.Core.Services
{
    public interface IGameHandlingService {
        public void ClickCard(Game game, Card card);
        public void DrawCard(Game game);
        public void MoveCards(int index, Pile sourcePile, Pile destinationPile);
        public void ResetDeck(Game game);
    }
}