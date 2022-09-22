namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Test_wordCount_Hello_world_im_clara()
    {
        //Arrange
        var input = "Hello world i'm Clara";
        var expect = 4;

        //Act
        var actual = Extensions.WordCount(input);

        //Assert
        Assert.Equal(expect, actual);
    }

     [Fact]
    public void Test_uri_scheme_true()
    {
        //Arrange
        var input = new Uri("https://itu.dk/");
        var expect = true;

        //Act
        var actual = Extensions.isSecure(input);

        //Assert
        Assert.Equal(expect, actual);
    }
}
