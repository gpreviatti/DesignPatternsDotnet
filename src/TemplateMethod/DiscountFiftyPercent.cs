namespace TemplateMethod;

public class DiscountFiftyPercent : DiscountTemplate
{
    protected override bool ShouldCalculateDiscount(float value) => value >= 500;
    protected override float HandleMaxDiscount(float value) => value - (value * 0.5f);
    protected override float HandleMinDiscount(float value) => value - (value * 0.25f);
}