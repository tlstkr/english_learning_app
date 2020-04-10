using System;
using System.ComponentModel.DataAnnotations;

namespace english_learning_app.Dtos
{
    public class RegisterRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [MinLength(3), MaxLength(20)]
        public string DisplayName { get; set; }
    }
}
