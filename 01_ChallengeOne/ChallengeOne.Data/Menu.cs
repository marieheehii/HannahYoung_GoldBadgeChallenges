using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Menu
    {
        public int ID { get; set; }
        public string FoodName { get; set; }
        public string Description { get; set; }
        public decimal Price {get; set;}
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        
    }