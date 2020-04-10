using System;
using Microsoft.AspNetCore.Identity;

namespace english_learning_app.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string DisplayName { get; set; }
    }
}
