using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Games.Core.Helpers
{
    internal static class WWWRootHelper
    {
        public static string GetCardPath(string cardName)
        {
            var cardPath = Path.Combine("\\images\\cards", cardName);

            if (!File.Exists(cardPath))
            {
                throw new FileNotFoundException($"The specified image file '{cardPath}' was not found in the wwwroot folder.");
            }

            return cardPath;
        }
    }
}
