using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dare_Academmy.Data;

namespace Dare_Academmy.Controllers
{
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult serch()
        {

            contextcity con = new contextcity();
            
            return View("Index");
        }

        public IActionResult save(contryserch v)
        {

            contextcity con = new contextcity();
            var cod = con.country;

            return View("Index");
        }

        public IActionResult savecity(contryserch v)
        {

            contextcity con = new contextcity();
            var cod = con.city;
          
            return View("Index");
        }
    }
}
