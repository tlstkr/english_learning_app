using System;
using Microsoft.AspNetCore.Identity;

namespace english_learning_app.Services.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public string Token { get; set; }
    }
}
