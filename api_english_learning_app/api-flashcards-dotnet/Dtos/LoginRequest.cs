﻿using System;
using System.ComponentModel.DataAnnotations;

namespace english_learning_app.Dtos
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
