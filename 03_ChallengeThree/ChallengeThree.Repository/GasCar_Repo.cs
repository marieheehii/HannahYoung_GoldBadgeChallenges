using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class GasCar_Repo
    {
        private readonly List<GasCar> _gCarDatabase = new List<GasCar>();
        
        public bool AddGCarToDatabase(GasCar gasCar)
        {
            if(gasCar!= null)
            {
                _gCarDatabase.Add(gasCar);
                return true;
            }
            else
            {
                return false;
            }
        }
        public GasCar GetGasCarByModel(string model)
        {
            foreach (GasCar gasCar in _gCarDatabase)
            {
                if(gasCar.Model == model)
                {
                    return gasCar;
                }
            }
            return null;
        }
        public bool UpdateGCarData(string gCarModel, GasCar newGCarData)
        {
            GasCar oldGCardata = GetGasCarByModel(gCarModel);
            if (oldGCardata != null)
            {
                oldGCardata.Make = newGCarData.Make;
                oldGCardata.Model = newGCarData.Model;
                oldGCardata.HorsePower = newGCarData.HorsePower;
                oldGCardata.TopSpeed = newGCarData.TopSpeed;
                oldGCardata.MilesPerGallon = oldGCardata.MilesPerGallon;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveGCarFromDatabase(string model)
        {
            var gasCar = GetGasCarByModel(model);
            if (gasCar != null)
            {
                _gCarDatabase.Remove(gasCar);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
