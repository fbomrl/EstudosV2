using _097_Enumeracoes.Entities.Enums;
using System;

namespace _097_Enumeracoes.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
            + ", "
            + Moment
            + ", "
            + Status;
        }
    }
}
