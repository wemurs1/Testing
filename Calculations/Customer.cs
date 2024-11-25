namespace Calculations;

public class Customer
{
    public string Name => "Fred";
    public int Age => 35;
    public int GetOrdersByName(string? name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("hello");
        }
        return 100;
    }
}
