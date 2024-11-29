namespace Calculations.Test;

public class CalculationsFixture : IDisposable
{
    public Calculations Calc => new();

    public void Dispose()
    {
        // Cleanup code
    }
}

public class CalculationsTests(CalculationsFixture calculationsFixture) : IClassFixture<CalculationsFixture>
{
    [Fact]
    [Trait("Catagory", "Fibo")]
    public void FiboDoesNotIncludeZero()
    {
        var calc = calculationsFixture.Calc;
        Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
    }

    [Fact]
    [Trait("Catagory", "Fibo")]
    public void FiboIncludes13()
    {
        var calc = calculationsFixture.Calc;
        Assert.Contains(13, calc.FiboNumbers);
    }

    [Fact]
    [Trait("Catagory", "Fibo")]
    public void FiboDoesNotInclude4()
    {
        var calc = calculationsFixture.Calc;
        Assert.DoesNotContain(4, calc.FiboNumbers);
    }

    [Fact]
    [Trait("Catagory", "Fibo")]
    public void CheckCollection()
    {
        var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
        var calc = calculationsFixture.Calc;
        Assert.Equal(expectedCollection, calc.FiboNumbers);
    }

    [Fact]
    public void IsOdd_GivenOddValue_ReturnsTrue()
    {
        var calc = calculationsFixture.Calc;
        var result = calc.IsOdd(1);
        Assert.True(result);
    }

    [Fact]
    public void IsOdd_GivenEvenValue_ReturnsFalse()
    {
        var calc = calculationsFixture.Calc;
        var result = calc.IsOdd(2);
        Assert.False(result);
    }

    [Theory]
    // [MemberData(nameof(TestDataShare.IsOddOrEvenExternalData), MemberType = typeof(TestDataShare))]
    [IsOddOrEvenData]
    public void IsOdd_TestOddAndEven(int value, bool expected)
    {
        var calc = calculationsFixture.Calc;
        var result = calc.IsOdd(value);
        Assert.Equal(expected, result);
    }
}
