using System;
namespace Vidly.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }

        public Movie()
        {
        }
    }
}
