namespace ChainOfResponsibility;

public class DiscountTwentyPercent : IDiscount
{
    public DiscountTwentyPercent(IDiscount? next) => Next = next;

    public IDiscount? Next { get; set; }
    public float Handle(float value)
    {
        if (value > 200)
            return value - (value * 0.2f);

        return Next!.Handle(value);
    }
}