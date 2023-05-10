using Solitaire.Games.Core.Models.Piles;

namespace Solitaire.Games.Core.Handlers
{
    public class MoveCardsHandler
    {
        public static void Handle(int index, Pile sourcePile, Pile destinationPile)
        {
            if (sourcePile == null || destinationPile == null) return;

            var cardsToMove = sourcePile.GetCardsAfter(index);

            var removeCount = sourcePile.Cards.Count - index;

            sourcePile.Cards.RemoveRange(index, removeCount);

            destinationPile.Cards.AddRange(cardsToMove);
        }
    }
}
