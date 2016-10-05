using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieShopDll;
using MovieShopDll.Entities;

namespace MovieShopCustomer.Controllers
{
    public class CheckoutController : Controller
    {


        private readonly IManager<Customer> customerManager = new DllFacade().GetCustomerManager();

        // GET: Checkout
        public ActionResult Index()
        {
            return View();
        }


    }
}