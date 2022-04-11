using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Ingredient
    {
        public Ingredient(){}
        public Ingredient(string ingredientName)
        {
            IngredientName = ingredientName;
        }
        public string IngredientName { get; set; }
    }
