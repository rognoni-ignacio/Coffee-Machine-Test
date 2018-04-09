using System;
using System.Collections.Generic;
using Entities;

namespace DataAccess
{
    public class CoffeeDataAccess
    {
        private static List<Coffee> inMemoryCoffees = new List<Coffee>();

        private static CoffeeDataAccess _instance;

        private CoffeeDataAccess() { }

        public static CoffeeDataAccess Instance()
        {
            if (_instance == null)
            {
                _instance = new CoffeeDataAccess();
            }
            return _instance;
        }

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
