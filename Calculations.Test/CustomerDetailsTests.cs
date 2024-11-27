namespace Calculations.Test;

[Collection("Customer")]
public class CustomerDetailsTests(CustomerFixture customerFixture)
{
    [Fact]
    public void GetFullName_GivenFirstAndLastNames_ReturnsFullName()
    {
        var customer = customerFixture.Cust;
        Assert.Equal("Vince Lombardi", customer.GetFullName("Vince", "Lombardi"));
    }
}
