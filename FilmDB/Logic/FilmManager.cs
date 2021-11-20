using FilmDB2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB2
{
    public class FilmManager
    {
        public FilmManager AddFilm(FilmModel filmModel)
        {
            using(var context = new FilmContext())
            {
                context.Add(filmModel);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    filmModel.ID = 0;
                    context.Add(filmModel);
                    context.SaveChanges();
                }
                
            }            
            return this;
        }

        public FilmManager RemoveFilm(int id)
        {
            using (var context = new FilmContext())
            {
                var film = context.Films.SingleOrDefault(x => x.ID == id);
                context.Remove(film);
                context.SaveChanges();
            }
                return this;
        }

        public FilmManager UpdateFilm(FilmModel filmModel)
        {
            using (var context = new FilmContext())
            {
                context.Update(filmModel);
                context.SaveChanges();
                
            }
            return this;
        }

        public FilmManager ChangeTitle(int id, string newTitle)
        {
            using (var context = new FilmContext())
            {
                var film = context.Films.SingleOrDefault(x => x.ID == id);
                if (newTitle ==null)
                {
                    film.Title = "Brak Tytułu";
                }
                else
                {
                    film.Title = newTitle;
                }
                //film.Title = newTitle;
                this.UpdateFilm(film);

                //lub
                //context.Update(film);
                //context.SaveChanges();
            }
            return this;
        }

        public FilmModel GetFilm(int id)
        {
            using (var context = new FilmContext())
            {
                var film = context.Films.SingleOrDefault(x => x.ID == id);
                return film;
            }
            
        }

        public List<FilmModel> GetFilms()
        {
            using (var context = new FilmContext())
            {
                List<FilmModel>  films = context.Films.ToList<FilmModel>();
                return films;
            }
            
        }
    }
}
