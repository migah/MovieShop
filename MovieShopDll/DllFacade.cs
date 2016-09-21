using MovieShopDll.Entities;
using MovieShopDll.Manager;

namespace MovieShopDll
{
    public class DllFacade
    {
        public IManager<Genre> GetGenreManager()
        {
            return new GenreManager();
        }
    }
}
