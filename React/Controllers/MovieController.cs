using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace React.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        //array of strings
        private static string[] Summaries = new[]
        {
            "Drama", "Action", "Horror", "Thriller", "Romance", "Other"
        };

        private static int[] Prices = new[]
        {
           1,2,3,5,6,7,8,9,10
        };

        private static string[] Titles = new[]
{
           "Forest Gump","Ghost Busters","Saw","One","When Harry Met Sally", "Some Indy Film"
        };

        //
        [HttpGet("[action]")]
        public IEnumerable<Movie> MovieList()
        {
            var rng = new Random();
            return Enumerable.Range(1,5 ).Select(index => new Movie
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Genre = Summaries[rng.Next(Summaries.Length)],
                Names = Titles[rng.Next(Titles.Length)],
                Price = Prices[rng.Next(Prices.Length)],
            });
        }

        public class Movie
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Genre { get; set; }
            public int Price { get; set; }
            public string Names { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}