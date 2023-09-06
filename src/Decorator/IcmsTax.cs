namespace Decorator;

public class IcmsTax : Tax
{
    public IcmsTax() { }
    public IcmsTax(Tax tax) : base(tax) { }

    protected override bool ShouldCalculateTax(float value) => value > 100;
    protected override float HandleMaxTax(float value) => value + (value * 0.3f);
    protected override float HandleMinTax(float value) => value + (value * 0.1f);
}