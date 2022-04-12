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
        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            System.Console.WriteLine("+++Welcome to JOJOs CAFE+++");
            System.Console.WriteLine("Please make a selection \n"+
            "1.  Add Menu Item to Database\n" +
            "2.  View All Menu Items\n" +
            "3.  View Menu Item By ID\n" +
            "4.  Delete Menu Data\n" +
            "50. Close Application\n" +
            "------------------------------------\n");
            var userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                AddMenutoDataBase();
                break;
                case "2":
                GetAllMenus();
                break;
                case "3":
                GetMenuByID();
                break;
                case "4":
                RemoveMenuFromDatabase();
                break;
                case "50":
                isRunning = CloseApplication();
                break;
                default:
                System.Console.WriteLine("Invalid Selection");
                PressAnyKeyToContinue();
                break;
            }

        }
    }

    private void PressAnyKeyToContinue()
    {
        throw new NotImplementedException();
    }

    private bool CloseApplication()
    {
        throw new NotImplementedException();
    }

    private void RemoveMenuFromDatabase()
    {
        throw new NotImplementedException();
    }

    private void GetMenuByID()
    {
        throw new NotImplementedException();
    }

    private void GetAllMenus()
    {
        throw new NotImplementedException();
    }

    private void AddMenutoDataBase()
    {
        throw new NotImplementedException();
    }

    private void SeedData()
    {
        var water = new Ingredient("water");
        var coffeeBeans = new Ingredient("coffee beans");
        var hazelnut = new Ingredient("hazelnut");
        var brownSugar = new Ingredient("brown sugar");
        var cocoa = new Ingredient("cocoa");
        var whippedCream = new Ingredient("whipped cream");
        var sugar = new Ingredient("sugar");
        var milk = new Ingredient("milk");
        var skimMilk = new Ingredient("skim milk");
        var almondMilk = new Ingredient("almond milk");
        var coconutWater = new Ingredient("coconut water");
        var twoPercentMilk = new Ingredient("2% milk");
        var carmel = new Ingredient("carmel");
        var fruit = new Ingredient("fruit");

        var GoldenWindBlend = new Menu("Golden Wind Blend", "A light, sweet golden colored blend of smooth coffee", 5.99, new List<Ingredient>
        {
            coffeeBeans,
            water,
            hazelnut,
            brownSugar,
        });
        var BucciaratiCookies= new Menu("BucciaratiCookies", "A light, sweet golden colored blend of smooth coffee", 5.99, new List<Ingredient>
        {
            coffeeBeans,
            water,
            hazelnut,
            brownSugar,
        });
        var NaranciaTarts= new Menu("Narancia Tarts", "A light, sweet golden colored blend of smooth coffee", 5.99, new List<Ingredient>
        {
            coffeeBeans,
            water,
            hazelnut,
            brownSugar,
        });
        var PannaCotta= new Menu("Panna Cotta", "A light, sweet golden colored blend of smooth coffee", 5.99, new List<Ingredient>
        {
            coffeeBeans,
            water,
            hazelnut,
            brownSugar,
        });
        var CaffeLeone= new Menu("Caffe Leone", "A light, sweet golden colored blend of smooth coffee", 5.99, new List<Ingredient>
        {
            coffeeBeans,
            water,
            hazelnut,
            brownSugar,
        });
        var CaffeMarocchino= new Menu("Caffe Marocchino (Espressino", "A light, sweet golden colored blend of smooth coffee", 5.99, new List<Ingredient>
        {
            coffeeBeans,
            water,
            hazelnut,
            brownSugar,
        });
    }
}