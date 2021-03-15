using System;
using System.Collections.Generic;

namespace FluentBuilderDemo.Models
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public DateTime Date { get; set; }
        public string Customer { get; set; }
        public string Shipping { get; set; }
        public List<string> Items { get; set; }

        public Order()
        {
            this.Items = new List<string>();
        }
    }
}
