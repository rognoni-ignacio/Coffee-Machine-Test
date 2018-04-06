using System;
namespace CoffeeMachine.Models
{
    public class CoffeeModel
    {
        public CoffeeType Type { get; set; }
        public int SpoonsOfSugar { get; set; }
        public bool UseOwnMug { get; set; }

        public CoffeeModel(CoffeeType type, int spoonsOfSugar, bool useOwnMug)
        {
            this.Type = type;
            this.SpoonsOfSugar = spoonsOfSugar;
            this.UseOwnMug = useOwnMug;
        }

        public CoffeeModel()
        {
        }
    }

    public enum CoffeeType
    {
        Cafe,
        The,
        Chocolat
    }
}
