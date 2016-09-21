using System.Collections.Generic;

namespace MovieShopDll.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string TrailerUrl { get; set; }
        public Genre Genre { get; set; }
        public List<Order> Orders { get; set; }


    }
}