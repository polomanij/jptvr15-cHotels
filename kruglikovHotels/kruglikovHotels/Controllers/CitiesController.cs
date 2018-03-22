using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kruglikovHotels.Models;

namespace kruglikovHotels.Controllers
{
    public class CitiesController : Controller
    {
        // GET: Cities
        public ActionResult Index()
        {
            ViewBag.Cities = CitiesCollection.listCities;
            return View();
        }
    }
}