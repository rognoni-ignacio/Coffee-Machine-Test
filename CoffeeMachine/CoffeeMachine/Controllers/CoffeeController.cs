using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeMachine.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMachine.Controllers
{
    public class CoffeeController : Controller
    {
        // GET: /Coffee
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Coffee/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Coffee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CoffeeModel coffee)
        {
            return View();
        }
    }
}
