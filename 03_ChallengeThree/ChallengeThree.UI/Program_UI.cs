using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Program_UI
    {
        private readonly ElectricCar_Repository _eRepo = new ElectricCar_Repository();
        private readonly GasCar_Repo _gRepo = new GasCar_Repo();
        private readonly HybridCar_Repo _hRepo = new HybridCar_Repo();

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
            "2. Veiw all Electric Cars\n" +
            "3. Add an Electirc Car\n" +
            "4. Update and Electric Car\n" +
            "5. Delete and Electric Car\n" +
            "6. Veiw all Gas Cars\n" +
            "7. Add an Gas Car\n" +
            "8. Update and Gas Car\n" +
            "9. Delete and Gas Car\n" +
            "10. Veiw all Hybrid Cars\n" +
            "11. Add an Hybrid Car\n" +
            "12. Update and Hybrid Car\n" +
            "13. Delete and Hybrid Car\n" +
            "14. Select Car Statistics by Model\n" +
            "-------------------------\n" +
            "50. Close application\n");
            var userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                ViewAllCars();
                break;
                case "2":
                ViewElectricCars();
                break;
                case "3":
                AddElectricCar();
                break;
                case "4":
                UpdateElectricCar();
                break;
                case "5":
                DeleteElectricCar();
                break;
                case "6":
                ViewGasCars();
                break;
                case "7":
                AddGasCar();
                break;
                case "8":
                UpdateGasCar();
                break;
                case "9":
                DeleteGasCar();
                break;
                case "10":
                ViewHybridCars();
                break;
                case "11":
                AddHybridCar();
                break;
                case "12":
                UpdateHybridCar();
                break;
                case "13":
                DeleteHybridCar();
                break;
                case "14":
                ViewCarByModel();
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

    private void ViewCarByModel()
    {
        throw new NotImplementedException();
    }

    private void DeleteHybridCar()
    {
        throw new NotImplementedException();
    }

    private void UpdateHybridCar()
    {
        throw new NotImplementedException();
    }

    private void AddHybridCar()
    {
        throw new NotImplementedException();
    }

    private void ViewHybridCars()
    {
        throw new NotImplementedException();
    }

    private void DeleteGasCar()
    {
        throw new NotImplementedException();
    }

    private void UpdateGasCar()
    {
        throw new NotImplementedException();
    }

    private void AddGasCar()
    {
        throw new NotImplementedException();
    }

    private void ViewGasCars()
    {
        throw new NotImplementedException();
    }

    private void DeleteElectricCar()
    {
        throw new NotImplementedException();
    }

    private void UpdateElectricCar()
    {
        throw new NotImplementedException();
    }

    private void AddElectricCar()
    {
        throw new NotImplementedException();
    }

    private void ViewElectricCars()
    {
        throw new NotImplementedException();
    }

    private void ViewAllCars()
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }
}
