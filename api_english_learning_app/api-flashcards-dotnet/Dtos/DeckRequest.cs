using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using english_learning_app.Dtos.Models;

namespace english_learning_app.Dtos
{
    public class DeckRequest
    {
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }
    }
}
