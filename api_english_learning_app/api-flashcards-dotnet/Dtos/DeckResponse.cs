using System.Collections.Generic;
using english_learning_app.Dtos.Models;

namespace english_learning_app.Dtos
{
    public class DeckResponse
    {
        public List<DeckResponseDto> Decks { get; set; }
    }
}
