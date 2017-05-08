using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieShopXS.Models;

namespace MovieShopXS.Controllers
{
    public class HomeController : Controller
    {
        private MovieBaseRepository _repository;

        public HomeController(MovieBaseRepository repository)
        {
            _repository = repository;
        }
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            var data = _repository.getAllMovies();
            List<Person> buffer = new List<Person>();
            List<Person> bufferActors = new List<Person>();


            foreach (var item in data) {
                List<int> buffer2 = new List<int>();
                var dt = _repository.getDirectorById(item.DirectorID);
                Person per = new Person()
                {
                    FirstName = dt.First().FirstName,
                    LastName = dt.First().LastName,
                    PersonID = item.DirectorID
                };
                buffer.Add(per);


                /*var t = _repository.getActorsIDByMovieID(item.MovieID);
                foreach (var it in t) {
                    buffer2.Add(it.ActorID); 
                }

                var actors = _repository.getPersonByIds(buffer2);

                foreach (Person ac in actors) {

                    Person pers = new Person()
                    {
                        FirstName = dt.First().FirstName,
                        LastName = dt.First().LastName,
                        PersonID = item.MovieID
                    };
                    bufferActors.Add(pers);
                }*/



            }


            //ViewBag.Actors = bufferActors;
            ViewBag.Directors = buffer;

            //get all actor id's by movie number
            //get all actors by movie number

            return View(data);
        }

        [Route("year/{year}")]
        public IActionResult Year(string year) {
            var data = _repository.getMovieByYear(Convert.ToInt32(year));

            List<Person> buffer = new List<Person>();
            List<Person> bufferActors = new List<Person>();


            foreach (var item in data)
            {
                List<int> buffer2 = new List<int>();
                var dt = _repository.getDirectorById(item.DirectorID);
                Person per = new Person()
                {
                    FirstName = dt.First().FirstName,
                    LastName = dt.First().LastName,
                    PersonID = item.DirectorID
                };
                buffer.Add(per);


                /*var t = _repository.getActorsIDByMovieID(item.MovieID);
                foreach (var it in t) {
                    buffer2.Add(it.ActorID); 
                }

                var actors = _repository.getPersonByIds(buffer2);

                foreach (Person ac in actors) {

                    Person pers = new Person()
                    {
                        FirstName = dt.First().FirstName,
                        LastName = dt.First().LastName,
                        PersonID = item.MovieID
                    };
                    bufferActors.Add(pers);
                }*/



            }


            //ViewBag.Actors = bufferActors;
            ViewBag.Directors = buffer;

            return View("index",data);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
