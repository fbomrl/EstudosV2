using _141_Solucao_Com_Interface.Services.Interface;

namespace _141_Solucao_Com_Interface.Services
{
    class BrazilTaxServices : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
