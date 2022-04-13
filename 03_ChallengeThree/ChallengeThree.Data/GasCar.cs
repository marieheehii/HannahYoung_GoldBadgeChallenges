using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class GasCar
    {
        public GasCar(){}
        public GasCar(string make, string model, int topSpeed, int horsePower, int milesPerGallon)
        {
            Make=make;
            Model=model;
            TopSpeed=topSpeed;
            HorsePower=horsePower;
            MilesPerGallon=milesPerGallon;
        }
        public string Make { get; set; }
        public string  Model { get; set; }
        public int TopSpeed { get; set; }
        public int HorsePower { get; set; }
        public int MilesPerGallon {get; set;}
    }
