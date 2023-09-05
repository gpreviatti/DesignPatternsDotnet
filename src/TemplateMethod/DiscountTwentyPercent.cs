namespace TemplateMethod;

public class DiscountTwentyPercent : DiscountTemplate
{
    protected override bool ShouldCalculateDiscount(float value) => value > 200;
    protected override float HandleMaxDiscount(float value) => value - (value * 0.2f);
    protected override float HandleMinDiscount(float value) => value - (value * 0.1f);
}