using System;
using System.Collections.Generic;
using System.Linq;
using CoffeeMachine.Models;
using Microsoft.AspNetCore.Mvc;
using Entities;

namespace CoffeeMachine.Controllers
{
    public class CoffeeController : Controller
    {
        private ICoffee _logic;

        public CoffeeController(ICoffee coffee)
        {
            this._logic = coffee;
        }

        // GET: /Coffee
        [HttpGet]
        public IActionResult Index()
        {
            List<CoffeeModel> coffees = _logic.GetAllCoffees().Select(c => MapTo(c)).ToList();
            return View(coffees);
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
        public IActionResult Create([Bind("Type,SpoonsOfSugar,UseOwnMug")] CoffeeModel coffeeModel)
        {
            if (ModelState.IsValid)
            {
                //Mapping model with the Entity
                Coffee coffee = new Coffee();
                coffee.Type = (Entities.CoffeeType)coffeeModel.Type;
                coffee.SpoonsOfSugar = coffeeModel.SpoonsOfSugar;
                coffee.UseOwnMug = coffeeModel.UseOwnMug;
                coffee.DateOrdered = DateTime.Now;

                _logic.CreateCoffee(coffee);

                return RedirectToAction(nameof(Index));
            }
            return View(coffeeModel);
        }

        #region Mappers

        private CoffeeModel MapTo(Coffee c)
        {
            CoffeeModel coffee = new CoffeeModel();

            coffee.Type = (Models.CoffeeType)c.Type;
            coffee.SpoonsOfSugar = c.SpoonsOfSugar;
            coffee.UseOwnMug = c.UseOwnMug;

            return coffee;
        }

        #endregion

        #region API

        [HttpGet("api/GetAllCoffee")]
        public IActionResult GetAllCoffee()
        {
            return Ok(_logic.GetAllCoffees().Select(c => MapTo(c)).ToList());
        }

        #endregion
    }
}
