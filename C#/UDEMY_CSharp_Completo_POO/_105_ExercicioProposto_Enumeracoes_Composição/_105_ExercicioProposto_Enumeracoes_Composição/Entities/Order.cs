using _105_ExercicioProposto_Enumeracoes_Composição.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105_ExercicioProposto_Enumeracoes_Composição.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        Order()
        {

        }
        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total(OrderItem itemTotal)
        {
            return Items = itemTotal.Price * itemTotal.Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine("Order moment: ");
            sb.Append(DateTime.Now);
            sb.AppendLine("Order Status: ");
            sb.Append(OrderStatus.Processing);
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" - " + Client.Email);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                sb.Append($"{item.Product}, ${item.Price}, {item.SubTotal}");
            }
            sb.Append($"Total price: {Total(Items)}");
        }
    }
}
