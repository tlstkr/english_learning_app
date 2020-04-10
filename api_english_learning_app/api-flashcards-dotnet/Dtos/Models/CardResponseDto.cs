using System;
using System.Collections.Generic;

namespace english_learning_app.Dtos.Models
{
    public class CardResponseDto
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string AnswerText { get; set; }
    }
}
