﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieShopCustomer.Models;
using MovieShopDll;
using MovieShopDll.Entities;

namespace MovieShopCustomer.Controllers
{
    public class LoginController : Controller
    {
        private readonly IManager<Customer> customerManager = new DllFacade().GetCustomerManager();

        // GET: Checkout
        public ActionResult Index()
        {
            //return RedirectToAction("Create");
            return View();
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Email, Address ")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                customerManager.Create(customer);

                return RedirectToAction("Index");
            }

            return View(customer);


        }

        [ActionName("check")]
        public ActionResult CheckUser(String email)
        {
            if (ModelState.IsValid)
            {
            
                var customers = customerManager.Read();

                var customer = customers.FirstOrDefault(x => x.Email == email);

                if (customer != null)
                {
                   
                   
                    return RedirectToAction("Index", "Checkout", new {cId = customer.Id, mId = 1});
                } 

                return RedirectToAction("Index");
            }

            return View();
        }

    }
}