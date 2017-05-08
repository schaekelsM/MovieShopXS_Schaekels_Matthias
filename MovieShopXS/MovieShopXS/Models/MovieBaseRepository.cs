using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShopXS.Models
{
    public class MovieBaseRepository
    {
        private MovieBaseContext _context;

        public MovieBaseRepository(MovieBaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> getAllMovies() {
            return _context.Movie.ToList();
        }

        public IEnumerable<Person> getDirectorById(int id) {
            return _context.Person.Where(x => id == x.PersonID);
        }

        public IEnumerable<MovieActor> getActorsIDByMovieID(int id) {
            return _context.MovieActor.Where(x => id == x.MovieID);
        }

        public IEnumerable<Person> getPersonByIds(List<int> ids) {
            return _context.Person.Where(x => ids.Contains(x.PersonID));
        }

        public IEnumerable<Movie> getMovieByYear(int year) {
            return _context.Movie.Where(x => year == x.Year);
        }
    }
}
