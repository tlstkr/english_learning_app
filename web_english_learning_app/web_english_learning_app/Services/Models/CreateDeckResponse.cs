using System;
using System.Collections.Generic;
using english_learning_app.Services.Models.ErrorHandling;

namespace english_learning_app.Services.Models
{
    public class CreateDeckResponse
    {
        public bool isSuccess { get; set; }
        public Errors Errors { get; set; }
    }
}

