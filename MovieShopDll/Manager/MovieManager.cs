using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieShopDll.Contexts;
using MovieShopDll.Entities;

namespace MovieShopDll.Manager
{
    class MovieManager : IManager<Movie>
    {
        public Movie Create(Movie t)
        {
            using (var db = new MovieShopContext())
            {
                db.Movies.Add(t);
                db.SaveChanges();
                return t;
            }
        }

        public Movie Read(int id)
        {
            using (var db = new MovieShopContext())
            {
                return db.Movies.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Movie> Read()
        {
            using (var db = new MovieShopContext())
            {
                return db.Movies.ToList();
            }
        }

        public void Delete(int id)
        {
            using (var db = new MovieShopContext())
            {
                var movieTodelete = db.Movies.FirstOrDefault(x => x.Id == id);
                db.Entry(movieTodelete).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Movie Update(Movie t)
        {
            using (var db = new MovieShopContext())
            {
                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return t;
            }
        }
    }
}
