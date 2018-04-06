using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entities;

namespace BusinessLogic
{
    public class CoffeeLogic
    {
        private readonly CoffeeDataAccess _dataAccess;

        public CoffeeLogic()
        {
            if(_dataAccess == null)
            {
                _dataAccess = new CoffeeDataAccess();
            }
        }

        public void CreateNewCoffe(Coffee coffee)
        {
            _dataAccess.CreateCoffee(coffee);
        }

        public List<Coffee> GetCoffees()
        {
            return _dataAccess.GetAllCoffees().OrderByDescending(c => c.DateOrdered).ToList();
        }

        public Coffee GetCoffee(int id)
        {
            return _dataAccess.GetCoffee(id);
        }
    }
}
