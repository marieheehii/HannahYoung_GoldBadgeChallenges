using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Ingredient_Repository
    {
        private readonly List<Ingredient> _ingredientDatabase = new List<Ingredient>();
        public bool AddIngredientToDataBase(Ingredient ingredient)
        {
            if (ingredient != null)
            {
                _ingredientDatabase.Add(ingredient);
                return true;
            }else{
                return false;
            }
        }
    }
