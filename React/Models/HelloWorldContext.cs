using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;

namespace React.Models
{
    public class HelloWorldContext : DbContext
    {
        //public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
        //    : base(options)
        //{
        //}

        public DbSet<Movie> Movie { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
    }

    public class Hello
    {

		public int Id { get; set; }
		public string Title { get; set; }

		[DataType(DataType.Date)]
		public DateTime ReleaseDate { get; set; }
		public string Genre { get; set; }
		public decimal Price { get; set; }

	}
}
