using Commons.Models;
using Observer;

var order = new Order
{
    Id = 1,
    OrderItems = new List<Item>
    {
        new() { Id = 1, Name = "Computer", Total = 1, Value = 500},
        new() { Id = 2, Name = "Mouse", Total = 1, Value = 50},
        new() { Id = 3, Name = "Keyboard", Total = 1, Value = 100},
        new() { Id = 4, Name = "Monitor", Total = 1, Value = 300},
    }
};

var orderPublisher = new OrderPublisher();

orderPublisher.AddSubscriber(new GenerateInvoiceSubscriber());
orderPublisher.AddSubscriber(new SendWarehouseNotificationSubscriber());
orderPublisher.AddSubscriber(new SaveOrderSubscriber());
orderPublisher.AddSubscriber(new LogOrderSubscriber());

orderPublisher.Handle(order);