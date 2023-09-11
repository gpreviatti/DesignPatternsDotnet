namespace Commons.Models;

public class Order
{
    public int Id { get; set; }
    public float Value { get; private set; }

    public IEnumerable<Item> OrderItems { get; set; }

    public void SetValue()
    {
        if (OrderItems is null)
            return;

        Value = OrderItems.Sum(x => x.Value * x.Total);
    }
}