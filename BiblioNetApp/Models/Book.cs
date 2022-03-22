using System.ComponentModel.DataAnnotations;
using BiblioNetApp.Validations;

namespace BiblioNetApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [FirstCapitalLetter]
        public string BookName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [FirstCapitalLetter]
        public string Author { get; set; }

        public decimal Price { get; set; }

    }
}