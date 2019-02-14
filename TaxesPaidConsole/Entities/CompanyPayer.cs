using System;
using System.Collections.Generic;
using System.Text;

namespace TaxesPaidConsole.Entities
{
    class CompanyPayer : Payer
    {
        public int EmployeesNumber { get; set; }

        public CompanyPayer()
        {
        }

        public CompanyPayer(string name, double anualIncome, int employeesNumber) : base(name, anualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double TaxesPaid()
        {
            if(EmployeesNumber <= 10)
            {
                return AnualIncome * 0.16;
            }
            return AnualIncome * 0.14;
        }
    }
}
