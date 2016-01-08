using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi_CarDetails.Models;

namespace WebApi_CarDetails.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Car()
        {
            return View("Car");
        }

       
    }
}