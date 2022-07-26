using PowerLineTestEx.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTestEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = {
                new PassengerCar()
                {
                    AvgFuelConsumption = 8,
                    FuelTankVol = 70,
                    Speed = 80
                },
                new FreightCar()
                {
                    AvgFuelConsumption = 25,
                    FuelTankVol = 300,
                    Speed = 60
                },
                new SportCar()
                {
                    AvgFuelConsumption = 20,
                    FuelTankVol = 40,
                    Speed = 150
                }
            };
            foreach (var car in vehicles)
            {
                Console.WriteLine($"Car type: {car.Type}");
                Console.WriteLine($"Average fuel consumption: {car.AvgFuelConsumption} litres per 100 km");
                Console.WriteLine($"Fuel tank volume: {car.FuelTankVol} litres");

                switch (car)
                {
                    case PassengerCar p:
                        Console.WriteLine("Put 100 litres in tank...");
                        p.FuelInTank = 100;
                        Console.WriteLine($"Fuel in tank: {p.FuelInTank}");
                        Console.WriteLine("Put 50 litres in tank...");
                        p.FuelInTank = 50;
                        Console.WriteLine($"Fuel in tank: {p.FuelInTank}");
                        Console.WriteLine($"Now is {p.NumberOfPassengers} passengers in it");
                        Console.WriteLine($"Push 25 passengers!");
                        p.NumberOfPassengers = 25;
                        Console.WriteLine($"But is {p.NumberOfPassengers} passengers in it");
                        Console.WriteLine($"Remaining distance is: {p.RemainingDistanceGross()} km");
                        Console.WriteLine($"Now take only one passenger...");
                        p.NumberOfPassengers = 1;
                        Console.WriteLine($"And remaining distance is: {p.RemainingDistanceGross()} km");
                        var travelDist = p.RemainingDistanceGross() - 0.2 * p.RemainingDistanceGross();
                        Console.WriteLine($"If travel distance is {travelDist} km, and car speed is {p.Speed} km/h. " +
                            $"Travel time is: {p.TravelTime(travelDist)}");
                        travelDist = p.RemainingDistanceGross() + 0.2 * p.RemainingDistanceGross();
                        Console.WriteLine($"If travel distance is {travelDist} km, and car speed is {p.Speed} km/h. " +
                            $"Travel time is: {p.TravelTime(travelDist)} and fuel ran out without reaching endpoint...");
                        travelDist = p.RemainingDistanceGross() + 0.3 * p.RemainingDistanceGross();
                        Console.WriteLine($"If travel distance is {travelDist} km, and car speed is {p.Speed} km/h. " +
                            $"Travel time is: {p.TravelTime(travelDist)} and fuel ran out without reaching endpoint...");
                        p.FuelInTank = p.FuelInTank * 1.3;
                        Console.WriteLine($"Now fuel in tank: {p.FuelInTank} and remaining distance is: {p.RemainingDistanceGross()}");
                        Console.WriteLine($"If travel distance is {travelDist} km, and car speed is {p.Speed} km/h. " +
                            $"Travel time is: {p.TravelTime(travelDist)} and fuel ran out but we reach endpoint!");
                        break;
                    case FreightCar f:
                        Console.WriteLine("Put 400 litres in tank...");
                        f.FuelInTank = 400;
                        Console.WriteLine($"Fuel in tank: {f.FuelInTank}");
                        Console.WriteLine("Put 200 litres in tank...");
                        f.FuelInTank = 200;
                        Console.WriteLine($"Fuel in tank: {f.FuelInTank}");
                        Console.WriteLine($"Now loaded cargo {f.LoadedCargo} kg");
                        Console.WriteLine($"Load 8000 kg!");
                        f.LoadedCargo = 8000;
                        Console.WriteLine($"But is {f.LoadedCargo} kg in it");
                        Console.WriteLine($"Now remaining distance is: {f.RemainingDistanceGross()} km");
                        Console.WriteLine($"Now take 3000 kg of cargo");
                        f.LoadedCargo = 3000;
                        Console.WriteLine($"And remaining distance is: {f.RemainingDistanceGross()} km");
                        travelDist = f.RemainingDistanceGross() - 0.2 * f.RemainingDistanceGross();
                        Console.WriteLine($"If travel distance is {travelDist} km, and car speed is {f.Speed} km/h. " +
                            $"Travel time is: {f.TravelTime(travelDist)}");
                        travelDist = f.RemainingDistanceGross() + 0.2 * f.RemainingDistanceGross();
                        Console.WriteLine($"If travel distance is {travelDist} km, and car speed is {f.Speed} km/h. " +
                            $"Travel time is: {f.TravelTime(travelDist)} and fuel ran out without reaching endpoint...");
                        travelDist = f.RemainingDistanceGross() + 0.3 * f.RemainingDistanceGross();
                        Console.WriteLine($"If travel distance is {travelDist} km, and car speed is {f.Speed} km/h. " +
                            $"Travel time is: {f.TravelTime(travelDist)} and fuel ran out without reaching endpoint...");
                        f.FuelInTank = f.FuelInTank * 1.3;
                        Console.WriteLine($"Now fuel in tank: {f.FuelInTank} and remaining distance is: {f.RemainingDistanceGross()}");
                        Console.WriteLine($"If travel distance is {travelDist} km, and car speed is {f.Speed} km/h. " +
                            $"Travel time is: {f.TravelTime(travelDist)} and fuel ran out but we reach endpoint!");
                        break;
                    case SportCar s:
                        Console.WriteLine("Put 100 litres in tank...");
                        s.FuelInTank = 100;
                        Console.WriteLine($"Fuel in tank: {s.FuelInTank}");
                        Console.WriteLine("Put 30 litres in tank...");
                        s.FuelInTank = 30;
                        Console.WriteLine($"Fuel in tank: {s.FuelInTank}");
                        Console.WriteLine($"And remaining distance is: {s.RemainingDistanceGross()} km");
                        travelDist = s.RemainingDistanceGross() - 0.2 * s.RemainingDistanceGross();
                        Console.WriteLine($"If travel distance is {travelDist} km, and car speed is {s.Speed} km/h. " +
                            $"Travel time is: {s.TravelTime(travelDist)}");
                        travelDist = s.RemainingDistanceGross() + 0.2 * s.RemainingDistanceGross();
                        Console.WriteLine($"If travel distance is {travelDist} km, and car speed is {s.Speed} km/h. " +
                            $"Travel time is: {s.TravelTime(travelDist)} and fuel ran out without reaching endpoint...");
                        travelDist = s.RemainingDistanceGross() + 0.3 * s.RemainingDistanceGross();
                        Console.WriteLine($"If travel distance is {travelDist} km, and car speed is {s.Speed} km/h. " +
                            $"Travel time is: {s.TravelTime(travelDist)} and fuel ran out without reaching endpoint...");
                        s.FuelInTank = s.FuelInTank * 1.3;
                        Console.WriteLine($"Now fuel in tank: {s.FuelInTank} and remaining distance is: {s.RemainingDistanceGross()}");
                        Console.WriteLine($"If travel distance is {travelDist} km, and car speed is {s.Speed} km/h. " +
                            $"Travel time is: {s.TravelTime(travelDist)} and fuel ran out but we reach endpoint!");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("----------------------------------------------------");
            }
            Console.ReadLine();
        }
    }
}
