using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Cars
    {
        public Cars(){}
        public Cars(string make, string model, int topSpeed, int horsePower, int milesPerGallon, bool isElectric, bool isHybrid, bool isGas)
        { 
            Make=make;
            Model=model;
            TopSpeed=topSpeed;
            HorsePower=horsePower;
            MilesPerGallon=milesPerGallon;
            IsElectric = isElectric;
            IsGas = isGas;
            IsHybrid = isHybrid;


        }
        
        public string Make { get; set; }
        public string  Model { get; set; }
        public int TopSpeed { get; set; }
        public int HorsePower { get; set; }
        public int MilesPerGallon {get; set;}
        public bool IsElectric { get; set; }
        public bool IsGas { get; set; }
        public bool IsHybrid { get; set; }
        public int ID {get; set;}
    }
    
