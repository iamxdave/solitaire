using Solitaire.Games.Core.Handlers;
using Solitaire.Games.Core.Models;
using Solitaire.Games.Core.Models.Cards;
using Solitaire.Games.Core.Models.Piles;

namespace Solitaire.Games.Core.Services
{
    public class GameHandlingService : IGameHandlingService {
        ICardValidationService _validationService;
        public GameHandlingService(ICardValidationService validationService){
            _validationService = validationService;
        }
         public void ClickCard(Game game, Card card) {
            ClickCardHandler.Handle(game, card, _validationService);
        }

        public void DrawCard(Game game) {
            DrawCardHandler.Handle(game);
        }

        public void MoveCards(int index, Pile sourcePile, Pile destinationPile) {
            MoveCardsHandler.Handle(index, sourcePile, destinationPile);
        }

        public void ResetDeck(Game game) {
            ResetDeckHandler.Handle(game);
        }
    }
}