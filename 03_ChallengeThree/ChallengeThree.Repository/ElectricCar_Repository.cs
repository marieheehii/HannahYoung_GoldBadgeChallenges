using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class ElectricCar_Repository
    {
        private readonly List<ElectricCar> _eCarDatabase = new List<ElectricCar>();
        
        public bool AddECarToDatabase(ElectricCar electricCar)
        {
            if(electricCar!= null)
            {
                _eCarDatabase.Add(electricCar);
                return true;
            }
            else
            {
                return false;
            }
        }
        public ElectricCar GetElectricCarByModel(string model)
        {
            foreach (ElectricCar electricCar in _eCarDatabase)
            {
                if(electricCar.Model == model)
                {
                    return electricCar;
                }
            }
            return null;
        }
        public bool UpdateECarData(string eCarModel, ElectricCar newECarData)
        {
            ElectricCar oldECardata = GetElectricCarByModel(eCarModel);
            if (oldECardata != null)
            {
                oldECardata.Make = newECarData.Make;
                oldECardata.Model = newECarData.Model;
                oldECardata.HorsePower = newECarData.HorsePower;
                oldECardata.TopSpeed = newECarData.TopSpeed;
                oldECardata.MilesPerGallon = oldECardata.MilesPerGallon;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveECarFromDatabase(string model)
        {
            var electricCar = GetElectricCarByModel(model);
            if (electricCar != null)
            {
                _eCarDatabase.Remove(electricCar);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
