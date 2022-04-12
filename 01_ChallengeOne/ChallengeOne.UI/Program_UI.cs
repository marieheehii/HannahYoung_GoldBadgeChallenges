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
                ViewMenuByID();
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
        System.Console.WriteLine("Press any Key to continue...");
        Console.ReadKey();
    }

    private bool CloseApplication()
    {
        Console.Clear();
        System.Console.WriteLine("Thanks!");
        PressAnyKeyToContinue();
        return false;
    }

    private void RemoveMenuFromDatabase()
    {
       Console.Clear();
       System.Console.WriteLine("Test to Delete");
       PressAnyKeyToContinue();

    }

    private void ViewMenuByID()
    {
        Console.Clear();
        var menuItem = _mRepo.GetEveryMenu();
        foreach(Menu menu in menuItem)
        {
            DisplayMenu(menu);
        }
        try 
        {
            System.Console.WriteLine("PLease select a menu ITem by its ID");
            var userInputSelectedMenuItem = int.Parse(Console.ReadLine());
            var selectedMenuItem = _mRepo.GetMenuByID(userInputSelectedMenuItem);
            if (selectedMenuItem != null)
            {
                DisplayMenuItemDetails();
            }
            else
            {
                System.Console.WriteLine($"Sorry the menu item with the id {userInputSelectedMenuItem} doesnt exist. ");
            }
        }
        catch
        {
            System.Console.WriteLine("Sorry, invalid selection.");
        }
        PressAnyKeyToContinue();
    }

    private void DisplayMenuItemDetails()
    {
        Console.Clear();
        System.Console.WriteLine($"{selectedMenuItem.ID}{selectedMenuItem.FoodName}\n {selectedMenuItem.Price}\n {selectedMenuItem.Ingredients}");

        PressAnyKeyToContinue();
    }

    private void GetAllMenus()
    {
        Console.Clear();
        System.Console.WriteLine("----Menu---");
        var menuInDb = _mRepo.GetEveryMenu();

        foreach(var menu in menuInDb)
        {
            DisplayMenu(menu);
        }
        PressAnyKeyToContinue();
    }

    private void DisplayMenu(Menu menu)
    {
        System.Console.WriteLine("test");
    }

    private void AddMenutoDataBase()
    {
        Console.Clear();
        var newMenu = new Menu();
        
        System.Console.WriteLine("Please enter your new Menu Item");
        newMenu.FoodName = Console.ReadLine();
        bool hasIngredients = false;
        while (!hasIngredients)
        {
            System.Console.WriteLine("What are the ingridents?");
            var userInputHasIngredients = Console.ReadLine();
        }
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