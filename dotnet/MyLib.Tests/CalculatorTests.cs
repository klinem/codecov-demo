namespace MyLib.Tests;

public class CalculatorTests
{
    [Fact]
    public void Adds()
    {
        var calc = new Calculator();

        Assert.Equal(2, calc.Add(1, 1));
    }
}