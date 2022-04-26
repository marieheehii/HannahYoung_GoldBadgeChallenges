public class Program_UI
    {
        private readonly Outings_Repository _oRepo = new Outings_Repository();
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
            System.Console.WriteLine("---Welcome to your Companies Outings---");
            System.Console.WriteLine("Please Make a Selection\n"+
            "1. Add Outing to Database\n"+
            "2. Veiw all Outings\n"+
            "3. Veiw Outing by ID\n"+
            "4. Delete Outing Data\n"+
            "5. Combine Cost for all Outings\n"+
            "6. Combine Cost Outings by Event Type\n"+
            "50 Close Application\n" +
            "-------------------------------");
            var userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                AddOutingToDatabase();
                break;
                case "2":
                ViewAllOutings();
                break;
                case "3":
                ViewOutingByID();
                break;
                case "4":
                DeleteOutingFromDatabase();
                break;
                case "5":
                CombinedCostForAllOutings();
                break;
                case "6":
                CombinedOutingsCostByType();
                break;
                case "50":
                isRunning = CloseApplicaton();
                break;
                default:
                System.Console.WriteLine("Invalid Selection");
                PressAnyKeyToContinue();
                break;
            }
        }
    }

    private void CombinedOutingsCostByType()
    {
        Console.Clear();
        System.Console.WriteLine("-----Combined Outings Cost By Type Page----\n");
        System.Console.WriteLine("Event Types:\n"+
        "Bowling=1\n" +
        "Skiing = 2\n" +
        "Dinner =3\n" +
        "Golfing=4\n" +
        "AmuesmentParks=5\n" +
        "Concerts=6\n" +
        "-----------------");
        
        
        
        System.Console.WriteLine("Please enter the event Type...");
        var userInputSelectedEventType = (EventType)Convert.ToInt32(Console.ReadLine());
        var totalCost = _oRepo.GetTotalCostByEventType(userInputSelectedEventType);
        System.Console.WriteLine($"${totalCost}");
        PressAnyKeyToContinue();
    }

    private void CombinedCostForAllOutings()
    {
        Console.Clear();
        System.Console.WriteLine("---Combined Costs Page----");
        var outingsInDb = _oRepo.GetAllOutings();
        double PriceSum = 0;
        foreach (var outings in outingsInDb)
        {
         PriceSum += outings.EventCost;
        }
        System.Console.WriteLine($"Your combined cost for all outings is ${PriceSum}");
        PressAnyKeyToContinue();
    }

    private bool CloseApplicaton()
    {
        Console.Clear();
        System.Console.WriteLine("Thanks for Reviewing the company Outings!!");
        PressAnyKeyToContinue();
        return false;
    }

    private void PressAnyKeyToContinue()
    {
        System.Console.WriteLine("Press Any Key To Continue...");
        Console.ReadKey();
    }

    private void DeleteOutingFromDatabase()
    {
        Console.Clear();
        System.Console.WriteLine("---Outings Removal Page---");
        var allOutings = _oRepo.GetAllOutings();
        foreach(Outings outings in allOutings)
        {
            DisplayOutingsListing(outings);
        }
        try
        {
            System.Console.WriteLine("Please Select an Outing by its ID:");
            var userInputSelectedOuting = int.Parse(Console.ReadLine());
            bool isSuccessful = _oRepo.RemoveOutingFromDatabase(userInputSelectedOuting);
            if(isSuccessful)
            {
                System.Console.WriteLine("Outing was successfully deleted");
            }
            else
            {
                System.Console.WriteLine("Outing failed to be deleted");
            }
        }
        catch
        {
            System.Console.WriteLine("Sorry, invalid selection...");
        }
        PressAnyKeyToContinue();
    }

    private void UpdateOuting()
    {
        throw new NotImplementedException();
    }

    private void ViewOutingByID()
    {
        Console.Clear();
        System.Console.WriteLine("------Outing Deatils-----");
        var allOutings = _oRepo.GetAllOutings();
        foreach(Outings outings in allOutings)
        {
            DisplayOutingsListing(outings);
        }
        try
        {
            System.Console.WriteLine("Please select an outing by its ID:");
            var userInputSelectedOuting = int.Parse(Console.ReadLine());
            var selectedOuting = _oRepo.GetOutingsByID(userInputSelectedOuting);
            if (selectedOuting != null)
            {
                DisplayOutingDetails(selectedOuting);
            }
            else{
                System.Console.WriteLine($"Sorry, the outing with the ID: {userInputSelectedOuting} doesn't exist");
            }
        }
        catch
        {
            System.Console.WriteLine("Sorry, invalid selection.");
        }
        PressAnyKeyToContinue();
    }

    private void DisplayOutingDetails(Outings selectedOuting)
    {
        Console.Clear();
        System.Console.WriteLine($"Outing ID: {selectedOuting.ID}\n" +
        $"Event Type: {selectedOuting.EventType}\n" +
        $"Event Cost: ${selectedOuting.EventCost}\n" +
        $"Event Cost Per Person: ${selectedOuting.EventCostPerPerson}\n"+
        $"Number Attended: {selectedOuting.NumberAttended}\n" +
        $"Date: {selectedOuting.Month}/{selectedOuting.Day}/{selectedOuting.Year}\n"+
        "------------------------------------------");
        PressAnyKeyToContinue();
    }

    private void ViewAllOutings()
    {
        Console.Clear();
        System.Console.WriteLine("----Outings Listings----\n");
        var outingsInDb = _oRepo.GetAllOutings();
        foreach (var outings in outingsInDb)
        {
            DisplayOutingsListing(outings);
        }
        PressAnyKeyToContinue();
    }

    private void DisplayOutingsListing(Outings outings)
    {
        System.Console.WriteLine($"{outings.ID}.) {outings.EventType} on {outings.Month}/{outings.Day}/{outings.Year}");
    }

    private void AddOutingToDatabase()
    {
        Console.Clear();
        var newOuting = new Outings();
        System.Console.WriteLine("Event Types:\n"+
        "Bowling=1\n" +
        "Skiing = 2\n" +
        "Dinner =3\n" +
        "Golfing=4\n" +
        "Ameusment Parks=5\n" +
        "Concerts=6\n" +
        "-----------------\n");
        
        System.Console.WriteLine("Please enter the outing type by its Event ID...");
        newOuting.EventType = (EventType)Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter The event Cost:");
        newOuting.EventCost = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter The Event Cost Per Person:");
        newOuting.EventCostPerPerson = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter The number Attended:");
        newOuting.NumberAttended = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter The Month of the Event in two number format: ex.(05)");
        newOuting.Month = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter The Day of the Event in two number format: ex.(05)");
        newOuting.Day = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter The Year of the Event in four number format: ex.(05)");
        newOuting.Year = int.Parse(Console.ReadLine());
    

        bool isSuccessful = _oRepo.AddOutingToDatabase(newOuting);
        if(isSuccessful)
        {
            System.Console.WriteLine($"{newOuting.EventType} on {newOuting.Month}/{newOuting.Day}/{newOuting.Year} was added to the  outings database!");
        }
        else{
            System.Console.WriteLine("your outing was failed to be added to the database");
        }

        PressAnyKeyToContinue();
    }

    private void SeedData()
    {
        var bowling = new Outings(EventType.Bowling, 37, 2022, 04, 21, 23.00, 602.99);
        var bowling2 = new Outings(EventType.Bowling, 37, 2022, 04, 21, 23.00, 802.99);
        var skiing = new Outings(EventType.Concert, 37, 2022, 04, 21, 23.00, 1902.99);
        var ameusmentPark = new Outings(EventType.AmusementPark, 37, 2022, 04, 21, 23.00, 1902.99);
        var dinner = new Outings(EventType.Dinner, 37, 2022, 04, 21, 23.00, 102.99);
        var golfing = new Outings(EventType.Golfing, 37, 2022, 04, 21, 23.00, 702.99);

        _oRepo.AddOutingToDatabase(bowling);
        _oRepo.AddOutingToDatabase(bowling2);
        _oRepo.AddOutingToDatabase(skiing);
        _oRepo.AddOutingToDatabase(ameusmentPark);
        _oRepo.AddOutingToDatabase(dinner);
        _oRepo.AddOutingToDatabase(golfing);

    }
    
    }
