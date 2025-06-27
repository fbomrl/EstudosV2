using System;

namespace _115_Exercicio_proposto.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }
        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag()
        {
            return $"(Manufacture date {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
