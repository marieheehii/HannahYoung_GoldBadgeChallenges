using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Program_UI
    {
      private readonly Menu_Repository _mRepo = new  Menu_Repository();
      private readonly Ingredient_Repository _iRepo = new  Ingredient_Repository();
      public void Run()
      {
          SeedData();
          RunApplicaiton();
      }

    private void RunApplicaiton()
    {
        throw new NotImplementedException();
    }

    private void SeedData()
    {
        throw new NotImplementedException();
    }
}