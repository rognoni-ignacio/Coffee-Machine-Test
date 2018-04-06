using System;
using System.ComponentModel.DataAnnotations;

namespace CoffeeMachine.Models
{
    public class CoffeeModel
    {
        [Display(Name ="Beverage Type")]
        public CoffeeType Type { get; set; }
        [Display(Name = "Spoons of sugar")]
        public int SpoonsOfSugar { get; set; }
        [Display(Name = "Using your own mug?")]
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
