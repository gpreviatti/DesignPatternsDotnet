using Commons.Models;

namespace Observer;
internal class GenerateInvoiceSubscriber : IOrderSubscriber
{
    public void Handle(Order order) => Console.WriteLine("Generating invoice to order {0}", order.Id);
}
