namespace Calculations.Test;

[Collection("Customer")]
public class CustomerTests(CustomerFixture customerFixture)
{
    [Fact]
    public void CheckNameNotEmpty()
    {
        var customer = customerFixture.Cust;
        Assert.NotNull(customer.Name);
        Assert.False(string.IsNullOrEmpty(customer.Name));
    }

    [Fact]
    public void CheckLegitForDiscount()
    {
        var customer = customerFixture.Cust;
        Assert.InRange(customer.Age, 25, 40);
    }

    [Fact]
    public void GetOrdersByNameNoNull()
    {
        var customer = customerFixture.Cust;
        var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
        Assert.Equal("hello", exceptionDetails.Message);
    }

    [Fact]
    public void LoyalCustomerForOrdersGT100()
    {
        var customer = CustomerFactory.CreateCustomerInstance(102);
        var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
        Assert.Equal(10, loyalCustomer.Discount);
    }
}
