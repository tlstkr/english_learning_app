using System;
using System.Collections.Generic;
using english_learning_app.Dtos.Models;

namespace english_learning_app.Dtos
{
    public class CardResponse
    {
        public List<CardResponseDto> Cards { get; set; }
    }
}
