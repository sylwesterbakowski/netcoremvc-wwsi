using FilmDB2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var manager = new FilmManager();
            var film = manager.GetFilm(id);
            return View(film);
        }

        [HttpPost] // wzorzec dekoratora
        public IActionResult RemoveConfirm(int id)
        {
            var manager = new FilmManager();
            try
            {
                manager.RemoveFilm(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                //var film = manager.GetFilm(id);
                //return RedirectToAction(String.Format("Remove/{0}", id));
                //return BadRequest();
                return RedirectToAction("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Edit (int id)
        {
            var manager = new FilmManager();
            var film = manager.GetFilm(id);
            return View(film);
        }

        [HttpPost]
        public IActionResult Edit(FilmModel film)
        {
            var manager = new FilmManager();
            
            try
            {
                manager.UpdateFilm(film);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }

            
        }

    }
}
