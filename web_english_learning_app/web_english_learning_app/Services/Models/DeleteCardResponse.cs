using System;
using System.Collections.Generic;

namespace english_learning_app.Services.Models
{
    public class DeleteCardResponse
    {
        public bool IsSuccess { get; set; }
        public List<string> Errors;
    }
}
