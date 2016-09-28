using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieShopDll.Contexts;
using MovieShopDll.Entities;

namespace MovieShopDll.Manager
{
    class CustomerManager : IManager<Customer>
    {
        public Customer Create(Customer t)
        {
            using (var db = new MovieShopContext())
            {
                db.Customers.Add(t);
                db.SaveChanges();
                return t;
            }
        }

        public Customer Read(int id)
        {
            using (var db = new MovieShopContext())
            {
                return db.Customers.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Customer> Read()
        {
            using (var db = new MovieShopContext())
            {
                return db.Customers.ToList();
            }
        }

        public void Delete(int id)
        {
            using (var db = new MovieShopContext())
            {
                var customerTodelete = db.Movies.FirstOrDefault(x => x.Id == id);
                db.Entry(customerTodelete).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Customer Update(Customer t)
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
