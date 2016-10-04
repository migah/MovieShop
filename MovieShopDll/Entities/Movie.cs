﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieShopDll.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }
        [Display(Name = "Trailer URL")]
        public string TrailerUrl { get; set; }
        public Genre Genre { get; set; }
        public List<Order> Orders { get; set; }


    }
}