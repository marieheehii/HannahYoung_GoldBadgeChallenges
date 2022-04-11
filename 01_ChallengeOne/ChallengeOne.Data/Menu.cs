using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Menu
    {
        public Menu(){}
        public Menu(string foodName, string description, decimal price, List<Ingredient> ingredients)
        {
            FoodName = foodName;
            Description = description;
            Price = price;
            Ingredients = ingredients;
        }
        public int ID { get; set; }
        public string FoodName { get; set; }
        public string Description { get; set; }
        public decimal Price {get; set;}
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        
    }