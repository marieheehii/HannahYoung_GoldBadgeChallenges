using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Cars
    {
        public List<ElectricCar> ElectricCars {get; set;} = new List<ElectricCar>();
        public List<GasCar> GasCars { get; set; } = new List<GasCar>();
        public List<HybridCar> HybridCars { get; set; } = new List<HybridCar>();
    }
