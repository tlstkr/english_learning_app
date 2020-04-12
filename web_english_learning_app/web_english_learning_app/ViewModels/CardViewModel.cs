using System;
using System.ComponentModel.DataAnnotations;

namespace english_learning_app.ViewModels
{
    public class CardViewModel
    {
        public int DeckId { get; set; }
        public string DeckName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(500, MinimumLength = 5)]
        public string QuestionText { get; set; }

        [Required]
        [StringLength(500,MinimumLength =5)]
        [DataType(DataType.Text)]
        public string AnswerText { get; set; }
    }
}
