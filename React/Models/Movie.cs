using System;
using System.ComponentModel.DataAnnotations;

namespace React.Models
{
    public class MovieSometing
    {

        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

    }
}
