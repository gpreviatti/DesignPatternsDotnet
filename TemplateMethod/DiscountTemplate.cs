namespace TemplateMethod;

public abstract class DiscountTemplate
{
    public float Handle(float value)
        => ShouldCalculateDiscount(value) ? HandleMaxDiscount(value) : HandleMinDiscount(value);
    protected abstract bool ShouldCalculateDiscount(float value);
    protected abstract float HandleMaxDiscount(float value);
    protected abstract float HandleMinDiscount(float value);
}