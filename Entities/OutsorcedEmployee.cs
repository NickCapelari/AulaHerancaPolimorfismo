﻿namespace ExercicioHerancaPolimorfismo.Entities
{
    internal class OutsorcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsorcedEmployee() { }

        public OutsorcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base (name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }
    }
}
