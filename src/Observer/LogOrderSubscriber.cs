using Commons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer;
internal class LogOrderSubscriber : IOrderSubscriber
{
    public void Handle(Order order) => Console.WriteLine("Loggin order {0}", order.Id);
}
