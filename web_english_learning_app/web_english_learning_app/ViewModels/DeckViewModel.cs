using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using english_learning_app.Services.Models;

namespace english_learning_app.ViewModels
{
    public class DeckViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        public int TotalCards { get; set; }

        public List<Card> Cards { get; set; }
    }

}
