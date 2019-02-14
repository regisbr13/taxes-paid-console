using System.Collections.Generic;

namespace TaxesPaidConsole.Entities
{
    abstract class Payer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Payer()
        {
        }

        public Payer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxesPaid();

        public double TotalTaxes(List<Payer> payers)
        {
            double sum = 0.0;
            foreach (Payer p in payers)
            {
                sum += p.TaxesPaid();
            }
            return sum;
        }
    }
}
