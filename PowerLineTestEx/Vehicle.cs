using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTestEx
{
    internal class Vehicle
    {
        protected Vehicle() { }
        public virtual string Type { get; set; } = "Abstract";    
        /// <summary>
        /// Litres per 100 kilometres
        /// </summary>
        public double AvgFuelConsumption { get; set; }
        public double FuelTankVol { get; set; }
        private double _FuelInTank;
        public double FuelInTank
        {
            get { return _FuelInTank; }
            set { _FuelInTank = (value > FuelTankVol) ? FuelTankVol : value; }
        }
        public double Speed { get; set; }

        public double RemainingDistanceNet(bool FullTank = false) 
        {
            if (AvgFuelConsumption > 0)
            {
                return FullTank ? ( FuelTankVol / AvgFuelConsumption ) * 100 : 
                    ( FuelInTank / AvgFuelConsumption ) * 100;
            } else
            {
                return 0.0;
            }
        }

        protected virtual double DistanceReduceFactor() => 1.0; // Realize by derived classes

        /// <summary>
        /// Remaining distance taking into account the effect of passengers and cargo
        /// </summary>
        /// <returns></returns>
        public double RemainingDistanceGross() => RemainingDistanceNet()*DistanceReduceFactor();

        public TimeSpan TravelTime(double Distance)
        {
            double distance = Distance > RemainingDistanceGross() ? RemainingDistanceGross() : Distance;
            return Speed > 0 ? TimeSpan.FromHours( distance / Speed ) : TimeSpan.MaxValue;
        }
    }
}
