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
        private int _NumberOfPassengers = 0;
        public int NumberOfPassengers {
            get { return _NumberOfPassengers; }
            set 
            {
                var rem = _NumberOfPassengers;
                _NumberOfPassengers = value; 
                if (DistanceReduceFactor() <= 0)
                {
                    Console.WriteLine($"This number of passengers ({value}) is unacceptable! The car will not be able to move");
                    _NumberOfPassengers = rem;
                }
            }
        }
        protected override double DistanceReduceFactor() => 1.0 - 0.06 * (double)NumberOfPassengers;
    }
}
