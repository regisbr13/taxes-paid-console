
namespace TaxesPaidConsole.Entities
{
    class IndiviualPayer : Payer
    {
        public double HealthExpenditures { get; set; }

        public IndiviualPayer()
        {
        }

        public IndiviualPayer(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            if(AnualIncome < 20000.00)
            {
                if(HealthExpenditures > 0.00)
                {
                    return AnualIncome * 0.15 - HealthExpenditures / 2.0;
                }
                return 2000.00 * 0.15;
            }
            if (HealthExpenditures > 0.00)
            {
                return AnualIncome * 0.25 - HealthExpenditures / 2.0;
            }
            return 2000.00 * 0.25;
        }
    }
}
