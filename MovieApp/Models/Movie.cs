using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
// https://pastebin.com/3gKF0CSE - initial migration
namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; } // Required for database - primary key
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)] // annotation
        public DateTime ReleaseDate { get; set; }
        public string?  Genre  { get; set;}
        public decimal Price { get; set; }
    }
}
