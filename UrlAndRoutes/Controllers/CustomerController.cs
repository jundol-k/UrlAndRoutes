﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlAndRoutes.Controllers
{
    [RouteArea("Services")]
    [RoutePrefix("Users")]
    public class CustomerController : Controller
    {
        // GET: Customer
        [Route("~/Test")]
        public ActionResult Index()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        [Route("Add/{user}/{id:int}", Name = "AddRoute")]
        public string Create(string user, int id)
        {
            return string.Format("User: {0}, ID: {1}", user, id);
        }

        [Route("Add/{user}/{password:alpha:length(6)}")]
        public string ChangePass(string user, string password)
        {
            return string.Format("ChangePass Method - User: {0}, Pass: {1}", user, password);
        }

        public ActionResult List()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "List";
            return View("ActionName");
        }
    }
}