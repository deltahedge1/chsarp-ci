namespace PrimeService.Tests;

using Microsoft.VisualBasic;
using Prime.Services;

public class PrimeService_IsPrimeShould
{
    private readonly PrimeService _primeService;
    public PrimeService_IsPrimeShould()
    {
        _primeService = new PrimeService();
    }
    
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void IsPrime_LessThan2_ReturnFalse(int value)
    {
            var result = _primeService.IsPrime(value);
            Assert.False(result, $"{value} should not be prime");

    }

    [Theory]
    [InlineData(3)]
    [InlineData(7)]
    [InlineData(11)]
    public void IsPrime_ReturnTrue(int value)
    {
        var result = _primeService.IsPrime(value);
        Assert.True(result, "3 should be prime");
    }
}