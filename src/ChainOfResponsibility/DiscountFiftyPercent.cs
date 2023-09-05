namespace ChainOfResponsibility;

public class DiscountFiftyPercent : IDiscount
{
    public DiscountFiftyPercent(IDiscount? next) => Next = next;

    public IDiscount? Next { get; set; }

    public float Handle(float value)
    {
        if (value > 500)
            return value - (value * 0.5f);

        return Next!.Handle(value);
    }
}