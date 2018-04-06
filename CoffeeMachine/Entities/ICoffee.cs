using System;
using System.Collections.Generic;

namespace Entities
{
    public interface ICoffee
    {
        void CreateCoffee(Coffee coffee);
        IEnumerable<Coffee> GetAllCoffees();
        Coffee GetCoffee(int id);
    }
}
