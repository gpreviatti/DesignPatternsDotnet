using Commons.Models;

namespace Observer;
public class OrderPublisher
{
    private List<IOrderSubscriber> Subscribers { get; set; } = new();

    public void Handle(Order order)
    {
        order.SetValue();

        Subscribers.ForEach(subscriber => subscriber.Handle(order));
    }

    public void AddSubscriber(IOrderSubscriber subscriber) => Subscribers.Add(subscriber);
}
