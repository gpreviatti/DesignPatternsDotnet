using Commons.Models;

namespace Observer;
internal class SendWarehouseNotificationSubscriber : IOrderSubscriber
{
    public void Handle(Order order) => Console.WriteLine("Sending order {0} to warehouse", order.Id);
}
