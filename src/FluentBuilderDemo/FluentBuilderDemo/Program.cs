using FluentBuilderDemo.Models;
using FluentBuilderDemo.Services;
using Newtonsoft.Json;
using System;

namespace FluentBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Fluent Builder!");

            OrderBuilder orderBuilder = new OrderBuilder();
            Order order = orderBuilder
                .SetOrderNumber(10)
                .SetCustomer("Demo Customer")
                .SetShipping("Shipping methode 1")
                .AddItem("Item 1")
                .AddItem("Item 2")
                .Build();

            Console.WriteLine("the order is ready");
            Console.WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));

            Console.ReadLine();
        }
    }
}
