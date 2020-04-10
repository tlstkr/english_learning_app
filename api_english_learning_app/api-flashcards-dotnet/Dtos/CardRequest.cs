using System;
using System.ComponentModel.DataAnnotations;

namespace english_learning_app.Dtos
{
    public class CardRequest
    {
        [Required]
        [StringLength(500, MinimumLength = 5)]
        public string QuestionText { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 1)]
        public string AnswerText { get; set; }
    }
}
