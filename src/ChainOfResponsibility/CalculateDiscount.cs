namespace ChainOfResponsibility;

public class CalculateDiscount
{
    public float Handle(float value)
    {
        var withoutDiscount = new WithoutDiscount();
        var discountTwenty = new DiscountTwentyPercent(withoutDiscount);
        var discountFifty = new DiscountFiftyPercent(discountTwenty);

        return discountFifty.Handle(value);
    }
}