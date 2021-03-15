using FluentBuilderDemo.Models;
using System;

namespace FluentBuilderDemo.Services
{
    public class OrderBuilder
    {
        private Order _order = new Order();

        public OrderBuilder()
        {
        }

        public Order Build()
        {
            this._order.Date = DateTime.Now;
            return this._order;
        }

        /// <summary>
        /// Setting up the order number
        /// </summary>
        /// <param name="oNumber"></param>
        /// <returns></returns>
        public OrderBuilder SetOrderNumber(int oNumber)
        {
            this._order.OrderNumber = oNumber; 
            return this;
        }

        /// <summary>
        /// Set the customer for order
        /// </summary>
        /// <param name="Customer"></param>
        /// <returns></returns>
        public OrderBuilder SetCustomer(string Customer)
        {
            this._order.Customer = Customer;
            return this;
        }

        /// <summary>
        /// Set the Shipping for order
        /// </summary>
        /// <param name="shipping"></param>
        /// <returns></returns>
        public OrderBuilder SetShipping(string shipping)
        {
            this._order.Shipping = shipping;
            return this;
        }

        /// <summary>
        /// Add item to order
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public OrderBuilder AddItem(string item)
        {
            this._order.Items.Add(item);
            return this;
        }
        
    }
}
