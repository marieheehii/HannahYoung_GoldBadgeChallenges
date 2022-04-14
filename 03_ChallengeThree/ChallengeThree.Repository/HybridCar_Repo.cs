using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class HybridCar_Repo
    {
        private readonly List<HybridCar> _hCarDatabase = new List<HybridCar>();
        
        public bool AddHCarToDatabase(HybridCar hybridCar)
        {
            if(hybridCar!= null)
            {
                _hCarDatabase.Add(hybridCar);
                return true;
            }
            else
            {
                return false;
            }
        }
        public HybridCar GetHybridCarByModel(string model)
        {
            foreach (HybridCar hybridCar in _hCarDatabase)
            {
                if(hybridCar.Model == model)
                {
                    return hybridCar;
                }
            }
            return null;
        }
        public bool UpdateHCarData(string hCarModel, HybridCar newHCarData)
        {
            HybridCar oldHCardata = GetHybridCarByModel(hCarModel);
            if (oldHCardata != null)
            {
                oldHCardata.Make = newHCarData.Make;
                oldHCardata.Model = newHCarData.Model;
                oldHCardata.HorsePower = newHCarData.HorsePower;
                oldHCardata.TopSpeed = newHCarData.TopSpeed;
                oldHCardata.MilesPerGallon = newHCarData.MilesPerGallon;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveHCarFromDatabase(string model)
        {
            var hybridCar = GetHybridCarByModel(model);
            if (hybridCar != null)
            {
                _hCarDatabase.Remove(hybridCar);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
