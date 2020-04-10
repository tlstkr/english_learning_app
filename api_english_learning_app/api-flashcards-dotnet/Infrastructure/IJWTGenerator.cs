using System;
using english_learning_app.Models;

namespace english_learning_app.Infrastructure
{
    public interface IJWTGenerator
    {
        string CreateToken(ApplicationUser user);
    }
}
