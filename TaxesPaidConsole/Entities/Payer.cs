using System;
using System.Collections.Generic;
using System.Text;

namespace TaxesPaidConsole.Entities
{
    abstract class Payer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public abstract double TaxesPaid();
    }
}
