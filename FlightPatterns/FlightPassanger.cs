using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPatterns
{
    public class Passanger
    {
        public string? Name { get; set; }

    }

    public class BusinessClassPassanger : Passanger
    {
        public override string ToString()
        {
            return $"Business Class Passanger: {Name}";
        }
    }

    public class  CoachClassPassanger : Passanger
    {
        public double CarryOnKG { get; set; }
        public override string ToString()
        {
            return $"Coach Class Passanger {Name} with {CarryOnKG} KG carry on ";
        }
    }

    public class FirstClassPassanger : Passanger
    {
        public int AirMiles { get; set; }
        public override string ToString()
        {
            return $"First Class Passanger {Name} with {AirMiles} air miles";
        }
    }
}
