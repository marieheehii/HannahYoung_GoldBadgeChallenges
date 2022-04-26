using Xunit;


public class ChallengeThree_Tests
{
    private Cars _car;
    private Cars_Repository _cRepo;

    public Menu_Repo_Testing_Site()
    {
        _car = new Cars("Toyota", "Camry", 130, 1500, 17, false, true, false);
        _cRepo = new Cars_Repository();
        _cRepo.AddCarToDatabase(_car);
    }
    [Fact]
    public void Add_Car_ShouldReturnTrue()
    {
        Cars car = new Cars();
        Cars_Repository repository = new Cars_Repository();
        bool addResult = _cRepo.AddCarToDatabase(car);
        bool expected = true;
        Assert.Equal(expected, addResult);
    }
    [Fact]
    public void Remove_Car_ShouldreturnTrue()
    {
        Cars car = _cRepo.GetCarByID(_car.ID);
        bool removeResult = _cRepo.RemoveCarFromDatabase(car);
        Asser.True(removeResult);
    }
}