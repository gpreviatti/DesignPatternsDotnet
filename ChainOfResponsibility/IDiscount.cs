namespace ChainOfResponsibility;

public interface IDiscount
{
    public IDiscount? Next { get; set; }
    public float Handle(float value);
}