using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTestEx.Vehicles
{
    internal class PassengerCar : Vehicle
    {
        public override string Type { get; set; } = "Passenger Car";
        public int MaxPassengers { get; set; }
        private int _NumberOfPassengers = 0;
        public int NumberOfPassengers {
            get { return _NumberOfPassengers; }
            set { _NumberOfPassengers = (value > MaxPassengers) ?  MaxPassengers : value; }
        }
        protected override double DistanceReduceFactor() => 1.0 - 0.06 * (double)NumberOfPassengers;
    }
}
