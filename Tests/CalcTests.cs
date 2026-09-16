using WebApiExample;
using Xunit;

namespace Tests;

public class CalcTests
{
    [Theory]
    [InlineData(100, 2)]
    [InlineData(0, 0)]
    public void TWithTax_AddTowPercents(decimal amount, decimal expected)
    {
        var calc = new PriceCalculator();
        var result = calc.CalcTax(amount);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WithTax_NegativAmount_throws_Exception()
    {
         var calc = new PriceCalculator();
        Assert.Throws<ArgumentOutOfRangeException>(() => calc.CalcTax(-1m));
    }
}
