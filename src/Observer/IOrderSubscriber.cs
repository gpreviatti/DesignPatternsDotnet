using Commons.Models;

namespace Observer;
public interface IOrderSubscriber
{
    void Handle(Order order);
}
