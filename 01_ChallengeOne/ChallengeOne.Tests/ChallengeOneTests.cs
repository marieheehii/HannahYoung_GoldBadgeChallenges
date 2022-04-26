using Xunit;

public class ChallengeOneTests
{
    private Menu _menuItem;
    private Menu_Repository _mRepo;

    public Menu_Repo_Testing_Site()
    {
        _menuItem = new Menu("Golden Wind Blend", "A light, sweet golden colored blend of smooth coffee", 
        5.99, "coffee beans, water and vanilla");
        _mRepo = new Menu_Repository();
        _mRepo.AddMenuToDataBase(_menuItem);
    }

    [Fact]
    public void Add_To_Directory_Correct_Boolean()
    {
        Menu newItem = new Menu();
        Menu_Repository repository = new Menu_Repository();

        bool addResult = repository.AddMenuToDataBase(newItem);
        bool expected = true;
        Assert.Equal(expected, addResult);
    }
    [Fact]
    public void Get_Menu_By_ID_ShouldReturnTrue()
    {
        Menu searchedItem = _mRepo.GetMenuByID(_menuItem.ID);
        Assert.Equal(searchedItem, _menuItem.ID);

    }
}