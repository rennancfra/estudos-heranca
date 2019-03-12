namespace exercicio_resolvido_polimorfismo.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double additionalCharge { get; set; }

        public OutSourcedEmployee()
        {

        }
        public override double Payment()
        {
            return base.Payment() + 1.1 * additionalCharge;
        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            this.additionalCharge = additionalCharge;
        }
    }
}
