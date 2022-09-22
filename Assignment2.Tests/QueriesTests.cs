namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void Test_findRowling_Harry_Hermione_Ron()
    {
        //Arrange
        var input = WizardCollection.Create();
        string[] expected = {"Harry Potter", "Hermione Granger", "Ron Weasley"};

        //Act
        var actual = Queries.findRowlings(input);

        //Assert
        Assert.Equal(expected, actual);

    }

    [Fact]
    public void Test_findRowlingAgain_Harry_Hermione_Ron()
    {
        //Arrange
        var input = WizardCollection.Create();
        string[] expected = {"Harry Potter", "Hermione Granger", "Ron Weasley"};

        //Act
        var actual = Queries.findRowlingAgain(input);

        //Assert
        Assert.Equal(expected, actual);

    }

    [Fact]
    public void Test_findSithYear_1977()
    {
        //Arrange
        var input = WizardCollection.Create();
        int expected = 1977;

        //Act
        var actual = Queries.findSithYear(input);

        //Assert
        Assert.Equal(expected, actual);

    }


    [Fact]
    public void Test_findSithYearAgain_1977()
    {
        //Arrange
        var input = WizardCollection.Create();
        int expected = 1977;

        //Act
        var actual = Queries.findSithYearAgain(input);

        //Assert
        Assert.Equal(expected, actual);

    }


    [Fact]
    public void Test_findHarryPotterCharater_Harry_Hermione_Ron_1997()
    {
        //Arrange
        var input = WizardCollection.Create();
        var expected = new List<(string, int?)> {("Harry Potter", 1997), ("Hermione Granger", 1997), ("Ron Weasley", 1997)};

        //Act
        var actual = Queries.findHarryPotterCharater(input);

        //Assert
        Assert.Equal(expected, actual);

    }

    [Fact]
    public void Test_findHarryPotterCharaterAgain_Harry_Hermione_Ron_1997()
    {
        //Arrange
        var input = WizardCollection.Create();
        var expected = new List<(string, int?)> {("Harry Potter", 1997), ("Hermione Granger", 1997), ("Ron Weasley", 1997)};

        //Act
        var actual = Queries.findHarryPotterCharaterAgain(input);

        //Assert
        Assert.Equal(expected, actual);

    }

    [Fact]
    public void Test_findWizardNames_()
    {
        //Arrange
        var input = WizardCollection.Create();
        string[] expected = {"Glinda the Good Witch", "Gandalf", 
                        "Sauron", "Harry Potter", 
                        "Hermione Granger", "Ron Weasley", 
                        "Bloom", "The Red Woman",
                        "Darth Vader","The White Witch"};

        //Act
        var actual = Queries.findWizardNames(input);

        //Assert
        Assert.Equal(expected, actual);

    }

     [Fact]
    public void Test_findWizardNamesAgain_()
    {
        //Arrange
        var input = WizardCollection.Create();
        string[] expected = {"Glinda the Good Witch", "Gandalf", 
                        "Sauron", "Harry Potter", 
                        "Hermione Granger", "Ron Weasley", 
                        "Bloom", "The Red Woman",
                        "Darth Vader","The White Witch"};

        //Act
        var actual = Queries.findWizardNamesAgain(input);

        //Assert
        Assert.Equal(expected, actual);

    }
}
