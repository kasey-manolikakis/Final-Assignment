//Create a Book class with properties: Id, Title, Author, Price.
using System.ComponentModel.DataAnnotations;
namespace FinalAssignment.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(2), StringLength(100)]
        public string Title { get; set; }

        [Required, MinLength(2), StringLength(100)]
        public string Author { get; set; }

        [Required, Range(1,200)]
        public int Price { get; set; } 
    }
}
