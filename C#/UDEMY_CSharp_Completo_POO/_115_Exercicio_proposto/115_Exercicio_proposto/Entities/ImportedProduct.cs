namespace _115_Exercicio_proposto.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFee)
                :base(name, price)
        {
            CustomsFee = customsFee;
            Price = TotalPrice();
        }
        public override string PriceTag()
        {
            
            return $" (Customs fee: $ {CustomsFee})";
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
