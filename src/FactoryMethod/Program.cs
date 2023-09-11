using Commons.Models;
using FactoryMethod;

var order = new Order
{
    Id = 1,
    OrderItems = new List<Item> {
        new() { Id = 1, Name = "Computer", Total = 2, Value = 1000 },
        new() { Id = 2, Name = "Keyboard", Total = 2, Value = 100 },
    }
};

order.SetValue();

FileFactory.Save("", order);

FileFactory.Delete("");