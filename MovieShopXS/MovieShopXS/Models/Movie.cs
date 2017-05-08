using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShopXS.Models
{
    [Table("Movie")]
    public class Movie
    {

        public Movie()
        {
            MovieActor = new HashSet<MovieActor>();
        }

        [Key]
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int GenreID { get; set; }
        public int DirectorID { get; set; }
        public byte Stars { get; set; }
        public string Description { get; set; }


        public ICollection<MovieActor> MovieActor { get; set; }

        public ICollection<Genre> Genre { get; set; }
    }
}
