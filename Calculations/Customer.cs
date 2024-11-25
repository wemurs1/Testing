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

public class LoyalCustomer : Customer
{
    public LoyalCustomer()
    {
        Discount = 10;
    }

    public int Discount { get; set; }
}

public static class CustomerFactory
{
    public static Customer CreateCustomerInstance(int orderCount)
    {
        if (orderCount <= 100) return new Customer();

        return new LoyalCustomer();
    }
}
