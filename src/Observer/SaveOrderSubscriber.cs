using Commons.Models;

namespace Observer;
internal class SaveOrderSubscriber : IOrderSubscriber
{
    public void Handle(Order order) => Console.WriteLine("Saving order {0} to database", order.Id);
}
