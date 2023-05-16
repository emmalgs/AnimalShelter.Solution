using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System;


namespace AnimalShelter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")] 
        public ActionResult Index()
        {
            return View();
        } 
    }
}