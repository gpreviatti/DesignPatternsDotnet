using Commons.Models;
using Strategy;
using Strategy.Strategies;

var order = new Order()
{
    Id = 1,
    OrderItems = new List<Item>
    {
        new() { Id = 1, Name = "Computer", Total = 1, Value = 500}
    }
};
order.SetValue();

var calculatorIcms = new TaxCalculator(new IcmsTax()).Calculate(order.Value);
var calculatorIss = new TaxCalculator(new IssTax()).Calculate(order.Value);

Console.WriteLine(calculatorIcms);
Console.WriteLine(calculatorIss);