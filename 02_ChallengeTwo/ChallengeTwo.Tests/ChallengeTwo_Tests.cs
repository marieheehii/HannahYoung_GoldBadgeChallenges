using Xunit;

namespace ChallengeTwo.Tests;

public class ChallengeTwo_Tests
{
    private Outings _outings;
    private Outings_Repository _oRepo;

    public Outings_Repo_Testing_Site()
    {
        _outings = new Outings(EventType.Bowling, 37, 2022, 04, 21, 23.00, 602.99);
        _oRepo = new Outings_Repository();
        _oRepo.AddOutingToDatabase(_outings);
    }
    [Fact]
    public void Get_Outing_By_EventType()
    {
        Outings searchedOuting = _outings.GetOutingsByID(EventType.Bowling);
        Asser.Equal(searchedOuting, _outings);
    }
    [Fact]
    public void Remove_Outing_ShouldReturnTrue()
    {
        Outings eventHappening = _oRepo.GetOutingsByID(EventType.Bowling);
        bool removeResult = _oRepo.RemoveOutingFromDatabase(eventHappening);

        Assert.True(removeResult);
    }
}