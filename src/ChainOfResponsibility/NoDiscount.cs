namespace ChainOfResponsibility;

public class WithoutDiscount : IDiscount
{
    public IDiscount? Next { get; set; }
    public float Handle(float value) => value;
}