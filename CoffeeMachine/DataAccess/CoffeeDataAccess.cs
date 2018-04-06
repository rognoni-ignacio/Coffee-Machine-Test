using System;
using System.Collections.Generic;
using Entities;

namespace DataAccess
{
    public class CoffeeDataAccess: ICoffee
    {
        private static List<Coffee> inMemoryCoffees = new List<Coffee>();

        public CoffeeDataAccess() {}

        public void CreateCoffee(Coffee coffee)
        {
            inMemoryCoffees.Add(coffee);
        }

        public IEnumerable<Coffee> GetAllCoffees()
        {
            return inMemoryCoffees;
        }

        public Coffee GetCoffee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
