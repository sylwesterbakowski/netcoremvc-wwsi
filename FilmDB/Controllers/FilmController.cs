using FilmDB2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB2.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            var manager = new FilmManager();

            //dodawanie filmu
            //var film = new FilmModel();
            //film.ID = 1;
            //film.Title = "Titanic";
            //film.Year = 1998;
            //manager.AddFilm(film);

            //usuwanie filmu
            //manager.RemoveFilm(1);

            //update filmu
            //film.ID = 2;
            //film.Title = "Matrix";
            //film.Year = 1998;

            //manager.UpdateFilm(film);


            //zmiana tytułu
            //manager.ChangeTitle(1002, null);
            //manager.ChangeTitle(1002, "Władca Pier scieni");


            var films = manager.GetFilms();




            return View(films);

            //return View();
        }

        [HttpGet] //dekorowanie atrybutem - tyle get bedzie mógł połączyć sie  z tą akcją
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(FilmModel film)
        {
            var manager = new FilmManager();
            manager.AddFilm(film);
            //return Redirect("/");
            return RedirectToAction("Index");
        }
    }
}
