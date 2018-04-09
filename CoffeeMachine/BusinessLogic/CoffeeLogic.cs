using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entities;

namespace BusinessLogic
{
    public class CoffeeLogic: ICoffee
    {
        private readonly CoffeeDataAccess _dataAccess;

        public CoffeeLogic()
        {
            _dataAccess = CoffeeDataAccess.Instance();
        }

        public Coffee GetCoffee(int id)
        {
            return _dataAccess.GetCoffee(id);
        }

        public void CreateCoffee(Coffee coffee)
        {
            _dataAccess.CreateCoffee(coffee);
        }

        public IEnumerable<Coffee> GetAllCoffees()
        {
            return _dataAccess.GetAllCoffees().OrderByDescending(c => c.DateOrdered).ToList();
        }
    }
}
