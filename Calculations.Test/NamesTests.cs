namespace Calculations.Test;

public class NamesTests
{
    [Fact]
    public void MakeFullNameTest()
    {
        var names = new Names();
        var result = names.MakeFullName("John", "Brown");
        Assert.Equal("John Brown", result, ignoreCase: true);
    }
}
