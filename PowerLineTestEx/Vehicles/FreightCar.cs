using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTestEx.Vehicles
{
    internal class FreightCar : Vehicle
    {
        public override string Type { get; set; } = "Freight Car";
        private int _LoadedCargo = 0;
        public int LoadedCargo
        {
            get { return _LoadedCargo; }
            set 
            {
                var rem = _LoadedCargo;
                _LoadedCargo = value; 
                if (DistanceReduceFactor() <= 0)
                {
                    Console.WriteLine($"This cargo ({value}) is unacceptable! The car will not be able to move");
                    _LoadedCargo = rem;
                }
            }
        }
        protected override double DistanceReduceFactor() => 1.0 - 0.04 * ( (double)LoadedCargo / 200 );   
    }
}
