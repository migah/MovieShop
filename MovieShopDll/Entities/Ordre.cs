using System;
using System.Collections.Generic;

namespace MovieShopDll.Entities
{
    public class Ordre
    {
        public int OrdreNumber { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public List<Movie> Movies { get; set; }

    }
}