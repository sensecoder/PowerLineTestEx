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
        public int MaxLoadCapacity { get; set; }
        private int _LoadedCargo = 0;
        public int LoadedCargo
        {
            get { return _LoadedCargo; }
            set { _LoadedCargo = (value > MaxLoadCapacity) ? MaxLoadCapacity : value; }
        }
        protected override double DistanceReduceFactor() => 1.0 - 0.04 * ( (double)LoadedCargo / 200 );
        public bool IsTakeAFullLoad(double Distance)
        {
            var remCargo = LoadedCargo;
            LoadedCargo = MaxLoadCapacity;
            bool result = (RemainingDistanceGross() > Distance) ? true : false;
            LoadedCargo = remCargo;
            return result;            
        }        
    }
}
