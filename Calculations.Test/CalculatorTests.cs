using Xunit;

namespace Calculations.Test;

public class CalculatorTests
{
    [Fact]
    public void Add_Given2IntValues_ReturnsInt()
    {
        var calc = new Calculator();
        var result = calc.Add(1, 2);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Add_Given2DoubleValues_ReturnsDouble()
    {
        var calc = new Calculator();
        var result = calc.Add(1.2, 3.5);
        Assert.Equal(4.7, result);
    }
}
