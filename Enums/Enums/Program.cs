using System;
using OrderStatus;



Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.OrderStatus.PendingPayment
};

Console.WriteLine(order);