using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Program_UI
    {
        private readonly ElectricCar_Repository _eRepo = new ElectricCar_Repository();
        private readonly GasCar_Repo _gRepo = new GasCar_Repo();
        private readonly HybridCar_Repo _hRepo = new HybridCar_Repo();
        private readonly Cars_Repository _cRepo = new Cars_Repository();

        

        public void Run()
        {
            SeedData();
            RunApplication();

        }

    private void RunApplication()
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            System.Console.WriteLine("Welcome!\n");
            System.Console.WriteLine("Please make a selection for Car Statistics:\n" +
            "1. Veiw All Cars\n" +
            "2. Add a Car\n" +
            "3. Update a Car\n" +
            "4. Remove a Car\n" +
            "5. Veiw all Electric Cars\n" +
            "6. Veiw all Gas Cars\n" +
            "7. Veiw all Hybrid Cars\n" +
            "8. Select Car Statistics by Model\n" +
            "-------------------------\n" +
            "50. Close application\n");
            var userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                ViewAllCars();
                break;
                case "2":
                AddCar();
                break;
                case "3":
                UpdateCar();
                break;
                case "4":
                RemoveCar();
                break;
                case "5":
                ViewElectricCars();
                break;
                case "6":
                ViewGasCars();
                break;
                case "7":
                ViewHybridCars();
                break;
                case "8":
                ViewCarByID();
                break;
                case "50":
                CloseApplication();
                break;
                default:
                System.Console.WriteLine("Sorry, Invalid selection");
                PressAnyKeyToContinue();
                break;
            }

        }
    }

    private void RemoveCar()
    {
         Console.Clear();
        System.Console.WriteLine("=== Car Removal ===");


        var allCars = _cRepo.GetAllCars();
        foreach (Cars cars in allCars)
        {
            DisplayCarListings(cars);
        }

        try
        {
            System.Console.WriteLine("Please select a car by its ID:");
            var userInputSelectedCar = int.Parse(Console.ReadLine());
            bool isSuccessful = _cRepo.RemoveCarFromDatabase(userInputSelectedCar);
            if (isSuccessful)
            {
                System.Console.WriteLine("Car was Successfully Deleted.");
            }
            else
            {
                System.Console.WriteLine("Car Failed to be Deleted.");
            }
        }
        catch
        {
            System.Console.WriteLine("Sorry, invalid selection.");
        }
    }

    private void UpdateCar()
    {
        Console.Clear();
        var availCars = _cRepo.GetAllCars();
        foreach(var cars in availCars)
        {
            DisplayCarListings(cars);
        }
        System.Console.WriteLine("Please enter a Valid Car ID");
        var userInputCarID= int.Parse(Console.ReadLine());
        var userSelectedCar = _cRepo.GetCarByID(userInputCarID);
        if(userSelectedCar != null)
        {
            var newCar = new Cars();
        System.Console.WriteLine("Please enter a Car Model");
        newCar.Model = Console.ReadLine();
        System.Console.WriteLine("Please enter a Car Make");
        newCar.Make = Console.ReadLine();
        System.Console.WriteLine("Please enter a Car Top Speed");
        newCar.TopSpeed = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Please enter a Car MilesPerGallon");
        newCar.MilesPerGallon = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Please enter a Car HorsePower");
        newCar.HorsePower = int.Parse(Console.ReadLine());
        System.Console.WriteLine("True or False? Your car is Electric.");
        newCar.IsElectric = bool.Parse(Console.ReadLine());
        System.Console.WriteLine("True or False? Your car is a Hybrid.");
        newCar.IsHybrid = bool.Parse(Console.ReadLine());
        System.Console.WriteLine("True or False? Your car is Gas Powered.");
        newCar.IsGas = bool.Parse(Console.ReadLine());
        bool isSuccessful = _cRepo.AddCarToDatabase(newCar);
        if(isSuccessful)
        {
            System.Console.WriteLine($"Your {newCar.Make} {newCar.Model} was updated in the database! ");
        }
        else{
            System.Console.WriteLine("Car failed to be updated the database...");
        }
        
        }

        else{
            System.Console.WriteLine($"Sorry the car with the ID {userInputCarID} ");
        }
        PressAnyKeyToContinue();
    }

    private void AddCar()
    {
        Console.Clear();
        var newCar = new Cars();
        System.Console.WriteLine("Please enter a Car Model");
        newCar.Model = Console.ReadLine();
        System.Console.WriteLine("Please enter a Car Make");
        newCar.Make = Console.ReadLine();
        System.Console.WriteLine("Please enter a Car Top Speed");
        newCar.TopSpeed = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Please enter a Car MilesPerGallon");
        newCar.MilesPerGallon = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Please enter a Car HorsePower");
        newCar.HorsePower = int.Parse(Console.ReadLine());
        System.Console.WriteLine("True or False? Your car is Electric.");
        newCar.IsElectric = bool.Parse(Console.ReadLine());
        System.Console.WriteLine("True or False? Your car is a Hybrid.");
        newCar.IsHybrid = bool.Parse(Console.ReadLine());
        System.Console.WriteLine("True or False? Your car is Gas Powered.");
        newCar.IsGas = bool.Parse(Console.ReadLine());
        bool isSuccessful = _cRepo.AddCarToDatabase(newCar);
        if(isSuccessful)
        {
            System.Console.WriteLine($"Your {newCar.Make} {newCar.Model} was added to the database! ");
        }
        else{
            System.Console.WriteLine("Car failed to be added to the database...");
        }
        PressAnyKeyToContinue();

    }

    private void ViewCarByID()
    {
        Console.Clear();
        System.Console.WriteLine("----Car Detail Menu----");
        var allCars = _cRepo.GetAllCars();
        foreach(Cars cars in allCars)
        {
            DisplayCarListings(cars);
        }
        try
        {
            System.Console.WriteLine("Please select a car by its id");
            var userInputSelectedCar = int.Parse(Console.ReadLine());
            var selectedCar = _cRepo.GetCarByID(userInputSelectedCar);
            if (selectedCar != null)
            {
                DisplayCarListings(selectedCar);
                
            }else{
                System.Console.WriteLine($"Sorry. the car with the id {userInputSelectedCar} does not exist.");
            }
        }
        catch
        {
            System.Console.WriteLine("Sorry, invalid selection");
        }
        PressAnyKeyToContinue();
    }


    private void ViewHybridCars()
    {
       Console.Clear();
       System.Console.WriteLine("-------All Car Listings-----");
       var carsInDB = _cRepo.GetAllCars();
           foreach(var cars in carsInDB)
       {
           DisplayHybridCarDetails(cars);
       }
       
       
       PressAnyKeyToContinue();
    }

    private void DisplayHybridCarDetails(Cars cars)
    {
        if(cars.IsHybrid == true)
        {
        System.Console.WriteLine($"Make: {cars.Make} Model: {cars.Model}\n" +
        $"MPG: {cars.MilesPerGallon}\n" +
        $"Top Speed: {cars.TopSpeed}\n" +
        $"HP: {cars.HorsePower}\n" +
        "--------------------------------");
        }
        else{
            System.Console.WriteLine("");
        }

    }

    private void ViewGasCars()
    {
        Console.Clear();
       System.Console.WriteLine("-------All Car Listings-----");
       var carsInDB = _cRepo.GetAllCars();
           foreach(var cars in carsInDB)
       {
           DisplayGasCarDetails(cars);
       }
       
       
       PressAnyKeyToContinue();
    }

    private void DisplayGasCarDetails(Cars cars)
    {
        if(cars.IsGas == true)
        {
        System.Console.WriteLine($"Make: {cars.Make} Model: {cars.Model}\n" +
        $"MPG: {cars.MilesPerGallon}\n" +
        $"Top Speed: {cars.TopSpeed}\n" +
        $"HP: {cars.HorsePower}\n" +
        "--------------------------------");
        }
        else{
            System.Console.WriteLine("");
        }
    }

    private void ViewElectricCars()
    {
         Console.Clear();
       System.Console.WriteLine("-------All Car Listings-----");
       var carsInDB = _cRepo.GetAllCars();
           foreach(var cars in carsInDB)
       {
           DisplayElectricCarDetails(cars);
       }
       
       
       PressAnyKeyToContinue();
    }

    private void DisplayElectricCarDetails(Cars cars)
    {
        if(cars.IsElectric == true)
        {
        System.Console.WriteLine($"Make: {cars.Make} Model: {cars.Model}\n" +
        $"MPG: {cars.MilesPerGallon}\n" +
        $"Top Speed: {cars.TopSpeed}\n" +
        $"HP: {cars.HorsePower}\n" +
        "--------------------------------");
        }
        else{
            System.Console.WriteLine("");
        }
    }

    private void ViewAllCars()
    {
       Console.Clear();
       System.Console.WriteLine("-------All Car Listings-----");
       var carsInDB = _cRepo.GetAllCars();
       foreach(var cars in carsInDB)
       {
           DisplayCarListings(cars);
       }
       PressAnyKeyToContinue();
    }

    private void DisplayCarListings(Cars cars)
    {
        System.Console.WriteLine($" ID: {cars.ID}\n Make: {cars.Make} Model: {cars.Model}\n");
        if(cars.IsElectric == true)
        {
            System.Console.WriteLine("Is Electric\n"+
            "-------------------");
        }
        else if(cars.IsGas == true)
        {
            System.Console.WriteLine("Is Gas\n" +
            "-------------------");
        }
        else
        {
            System.Console.WriteLine("Is Hybrid\n" +
            "-------------------");
        }
    }

    private bool CloseApplication()
    {
        Console.Clear();
        System.Console.WriteLine("Thanks!!");
        PressAnyKeyToContinue();
        return false;
    }

    private void PressAnyKeyToContinue()
    {
        System.Console.WriteLine("Press any key to continue!");
        Console.ReadKey();
    }

    private void SeedData()
    {
        var Tahoe = new Cars("Chevy", "Tahoe", 130, 1500, 17, false, false, true);
        var Civic = new Cars("Honda", "Civic", 130, 1500, 17, false, false, true);
        var Ioniq = new Cars("Honda", "Ioniq", 130, 1500, 17, false, true, false);
        var Camry = new Cars("Toyota", "Camry", 130, 1500, 17, false, true, false);
        var ModelThree = new Cars("Tesla", "Model 3", 130, 1500, 17, true, false, false);
        var Kona = new Cars("Hyundai", "Kona", 130, 1500, 17, true, false, false);

        _cRepo.AddCarToDatabase(ModelThree);
        _cRepo.AddCarToDatabase(Kona);
        _cRepo.AddCarToDatabase(Camry);
        _cRepo.AddCarToDatabase(Ioniq);
        _cRepo.AddCarToDatabase(Civic);
        _cRepo.AddCarToDatabase(Tahoe);
    }
}
