using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Cars_Repository
    {
        private readonly List<Cars> _CarDatabase = new List<Cars>();
        private int _count = 0;
        
        public bool AddCarToDatabase(Cars cars)
        {
            if(cars!= null)
            {
                _count++;
                cars.ID = _count;
                _CarDatabase.Add(cars);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Cars GetCarByID(int id)
        {
            foreach (Cars cars in _CarDatabase)
            {
                if(cars.ID == id)
                {
                    return cars;
                }
            }
            return null;
        }
        public List<Cars> GetAllCars()
        {
            return _CarDatabase;
        }
       
        public bool UpdateCarData(int carID, Cars newCarData)
        {
            Cars oldCardata = GetCarByID(carID);
            if (oldCardata != null)
            {
                oldCardata.Make = newCarData.Make;
                oldCardata.Model = newCarData.Model;
                oldCardata.HorsePower = newCarData.HorsePower;
                oldCardata.TopSpeed = newCarData.TopSpeed;
                oldCardata.MilesPerGallon = oldCardata.MilesPerGallon;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveCarFromDatabase(int id)
        {
            var cars = GetCarByID(id);
            if (cars != null)
            {
                _CarDatabase.Remove(cars);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
