namespace Calculations.Test;

public class CalculationsTests
{
    [Fact]
    [Trait("Catagory", "Fibo")]
    public void FiboDoesNotIncludeZero()
    {
        var calc = new Calculations();
        Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
    }

    [Fact]
    [Trait("Catagory", "Fibo")]
    public void FiboIncludes13()
    {
        var calc = new Calculations();
        Assert.Contains(13, calc.FiboNumbers);
    }

    [Fact]
    [Trait("Catagory", "Fibo")]
    public void FiboDoesNotInclude4()
    {
        var calc = new Calculations();
        Assert.DoesNotContain(4, calc.FiboNumbers);
    }

    [Fact]
    [Trait("Catagory", "Fibo")]
    public void CheckCollection()
    {
        var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
        var calc = new Calculations();
        Assert.Equal(expectedCollection, calc.FiboNumbers);
    }
}
