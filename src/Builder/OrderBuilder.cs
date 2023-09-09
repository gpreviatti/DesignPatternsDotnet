using Commons.Models;

namespace Builder;

public class OrderBuilder
{
    private readonly Random _random = new();
    private int Id { get; set; }
    private float Value { get; set; }
    private IList<Item> OrderItems { get; set; } = new List<Item>();
    public OrderBuilder() => Id = _random.Next(111111, 999999);
    public OrderBuilder AddItem(string name, int total, float value)
    {
        OrderItems.Add(new()
        {
            Id = _random.Next(111111, 999999),
            Name = name,
            Value = value,
            Total = total
        });

        Value += value;

        return this;
    }

    public Order Build() => new()
    {
        Id = Id,
        Value = Value,
        OrderItems = OrderItems
    };
}