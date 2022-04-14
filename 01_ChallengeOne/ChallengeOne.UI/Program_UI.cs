using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Program_UI
    {
      private readonly Menu_Repository _mRepo = new  Menu_Repository();
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
                ViewAllMenus();
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
       System.Console.WriteLine("---Menu Item Removal Page---");
       var allMenuItems = _mRepo.GetEveryMenu();
       foreach(Menu menu in allMenuItems)
       {
           DisplayMenu(menu);
       }
       try
       {
           System.Console.WriteLine("Please select a Menu Item by it's ID");
           var userInputSelectedMenuItem = int.Parse(Console.ReadLine());
           bool isSuccessful = _mRepo.RemoveMenuFromDatabase(userInputSelectedMenuItem);
           if (isSuccessful)
           {
               System.Console.WriteLine($"{userInputSelectedMenuItem} was deleted");
           }
           else
           {
               System.Console.WriteLine("Deleteing was unsuccessful.");
           }
       }
       catch
       {
           System.Console.WriteLine("sorry invalid selection...");
       }
       PressAnyKeyToContinue();

    }

    private void ViewMenuByID()
    {
        Console.Clear();
        System.Console.WriteLine("----Menu Details---");
        var menuItem = _mRepo.GetEveryMenu();
        foreach(Menu menu in menuItem)
        {
            DisplayMenu(menu);
        }
        try 
        {
            System.Console.WriteLine("Please select a menu Item by it's ID");
            var userInputSelectedMenuItem = int.Parse(Console.ReadLine());
            var selectedMenuItem = _mRepo.GetMenuByID(userInputSelectedMenuItem);
            if (selectedMenuItem != null)
            {
                DisplayMenuItemDetails(selectedMenuItem);
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

    private void DisplayMenuItemDetails(Menu selectedMenuItem)
    {
        Console.Clear();
        System.Console.WriteLine($"{selectedMenuItem.ID} : {selectedMenuItem.FoodName}\n ${selectedMenuItem.Price}\n made with: {selectedMenuItem.Ingredients}");

        PressAnyKeyToContinue();
    }

    private void ViewAllMenus()
    {
        Console.Clear();
        System.Console.WriteLine("----JOJOs Cafe Menu---\n");
        var menuInDb = _mRepo.GetEveryMenu();

        foreach(var menu in menuInDb)
        {
            DisplayMenu(menu);
        }
        PressAnyKeyToContinue();
    }

    private void DisplayMenu(Menu menu)
    {
        System.Console.WriteLine($"{menu.ID} : {menu.FoodName}\n ${menu.Price}\n" +
        "-------------------------------");
    }

    private void AddMenutoDataBase()
    {
        Console.Clear();
        var newMenu = new Menu();
        
        System.Console.WriteLine("Please enter your new Menu Item name");
        newMenu.FoodName = Console.ReadLine();
       System.Console.WriteLine("Please enter your new Menu Item price. ex: 5.00");
        newMenu.Price = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Please enter your new Menu Item description");
        newMenu.Description = Console.ReadLine();
        System.Console.WriteLine("Please enter your new Menu Item ingridients seperated by a comma.");
        newMenu.Ingredients = Console.ReadLine();
         bool isSuccessful = _mRepo.AddMenuToDataBase(newMenu);
        if (isSuccessful)
        {
            System.Console.WriteLine($"Menu Item: {newMenu.FoodName} was Added to the Database.");
        }
        else
        {
            System.Console.WriteLine("Store Failed to be Added to the Database.");
        }
        PressAnyKeyToContinue();
    }

    private void SeedData()
    {

        var GoldenWindBlend = new Menu("Golden Wind Blend", "A light, sweet golden colored blend of smooth coffee", 5.99, "coffee beans, water and vanilla");
        var BucciaratiCookies= new Menu("BucciaratiCookies", "A light, sweet golden colored blend of smooth coffee", 5.99, "coffee beans, water and vanilla");
        var NaranciaTarts= new Menu("Narancia Tarts", "A light, sweet golden colored blend of smooth coffee", 5.99, "coffee beans, water and vanilla");
        var PannaCotta= new Menu("Panna Cotta","A light, sweet golden colored blend of smooth coffee", 5.99, "coffee beans, water and vanilla");
        var CaffeLeone= new Menu("Caffe Leone", "A light, sweet golden colored blend of smooth coffee", 5.99, "coffee beans, water and vanilla");
        var CaffeMarocchino= new Menu("Caffe Marocchino (Espressino)", "A light, sweet golden colored blend of smooth coffee", 5.99, "coffee beans, water and vanilla");
    

    _mRepo.AddMenuToDataBase(GoldenWindBlend);
    _mRepo.AddMenuToDataBase(BucciaratiCookies);
    _mRepo.AddMenuToDataBase(NaranciaTarts);
    _mRepo.AddMenuToDataBase(PannaCotta);
    _mRepo.AddMenuToDataBase(CaffeLeone);
    _mRepo.AddMenuToDataBase(CaffeMarocchino);




    /*DateTime time = new DateTime(2022,04,12);
    System.Console.WriteLine(time.Day);
    System.Console.WriteLine(time.Month);
    System.Console.WriteLine(time.Year);*/
    }
}