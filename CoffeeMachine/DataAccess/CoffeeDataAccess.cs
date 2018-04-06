using System;
using System.Collections.Generic;
using Entities;

namespace DataAccess
{
    public class CoffeeDataAccess: ICoffee
    {
        public CoffeeDataAccess()
        {
        }

        public void CreateCoffee(Coffee coffee)
        {
            Console.WriteLine("New beverage was created");
            Console.WriteLine("Beverage Type: " + coffee.Type);
            Console.WriteLine("Spoons of sugar: " + coffee.SpoonsOfSugar);
            Console.WriteLine("Use own mug: " + coffee.UseOwnMug);
        }

        public IEnumerable<Coffee> GetAllCoffees()
        {
            List<Coffee> coffees = new List<Coffee>();

            Coffee c1 = new Coffee(CoffeeType.Cafe, 2, true);
            Coffee c2 = new Coffee(CoffeeType.The, 0, false);
            Coffee c3 = new Coffee(CoffeeType.Chocolat, 0, true);

            coffees.Add(c1);
            coffees.Add(c2);
            coffees.Add(c3);

            return coffees;
        }

        public Coffee GetCoffee(int id)
        {
            return new Coffee(CoffeeType.Chocolat, 1, false);
        }
    }
}
