namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void String_reversal_aralC()
    {   
        //Arrange
       var reverse = (string str) => str.Reverse();

        //Act
       var actual = reverse("Clara");

        //Assert
       Assert.Equal("aralC", actual);

    }

    [Fact]
    public void Test_product_2_x_2()
    {   
        //Arrange
       var product = (int x) => x*x;

        //Act
       var actual = product(2);

        //Assert
       Assert.Equal(4, actual);

    }

     [Fact]
    public void Test_numerical_equal_0042()
    {   
        //Arrange
       var numEqual = (string str, int x) => int.Parse(str) == x;

        //Act
       var actual = lambda("0042", 42);

        //Assert
       Assert.Equal(true, actual);

    }
}
