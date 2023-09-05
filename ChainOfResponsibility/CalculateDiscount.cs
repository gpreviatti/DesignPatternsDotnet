namespace ChainOfResponsibility;

public class CalculateDiscount
{
    public float Execute(float value)
    {
        var withoutDiscount = new WithoutDiscount();
        var discountTwenty = new DiscountTwentyPercent(withoutDiscount);
        var discountFifty = new DiscountFiftyPercent(discountTwenty);

        return discountFifty.Handle(value);
    }
}