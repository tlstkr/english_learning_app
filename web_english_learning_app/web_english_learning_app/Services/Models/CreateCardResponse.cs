using System;
using english_learning_app.Services.Models.ErrorHandling;

namespace english_learning_app.Services.Models
{
    public class CreateCardResponse
    {
        public bool IsSuccess { get; set; }
        public Errors Errors { get; set; }
    }
}
