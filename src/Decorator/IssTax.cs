namespace Decorator;

public class IssTax : Tax
{
    public IssTax() { }
    public IssTax(Tax tax) : base(tax) { }

    protected override bool ShouldCalculateTax(float value) => value > 300;
    protected override float HandleMaxTax(float value) => value + (value * 0.5f);
    protected override float HandleMinTax(float value) => value + (value * 0.2f);
}