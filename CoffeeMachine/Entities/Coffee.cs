using System;
namespace Entities
{
    public class Coffee
    {
        public int Id { get; set; }
        public CoffeeType Type { get; set; }
        public int SpoonsOfSugar { get; set; }
        public bool UseOwnMug { get; set; }

        public Coffee(CoffeeType type, int spoonsOfSugar, bool useOwnMug)
        {
            this.Type = type;
            this.SpoonsOfSugar = spoonsOfSugar;
            this.UseOwnMug = useOwnMug;
        }

        public Coffee()
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
