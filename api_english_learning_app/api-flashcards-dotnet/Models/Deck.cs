using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace english_learning_app.Models
{
    public class Deck
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
    }
}
