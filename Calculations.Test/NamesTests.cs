namespace Calculations.Test;

public class NamesTests
{
    [Fact]
    public void MakeFullNameTest()
    {
        var names = new Names();
        var result = names.MakeFullName("John", "Brown");
        // Assert.Equal("John Brown", result, ignoreCase: true);
        // Assert.Contains("John", result, StringComparison.InvariantCultureIgnoreCase);
        // Assert.StartsWith("John", result);
        // Assert.EndsWith("Brown", result);
        Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
    }

    [Fact]
    public void NickName_MustBeNull()
    {
        var names = new Names();
        names.NickName = "";
        Assert.NotNull(names.NickName);
    }

    [Fact]
    public void MakeFullName_AlwaysReturnValue()
    {
        var names = new Names();
        var result = names.MakeFullName("John", "Brown");
        // Assert.True(!string.IsNullOrEmpty(result));
        Assert.False(string.IsNullOrEmpty(result));
    }
}
