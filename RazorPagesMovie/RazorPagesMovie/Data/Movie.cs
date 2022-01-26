using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Data
{
    public class Movie
    {
        public Movie()
        {
        }

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }



    }
}
