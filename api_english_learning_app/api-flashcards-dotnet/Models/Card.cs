﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace english_learning_app.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int DeckId { get; set; }
        public Deck Deck { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 5)]
        public string QuestionText { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 5)]
        public string AnswerText { get; set; }
    }
}
