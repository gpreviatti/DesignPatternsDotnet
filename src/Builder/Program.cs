using Builder;

var order = new OrderBuilder()
    .AddItem("Computer", 2, 500)
    .AddItem("Mouse", 1, 100)
    .AddItem("Keyboard", 1, 200)
    .AddItem("Monitor", 1, 500)
    .AddItem("Headphones", 1, 100)
    .Build();

Console.WriteLine("Order value: {0}", order.Value);
Console.WriteLine("Order total items add to cart : {0}", order.OrderItems.Count());