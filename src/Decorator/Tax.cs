namespace Decorator;

public abstract class Tax
{
    private readonly Tax? _tax;

    protected Tax() { }
    protected Tax(Tax tax) => _tax = tax;

    public float Handle(float value)
    {
        var tax = ShouldCalculateTax(value) ? HandleMaxTax(value) : HandleMinTax(value);

        return tax + _tax?.Handle(value) ?? tax;
    }

    protected abstract bool ShouldCalculateTax(float value);
    protected abstract float HandleMaxTax(float value);
    protected abstract float HandleMinTax(float value);
}