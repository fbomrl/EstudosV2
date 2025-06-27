using System;

namespace _119_Exercicio_proposto_metodos_abstratos.Entities
{
    class Company : TaxPayer
    {
        public int NumberEmployees { get; set; }

        public Company(string name, double anualIncome, int numberEmployees)
                : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }
        public override double Tax()
        {
            if (NumberEmployees < 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}