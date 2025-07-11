﻿
namespace _113_Exercicio_Resolvido_PT_1.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
                : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
