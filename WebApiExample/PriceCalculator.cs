using System;
using System.Text.RegularExpressions;

namespace WebApiExample;


public class PriceCalculator
{
    const decimal RATE = 0.02m;    
    public decimal CalcTax (decimal amount)
    {
        if (amount < 0 )
        throw new ArgumentOutOfRangeException($"Amount is {amount}");
        return Math.Round(amount * RATE, 2);
    }
}
