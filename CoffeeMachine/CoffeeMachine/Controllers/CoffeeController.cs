using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeMachine.Models;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic;
using Entities;

namespace CoffeeMachine.Controllers
{
    public class CoffeeController : Controller
    {

        private readonly CoffeeLogic _logic;

        public CoffeeController()
        {
            _logic = new CoffeeLogic();
        }

        // GET: /Coffee
        [HttpGet]
        public IActionResult Index()
        {
            List<CoffeeModel> coffees = _logic.GetCoffees().Select(c => MapTo(c)).ToList();
            return View(coffees);
        }

        private CoffeeModel MapTo(Coffee c)
        {
            CoffeeModel coffee = new CoffeeModel();

            coffee.Type = (Models.CoffeeType)c.Type;
            coffee.SpoonsOfSugar = c.SpoonsOfSugar;
            coffee.UseOwnMug = c.UseOwnMug;

            return coffee;
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
